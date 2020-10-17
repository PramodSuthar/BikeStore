using MyBikesStore.Bus;
using System;

namespace MyBikesStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            long serNum = 0; string make = "";
            double speed = 0, seatHeight = 0;
            bool correct = false;
            do
            {
                Console.Write("Please enter serial number: ");
                input = Console.ReadLine();
                if (RegExValidator.Is12Digit(input) && RegExValidator.IsEmpty(input))
                    correct = true;
                if (!correct) Console.WriteLine("\t...The input must not be empty and must be 12 digit. Please try again...\n");
            } while (!correct);

            serNum = long.Parse(input);


            correct = false;
            do
            {
                Console.Write(" Please enter the make:   ");
                input = Console.ReadLine();
                correct = RegExValidator.IsAlphabetLetter(input);
                if (!correct) Console.WriteLine("\t...Not valid.. the input must be alphabets only. Try again.\n");
            } while (!correct);

            make = input;

            correct = false;
            do
            {
                Console.Write("Please enter top speed:   ");
                input = Console.ReadLine();
                correct = RegExValidator.IsDigit(input);
                if (!correct) Console.WriteLine("\t...Not valid.. the input must be digit only...\n");
            } while (!correct);

            speed = Convert.ToDouble(input);

            correct = false;
            do
            {
                Console.Write("Please enter seat height(in inches):   ");
                input = Console.ReadLine();
                correct = RegExValidator.IsDigit(input);
                if (!correct) Console.WriteLine("\t...Not valid. The input must be digits only...\n");
            } while (!correct);

            seatHeight = Convert.ToInt32(input);

            Roadbike rBike = new Roadbike(serNum, make, speed, EnumColor.Black,
                new MyBikesStore.Date(1, 1, 1), seatHeight);
            Console.WriteLine("\n\n The Mountain Bike is:\n\t" + rBike);

            Console.ReadKey();

        }
    }
}
