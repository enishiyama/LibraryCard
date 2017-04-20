using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    class WelcomePage
    {
        public static void Intro(string[] args)
            
        {
            Console.WriteLine("Hello! Please enter the name of a file.");
            Console.ReadLine();
            string filename = Console.ReadLine();
            Console.WriteLine("Thank you! Your file" + filename + "will be used so you can save your information. Now what can I do for you? To list all books, please press '1'. To add a book, please press '2'. To save and exit, please press '3'");

            //public static void Question05()
            //{
            //    Console.WriteLine("Enter a number");
            //    string input = Console.ReadLine();
            //    int num1 = Convert.ToInt32(input);

            //    //Option 1:
            //    string output1;
            //    if (num1 >= 0)
            //    {
            //        output1 = "Number is Positive";
            //    }
            //    else //Doesn't need the "if" - there are only two possible outcomes
            //    {
            //        output1 = "Number is Negative";
            //    }
            //    Console.WriteLine(output);

            string input = Console.ReadLine();
            int num1 = Convert.ToInt32(input);

            string output;
            if (num1 = 1)
                
            {
                output = "you have selected list all books";
            }
            else if (num1 = 2)
            {
                output = "you have selected add a book " ;
            }
            else if (num1 = 3)
            {
                output = "your data has been saved! comeback soon...I get lonely.";
            }
            else
            {
                Console.WriteLine(" Im sorry I cannot process your request. Please input either 1, 2, or 3.");
            }
        }
    }
}
