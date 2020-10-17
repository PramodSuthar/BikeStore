using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBikesStore;
using MyBike_Store_Data_Layer;

namespace MyBike_Store_Presentation_Layer
{
    public partial class Form1 : Form
    {
        List<Bike> bikesList = new List<Bike>();
        List<MountainBike> MountainBikesList = new List<MountainBike>();
        List<Roadbike> roadbikesList = new List<Roadbike>();

        private Bike lastSelectedBike;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bikeTypeDropDown.Items.Add("Mountain Bike");
            bikeTypeDropDown.Items.Add("Road Bike");
            colorComboBox.DataSource = Enum.GetValues(typeof(MyBikesStore.EnumColor));
            suspensionComboBox.DataSource = Enum.GetValues(typeof(MyBikesStore.EnumSuspension));
            suspensionComboBox.Enabled = false;
            seatHeightTextBox.Enabled = false;
        }

        private void bikeTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            ToggleBikes(cmb.Text);
        }

        private void ToggleBikes(string bike)
        {
            if (bike.Equals("Mountain Bike"))
            {
                suspensionComboBox.Enabled = true;
                seatHeightTextBox.Enabled = false;
            }
            else if (bike.Equals("Road Bike"))
            {
                suspensionComboBox.Enabled = false;
                seatHeightTextBox.Enabled = true;
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }
            bikeTypeDropDown.Focus();
            resultsTextBox.Items.Clear();
            searchSerialText.Clear();
            seatHeightTextBox.Clear();
            colorComboBox.Text = "White";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to exit? ", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string input;
            long serNum = 0;
            string make = "";
            double speed = 0, seatHeight = 0;
            MyBikesStore.Date date;
            bool correct = false;

            if (bikeTypeDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("\t...Not valid.. The input must be 12 digits only...\n");
                return;
            }

            //-------------validation for serial number
            input = serialTextBox.Text;
            correct = MyBikesStore.Bus.RegExValidator.Is12Digit(input) &&
                    MyBikesStore.Bus.RegExValidator.IsEmpty(input);
            if (!correct)
            {
                MessageBox.Show("\t...Not valid. The input must be digits and 12 digits only.. PLease try again...\n");
                return;
            }
            serNum = long.Parse(input);

            correct = false;
            input = makeInputTextBox.Text;
            correct = MyBikesStore.Bus.RegExValidator.IsAlphabetLetter(input) &&
                    MyBikesStore.Bus.RegExValidator.IsEmpty(input);
            if (!correct)
            {
                MessageBox.Show("\tThe input must not be empty and must be alphabets only\n");
                return;
            }
            make = input;

            correct = false;
            input = speedTextBox.Text;
            correct = MyBikesStore.Bus.RegExValidator.IsDigit(input) &&
                    MyBikesStore.Bus.RegExValidator.IsEmpty(input);
            if (!correct)
            {
                MessageBox.Show("\tThe input must not be empty and must be alphabets only. Please try again \n");
                return;
            }
            speed = Convert.ToDouble(input);


            correct = false;
            input = speedTextBox.Text;
            correct = MyBikesStore.Bus.RegExValidator.IsDigit(dayTextBox.Text) &&
                MyBikesStore.Bus.RegExValidator.IsDigit(monthTextBox.Text) &&
                MyBikesStore.Bus.RegExValidator.IsDigit(yearTextBox.Text) &&
                MyBikesStore.Bus.RegExValidator.IsEmpty(dayTextBox.Text) &&
                MyBikesStore.Bus.RegExValidator.IsEmpty(monthTextBox.Text) &&
                MyBikesStore.Bus.RegExValidator.IsEmpty(yearTextBox.Text);
            if (!correct)
            {
                MessageBox.Show("\t...The input must not be empty and must be digits only. Please try again...\n");
                return;
            } while (!correct) ;

            date = new Date(Convert.ToInt32(dayTextBox.Text),
                Convert.ToInt32(monthTextBox.Text),
                Convert.ToInt32(yearTextBox.Text));
            Bike bike;
            string successMsg = "";
            if (bikeTypeDropDown.SelectedIndex == 1)
            {
                correct = false;
                input = seatHeightTextBox.Text;
                correct = MyBikesStore.Bus.RegExValidator.IsDigit(input) &&
                MyBikesStore.Bus.RegExValidator.IsEmpty(input);
                if (!correct)
                {
                    MessageBox.Show("\t...The input must not be empty and must be digits only. Please try again..\n");
                    return;
                }
                seatHeight = Convert.ToInt32(input);
                Roadbike rbike = new Roadbike(serNum, make, speed,
                    (EnumColor)Enum.Parse(typeof(EnumColor), colorComboBox.Text),
                    date, seatHeight);
                roadbikesList.Add(rbike);
                bike = (Bike)rbike;
                successMsg = "Bike successfully added as a road bike and ";
            }
            else
            {
                MountainBike mbike = new MountainBike(serNum, make, speed,
                    (EnumColor)Enum.Parse(typeof(EnumColor), colorComboBox.Text),
                    date, (EnumSuspension)Enum.Parse(typeof(EnumSuspension), suspensionComboBox.Text));
                MountainBikesList.Add(mbike);
                bike = (Bike)mbike;
                successMsg = "Bike successfully added as a mountain bike and ";
            }
            bikesList.Add(bike);
            successMsg += "a bike";
            MessageBox.Show(successMsg);
        }

        private void displayMountainBikes_Click(object sender, EventArgs e)
        {
            resultsTextBox.Items.Clear();
            if (MountainBikesList.Count > 0)
            {
                foreach (MountainBike mbike in MountainBikesList)
                    resultsTextBox.Items.Add(mbike);
            }
            else
            {
                MessageBox.Show("\n" + "No data entered. The list is empty!!");
            }
        }

        private void DisplayRoadBike_Click(object sender, EventArgs e)
        {
            resultsTextBox.Items.Clear();
            if (roadbikesList.Count > 0)
            {
                foreach (Roadbike rbike in roadbikesList)
                    resultsTextBox.Items.Add(rbike);
            }
            else
            {
                MessageBox.Show("\n" + "No data entered. The list is empty!!");
            }
        }

        private void dispAllBikeButton_Click(object sender, EventArgs e)
        {
            resultsTextBox.Items.Clear();
            if (bikesList.Count > 0)
            {
                foreach (Bike bike in bikesList)
                    resultsTextBox.Items.Add(bike);
            }
            else
            {
                MessageBox.Show("\n" + "No data entered. The list is empty!!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchSerialText.Text.Equals("") ||
                !MyBikesStore.Bus.RegExValidator.Is12Digit(searchSerialText.Text))
            {
                MessageBox.Show("Enter a valid value for serial number..!!");
                return;
            }
            Boolean haveResults = false;
            resultsTextBox.Items.Clear();
            if (bikesList.Count > 0)
            {
                foreach (Bike bike in bikesList)
                {
                    if (bike.SerialNumber.Equals(long.Parse(searchSerialText.Text)))
                    {
                        resultsTextBox.Items.Add(bike);
                        haveResults = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("\n" + "No data entered.The list is empty");
            }
            if (!haveResults)
                MessageBox.Show("No Search Results..!!");
        }

        private void resultsTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = resultsTextBox.SelectedIndex;
            ListBox cmb = (ListBox)sender;

            foreach (var item in resultsTextBox.SelectedItems)
            {
                showBike((Bike)item);
                lastSelectedBike = (Bike)item;
            }

        }

        private void showBike(Bike bike)
        {
            string[] bikeAttr = bike.ToString().Split('\t');
            serialTextBox.Text = bikeAttr[0];
            makeInputTextBox.Text = bikeAttr[1];
            speedTextBox.Text = bikeAttr[3];
            colorComboBox.Text = bikeAttr[5];
            string[] bikeDateAttr = bikeAttr[7].Split('/');
            dayTextBox.Text = bikeDateAttr[0];
            monthTextBox.Text = bikeDateAttr[1];
            yearTextBox.Text = bikeDateAttr[2];
            if (bike is Roadbike)
            {
                seatHeightTextBox.Text = bikeAttr[9];
                bikeTypeDropDown.Text = "Road Bike";
                if (seatHeightTextBox.Enabled == false)
                    ToggleBikes("Road Bike");
            }
            else if (bike is MountainBike)
            {
                suspensionComboBox.Text = bikeAttr[11];
                bikeTypeDropDown.Text = "Mountain Bike";
                if (suspensionComboBox.Enabled == false)
                    ToggleBikes("Mountain Bike");
            }
        }

        private int GetIndexOfInList(Bike inptBike, List<Object> inptList)
        {
            int indx = -1;
            for (int i = 0; i < inptList.Count; i++)
                if (inptList[i].ToString().Equals(inptBike.ToString()))
                    indx = i;
            return indx;
        }

        private List<Object> BikeToObject(List<Bike> bikes)
        {
            List<Object> objList = new List<Object>();
            foreach (Bike itrBike in bikes)
                objList.Add((object)itrBike);
            return objList;
        }

        private List<Object> RoadBikeToObject(List<Roadbike> rBikes)
        {
            List<Object> objList = new List<Object>();
            foreach (Bike itrBike in rBikes)
                objList.Add((object)itrBike);
            return objList;
        }

        private List<Object> MountainBikeToObject(List<MountainBike> mBikes)
        {
            List<Object> objList = new List<Object>();
            foreach (Bike itrBike in mBikes)
                objList.Add((object)itrBike);
            return objList;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int indexInBikes = GetIndexOfInList(lastSelectedBike,
                BikeToObject(bikesList));
            int indexInType = -1;
            Bike newObj;
            if (lastSelectedBike is Roadbike)
            {
                indexInType = GetIndexOfInList(lastSelectedBike, RoadBikeToObject(roadbikesList));
                newObj = new Roadbike(long.Parse(serialTextBox.Text), makeInputTextBox.Text,
                    Convert.ToInt32(speedTextBox.Text), (EnumColor)Enum.Parse(typeof(EnumColor),
                    colorComboBox.Text),
                    new Date(Convert.ToInt32(dayTextBox.Text), Convert.ToInt32(monthTextBox.Text),
                    Convert.ToInt32(yearTextBox.Text)), Convert.ToInt32(seatHeightTextBox.Text));
                roadbikesList.RemoveAt(indexInType);
                roadbikesList.Insert(indexInType, (Roadbike)newObj);
            }
            else //if (lastSelectedBike is MountainBike)
            {
                indexInType = GetIndexOfInList(lastSelectedBike, MountainBikeToObject(MountainBikesList));
                newObj = new MountainBike(long.Parse(serialTextBox.Text), makeInputTextBox.Text,
                    Convert.ToInt32(speedTextBox.Text), (EnumColor)Enum.Parse(typeof(EnumColor),
                    colorComboBox.Text),
                    new Date(Convert.ToInt32(dayTextBox.Text), Convert.ToInt32(monthTextBox.Text),
                    Convert.ToInt32(yearTextBox.Text)),
                    (EnumSuspension)Enum.Parse(typeof(EnumSuspension), suspensionComboBox.Text));
                MountainBikesList.RemoveAt(indexInType);
                MountainBikesList.Insert(indexInType, (MountainBike)newObj);
            }
            bikesList.RemoveAt(indexInBikes);
            bikesList.Insert(indexInBikes, newObj);
            if (indexInBikes == -1 || indexInType == -1 || newObj == null)
                MessageBox.Show("Cannot  Update..!!");
            else
                MessageBox.Show("Updated successfully..!!");
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int indexInBikes = GetIndexOfInList(lastSelectedBike,
                   BikeToObject(bikesList));
            int indexInType = -1;
            if (lastSelectedBike is Roadbike)
            {
                indexInType = GetIndexOfInList(lastSelectedBike, RoadBikeToObject(roadbikesList));
                roadbikesList.RemoveAt(indexInType);
            }
            else //if (lastSelectedBike is MountainBike)
            {
                indexInType = GetIndexOfInList(lastSelectedBike, MountainBikeToObject(MountainBikesList));
                MountainBikesList.RemoveAt(indexInType);
            }
            bikesList.RemoveAt(indexInBikes);
            if (indexInBikes == -1 || indexInType == -1)
                MessageBox.Show("Cannot Delete..!!");
            else
                MessageBox.Show("Deleted successfully..!!");
        }

        private void MountainBikeBox_Enter(object sender, EventArgs e) 
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        FileHandler fileHandler = new FileHandler();

        private void WriteFile_Click(object sender, EventArgs e)
        {
            fileHandler.WriteToFile(bikesList);
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            MountainBikesList.Clear();
            roadbikesList.Clear();
            try
            {
                MountainBikesList.Clear();
                foreach (MountainBike aMountain_Bike in MountainBikesList)
                {
                    this.MountainBikesList.Add(aMountain_Bike);
                }
            }
            catch
            {
                roadbikesList.Clear();
                foreach (Roadbike aRoad_Bike in roadbikesList)
                {
                    this.roadbikesList.Add(aRoad_Bike);
                }

            }
        }

        private void SpeedLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateSeparatorLabel1_Click(object sender, EventArgs e)
        {

        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void SpeedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateSeparatorLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void SuspensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Suspension_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void SeatHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeatHeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchSerialText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerialNumSearchText_Click(object sender, EventArgs e)
        {

        }
    }
}
