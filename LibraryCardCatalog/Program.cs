using System;

namespace LibraryCardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter the name of a file.");
            Console.ReadLine();
            string filename = Console.ReadLine();
            Console.WriteLine("Thank you! Your file" + filename + "will be used so you can save your information. Now what can I do for you? To list all books, please press '0'. To add a book, please press '1'. To save and exit, please press '2'");
            string input = Console.ReadLine();
            int choice = int.Parse(input);
            UserChoice c = (UserChoice)choice;

            switch (c)
            {
                case UserChoice.List:
                    Console.WriteLine(c.ToString());
                    break;
                case UserChoice.Add:
                    Console.WriteLine(c.ToString());
                    break;
                case UserChoice.Save:
                    Console.WriteLine(c.ToString());
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            //string output;
            //if (num1 = 1)
            //{
            //    output = "you have selected list all books";
            //}
            //else if (num1 = 2)
            //{
            //    output = "you have selected add a book " ;
            //}
            //else if (num1 = 3)
            //{
            //    output = "your data has been saved! comeback soon...I get lonely.";
            //}
            //else
            //{
            //    Console.WriteLine(" Im sorry I cannot process your request. Please input either 1, 2, or 3.");
            //}
        }

        private enum UserChoice
        {
            List,
            Add,
            Save
        }

    }
}
