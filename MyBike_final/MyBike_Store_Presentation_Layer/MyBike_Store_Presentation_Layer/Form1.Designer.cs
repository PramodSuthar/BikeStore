namespace MyBike_Store_Presentation_Layer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bikeTypeDropDown = new System.Windows.Forms.ComboBox();
            this.suspensionComboBox = new System.Windows.Forms.ComboBox();
            this.suspension = new System.Windows.Forms.Label();
            this.seatHeightTextBox = new System.Windows.Forms.TextBox();
            this.seatHeightLabel = new System.Windows.Forms.Label();
            this.srNumLabel = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeInputTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dateSeparatorLabel1 = new System.Windows.Forms.Label();
            this.dateSeparatorLabel2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.writeFile = new System.Windows.Forms.Button();
            this.readFile = new System.Windows.Forms.Button();
            this.displayMountainBikes = new System.Windows.Forms.Button();
            this.DisplayRoadBike = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.ListBox();
            this.reset = new System.Windows.Forms.Button();
            this.srNumResultLabel = new System.Windows.Forms.Label();
            this.makeResultsLabel = new System.Windows.Forms.Label();
            this.speedResultsLabel = new System.Windows.Forms.Label();
            this.colorResultsLabel = new System.Windows.Forms.Label();
            this.suspensionResultsLabel = new System.Windows.Forms.Label();
            this.seatHeightResultsLabel = new System.Windows.Forms.Label();
            this.dateResultsLabel = new System.Windows.Forms.Label();
            this.dispAllBikeButton = new System.Windows.Forms.Button();
            this.serialNumSearchText = new System.Windows.Forms.Label();
            this.searchSerialText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bikeTypeDropDown
            // 
            this.bikeTypeDropDown.FormattingEnabled = true;
            this.bikeTypeDropDown.Location = new System.Drawing.Point(85, 13);
            this.bikeTypeDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.bikeTypeDropDown.Name = "bikeTypeDropDown";
            this.bikeTypeDropDown.Size = new System.Drawing.Size(125, 21);
            this.bikeTypeDropDown.TabIndex = 1;
            this.bikeTypeDropDown.SelectedIndexChanged += new System.EventHandler(this.bikeTypeDropDown_SelectedIndexChanged);
            // 
            // suspensionComboBox
            // 
            this.suspensionComboBox.FormattingEnabled = true;
            this.suspensionComboBox.Location = new System.Drawing.Point(106, 163);
            this.suspensionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.suspensionComboBox.Name = "suspensionComboBox";
            this.suspensionComboBox.Size = new System.Drawing.Size(92, 21);
            this.suspensionComboBox.TabIndex = 1;
            this.suspensionComboBox.SelectedIndexChanged += new System.EventHandler(this.SuspensionComboBox_SelectedIndexChanged);
            // 
            // suspension
            // 
            this.suspension.AutoSize = true;
            this.suspension.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspension.Location = new System.Drawing.Point(17, 166);
            this.suspension.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.suspension.Name = "suspension";
            this.suspension.Size = new System.Drawing.Size(62, 13);
            this.suspension.TabIndex = 0;
            this.suspension.Text = "Suspension";
            this.suspension.Click += new System.EventHandler(this.Suspension_Click);
            // 
            // seatHeightTextBox
            // 
            this.seatHeightTextBox.Location = new System.Drawing.Point(318, 161);
            this.seatHeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.seatHeightTextBox.Name = "seatHeightTextBox";
            this.seatHeightTextBox.Size = new System.Drawing.Size(92, 20);
            this.seatHeightTextBox.TabIndex = 1;
            this.seatHeightTextBox.TextChanged += new System.EventHandler(this.SeatHeightTextBox_TextChanged);
            // 
            // seatHeightLabel
            // 
            this.seatHeightLabel.AutoSize = true;
            this.seatHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatHeightLabel.Location = new System.Drawing.Point(242, 166);
            this.seatHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seatHeightLabel.Name = "seatHeightLabel";
            this.seatHeightLabel.Size = new System.Drawing.Size(63, 13);
            this.seatHeightLabel.TabIndex = 0;
            this.seatHeightLabel.Text = "Seat Height";
            this.seatHeightLabel.Click += new System.EventHandler(this.SeatHeightLabel_Click);
            // 
            // srNumLabel
            // 
            this.srNumLabel.AutoSize = true;
            this.srNumLabel.Location = new System.Drawing.Point(11, 61);
            this.srNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.srNumLabel.Name = "srNumLabel";
            this.srNumLabel.Size = new System.Drawing.Size(73, 13);
            this.srNumLabel.TabIndex = 4;
            this.srNumLabel.Text = "Serial Number";
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(104, 58);
            this.serialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(102, 20);
            this.serialTextBox.TabIndex = 5;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(17, 102);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 6;
            this.makeLabel.Text = "Make";
            // 
            // makeInputTextBox
            // 
            this.makeInputTextBox.Location = new System.Drawing.Point(104, 99);
            this.makeInputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.makeInputTextBox.Name = "makeInputTextBox";
            this.makeInputTextBox.Size = new System.Drawing.Size(102, 20);
            this.makeInputTextBox.TabIndex = 7;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(264, 21);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 8;
            this.speedLabel.Text = "Speed";
            this.speedLabel.Click += new System.EventHandler(this.SpeedLabel_Click);
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(351, 14);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(102, 20);
            this.speedTextBox.TabIndex = 9;
            this.speedTextBox.TextChanged += new System.EventHandler(this.SpeedTextBox_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(264, 56);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 10;
            this.colorLabel.Text = "Color";
            this.colorLabel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(332, 50);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(125, 21);
            this.colorComboBox.TabIndex = 11;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(264, 93);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(333, 89);
            this.dayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(26, 20);
            this.dayTextBox.TabIndex = 13;
            this.dayTextBox.TextChanged += new System.EventHandler(this.DayTextBox_TextChanged);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(373, 89);
            this.monthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(26, 20);
            this.monthTextBox.TabIndex = 14;
            this.monthTextBox.TextChanged += new System.EventHandler(this.MonthTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(414, 89);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(39, 20);
            this.yearTextBox.TabIndex = 15;
            this.yearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // dateSeparatorLabel1
            // 
            this.dateSeparatorLabel1.AutoSize = true;
            this.dateSeparatorLabel1.Location = new System.Drawing.Point(361, 92);
            this.dateSeparatorLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateSeparatorLabel1.Name = "dateSeparatorLabel1";
            this.dateSeparatorLabel1.Size = new System.Drawing.Size(10, 13);
            this.dateSeparatorLabel1.TabIndex = 16;
            this.dateSeparatorLabel1.Text = "-";
            this.dateSeparatorLabel1.Click += new System.EventHandler(this.DateSeparatorLabel1_Click);
            // 
            // dateSeparatorLabel2
            // 
            this.dateSeparatorLabel2.AutoSize = true;
            this.dateSeparatorLabel2.Location = new System.Drawing.Point(401, 91);
            this.dateSeparatorLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateSeparatorLabel2.Name = "dateSeparatorLabel2";
            this.dateSeparatorLabel2.Size = new System.Drawing.Size(10, 13);
            this.dateSeparatorLabel2.TabIndex = 17;
            this.dateSeparatorLabel2.Text = "-";
            this.dateSeparatorLabel2.Click += new System.EventHandler(this.DateSeparatorLabel2_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(509, 21);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 19);
            this.add.TabIndex = 18;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(509, 48);
            this.remove.Margin = new System.Windows.Forms.Padding(2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(72, 20);
            this.remove.TabIndex = 19;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(509, 75);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(56, 20);
            this.update.TabIndex = 20;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // writeFile
            // 
            this.writeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.writeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeFile.Location = new System.Drawing.Point(42, 238);
            this.writeFile.Margin = new System.Windows.Forms.Padding(2);
            this.writeFile.Name = "writeFile";
            this.writeFile.Size = new System.Drawing.Size(81, 20);
            this.writeFile.TabIndex = 21;
            this.writeFile.Text = "Write to File";
            this.writeFile.UseVisualStyleBackColor = false;
            this.writeFile.Click += new System.EventHandler(this.WriteFile_Click);
            // 
            // readFile
            // 
            this.readFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.readFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFile.Location = new System.Drawing.Point(136, 237);
            this.readFile.Margin = new System.Windows.Forms.Padding(2);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(95, 21);
            this.readFile.TabIndex = 22;
            this.readFile.Text = "Read from File";
            this.readFile.UseVisualStyleBackColor = false;
            this.readFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // displayMountainBikes
            // 
            this.displayMountainBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.displayMountainBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMountainBikes.Location = new System.Drawing.Point(42, 267);
            this.displayMountainBikes.Margin = new System.Windows.Forms.Padding(2);
            this.displayMountainBikes.Name = "displayMountainBikes";
            this.displayMountainBikes.Size = new System.Drawing.Size(168, 26);
            this.displayMountainBikes.TabIndex = 23;
            this.displayMountainBikes.Text = "Display All Mountain Bikes";
            this.displayMountainBikes.UseVisualStyleBackColor = false;
            this.displayMountainBikes.Click += new System.EventHandler(this.displayMountainBikes_Click);
            // 
            // DisplayRoadBike
            // 
            this.DisplayRoadBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DisplayRoadBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayRoadBike.Location = new System.Drawing.Point(42, 297);
            this.DisplayRoadBike.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayRoadBike.Name = "DisplayRoadBike";
            this.DisplayRoadBike.Size = new System.Drawing.Size(168, 24);
            this.DisplayRoadBike.TabIndex = 24;
            this.DisplayRoadBike.Text = "Display All Road Bike";
            this.DisplayRoadBike.UseVisualStyleBackColor = false;
            this.DisplayRoadBike.Click += new System.EventHandler(this.DisplayRoadBike_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(542, 297);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(105, 57);
            this.exit.TabIndex = 25;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.FormattingEnabled = true;
            this.resultsTextBox.Location = new System.Drawing.Point(20, 419);
            this.resultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(817, 147);
            this.resultsTextBox.TabIndex = 26;
            this.resultsTextBox.SelectedIndexChanged += new System.EventHandler(this.resultsTextBox_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(676, 297);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(103, 57);
            this.reset.TabIndex = 27;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // srNumResultLabel
            // 
            this.srNumResultLabel.AutoSize = true;
            this.srNumResultLabel.Location = new System.Drawing.Point(28, 392);
            this.srNumResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.srNumResultLabel.Name = "srNumResultLabel";
            this.srNumResultLabel.Size = new System.Drawing.Size(73, 13);
            this.srNumResultLabel.TabIndex = 29;
            this.srNumResultLabel.Text = "Serial Number";
            // 
            // makeResultsLabel
            // 
            this.makeResultsLabel.AutoSize = true;
            this.makeResultsLabel.Location = new System.Drawing.Point(135, 392);
            this.makeResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeResultsLabel.Name = "makeResultsLabel";
            this.makeResultsLabel.Size = new System.Drawing.Size(34, 13);
            this.makeResultsLabel.TabIndex = 30;
            this.makeResultsLabel.Text = "Make";
            // 
            // speedResultsLabel
            // 
            this.speedResultsLabel.AutoSize = true;
            this.speedResultsLabel.Location = new System.Drawing.Point(218, 392);
            this.speedResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedResultsLabel.Name = "speedResultsLabel";
            this.speedResultsLabel.Size = new System.Drawing.Size(38, 13);
            this.speedResultsLabel.TabIndex = 31;
            this.speedResultsLabel.Text = "Speed";
            // 
            // colorResultsLabel
            // 
            this.colorResultsLabel.AutoSize = true;
            this.colorResultsLabel.Location = new System.Drawing.Point(306, 392);
            this.colorResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorResultsLabel.Name = "colorResultsLabel";
            this.colorResultsLabel.Size = new System.Drawing.Size(31, 13);
            this.colorResultsLabel.TabIndex = 32;
            this.colorResultsLabel.Text = "Color";
            // 
            // suspensionResultsLabel
            // 
            this.suspensionResultsLabel.AutoSize = true;
            this.suspensionResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspensionResultsLabel.Location = new System.Drawing.Point(619, 392);
            this.suspensionResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.suspensionResultsLabel.Name = "suspensionResultsLabel";
            this.suspensionResultsLabel.Size = new System.Drawing.Size(62, 13);
            this.suspensionResultsLabel.TabIndex = 2;
            this.suspensionResultsLabel.Text = "Suspension";
            // 
            // seatHeightResultsLabel
            // 
            this.seatHeightResultsLabel.AutoSize = true;
            this.seatHeightResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatHeightResultsLabel.Location = new System.Drawing.Point(490, 392);
            this.seatHeightResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seatHeightResultsLabel.Name = "seatHeightResultsLabel";
            this.seatHeightResultsLabel.Size = new System.Drawing.Size(63, 13);
            this.seatHeightResultsLabel.TabIndex = 2;
            this.seatHeightResultsLabel.Text = "Seat Height";
            // 
            // dateResultsLabel
            // 
            this.dateResultsLabel.AutoSize = true;
            this.dateResultsLabel.Location = new System.Drawing.Point(397, 392);
            this.dateResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateResultsLabel.Name = "dateResultsLabel";
            this.dateResultsLabel.Size = new System.Drawing.Size(30, 13);
            this.dateResultsLabel.TabIndex = 33;
            this.dateResultsLabel.Text = "Date";
            // 
            // dispAllBikeButton
            // 
            this.dispAllBikeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dispAllBikeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispAllBikeButton.Location = new System.Drawing.Point(223, 282);
            this.dispAllBikeButton.Margin = new System.Windows.Forms.Padding(2);
            this.dispAllBikeButton.Name = "dispAllBikeButton";
            this.dispAllBikeButton.Size = new System.Drawing.Size(156, 26);
            this.dispAllBikeButton.TabIndex = 34;
            this.dispAllBikeButton.Text = "Display All Bike";
            this.dispAllBikeButton.UseVisualStyleBackColor = false;
            this.dispAllBikeButton.Click += new System.EventHandler(this.dispAllBikeButton_Click);
            // 
            // serialNumSearchText
            // 
            this.serialNumSearchText.AutoSize = true;
            this.serialNumSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumSearchText.Location = new System.Drawing.Point(545, 187);
            this.serialNumSearchText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serialNumSearchText.Name = "serialNumSearchText";
            this.serialNumSearchText.Size = new System.Drawing.Size(73, 13);
            this.serialNumSearchText.TabIndex = 0;
            this.serialNumSearchText.Text = "Serial Number";
            this.serialNumSearchText.Click += new System.EventHandler(this.SerialNumSearchText_Click);
            // 
            // searchSerialText
            // 
            this.searchSerialText.Location = new System.Drawing.Point(651, 182);
            this.searchSerialText.Margin = new System.Windows.Forms.Padding(2);
            this.searchSerialText.Name = "searchSerialText";
            this.searchSerialText.Size = new System.Drawing.Size(128, 20);
            this.searchSerialText.TabIndex = 1;
            this.searchSerialText.TextChanged += new System.EventHandler(this.SearchSerialText_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(620, 227);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 31);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Road Bike";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mountain Bike";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(910, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.suspensionComboBox);
            this.Controls.Add(this.suspension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seatHeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seatHeightLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dispAllBikeButton);
            this.Controls.Add(this.searchSerialText);
            this.Controls.Add(this.dateResultsLabel);
            this.Controls.Add(this.serialNumSearchText);
            this.Controls.Add(this.seatHeightResultsLabel);
            this.Controls.Add(this.suspensionResultsLabel);
            this.Controls.Add(this.colorResultsLabel);
            this.Controls.Add(this.speedResultsLabel);
            this.Controls.Add(this.makeResultsLabel);
            this.Controls.Add(this.srNumResultLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.DisplayRoadBike);
            this.Controls.Add(this.displayMountainBikes);
            this.Controls.Add(this.readFile);
            this.Controls.Add(this.writeFile);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dateSeparatorLabel2);
            this.Controls.Add(this.dateSeparatorLabel1);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.makeInputTextBox);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.srNumLabel);
            this.Controls.Add(this.bikeTypeDropDown);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bikeTypeDropDown;
        private System.Windows.Forms.ComboBox suspensionComboBox;
        private System.Windows.Forms.Label suspension;
        private System.Windows.Forms.TextBox seatHeightTextBox;
        private System.Windows.Forms.Label seatHeightLabel;
        private System.Windows.Forms.Label srNumLabel;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.TextBox makeInputTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dateSeparatorLabel1;
        private System.Windows.Forms.Label dateSeparatorLabel2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button writeFile;
        private System.Windows.Forms.Button readFile;
        private System.Windows.Forms.Button displayMountainBikes;
        private System.Windows.Forms.Button DisplayRoadBike;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox resultsTextBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label srNumResultLabel;
        private System.Windows.Forms.Label makeResultsLabel;
        private System.Windows.Forms.Label speedResultsLabel;
        private System.Windows.Forms.Label colorResultsLabel;
        private System.Windows.Forms.Label suspensionResultsLabel;
        private System.Windows.Forms.Label seatHeightResultsLabel;
        private System.Windows.Forms.Label dateResultsLabel;
        private System.Windows.Forms.Button dispAllBikeButton;
        private System.Windows.Forms.Label serialNumSearchText;
        private System.Windows.Forms.TextBox searchSerialText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

