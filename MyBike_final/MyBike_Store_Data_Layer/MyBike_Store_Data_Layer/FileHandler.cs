using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MyBikesStore;

namespace MyBike_Store_Data_Layer
{
    public class FileHandler
    {
        public string binFilePath = @"..//..//my_bikes.ser";

        public void WriteToFile(List<Bike> list)
        {
            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            foreach (Bike b in list)
                bf.Serialize(fs, b); //Serialize: meand Write to the file ===== Encrypt it

            fs.Close();
        }
        public List<Bike> ReadFromFile()
        {
            List<Bike> list = new List<Bike>();

            FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            Bike bike = (Bike)bf.Deserialize(fs);
            while (bike != null)
            {
                list.Add(bike);
                try
                {
                    bike = (Bike)bf.Deserialize(fs);
                }
                catch (Exception e) { bike = null; }
            }

            fs.Close();

            return list;
        }
    }
}
