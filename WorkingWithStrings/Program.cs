using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String iterations, using the escape character

            //string myString = "My \"so-called\" life";

            //new line 
            //string myString = "What if I need a \nnew line?";

            //place a backslash in a string
            //string myString = "Go to your c:\\ drive";

            //the @ sign tells the string to read literal
            //string myString = @"Go to your c:\ drive";

            //Use curly braces and indexes to iterate multiple items in strings
            //string myString = String.Format("{1} = {0}", "First", "Second");

            //The {0:C} is a currency call-out for local users
            //string myString = string.Format("{0:C}", 1600.00);

            //The following displays the string as a number with commas and a decimal place
            //string myString = string.Format("{0:N}", 1321436186313848);

            // The following displays the string as a percentage
            //string myString = string.Format("Percentage {0} {0:P}", .235656);

            //Format a number like a phone number, extra digits are placed in the area code space
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 2165551212);

            //string myString = " That Summer we took threes across the board   ";

            //Takes a substring of the string starting at position 6 and going 14 characters
            //myString = myString.Substring(6, 14);

            //Taking the string and making it all upper case
            //myString = myString.ToUpper();

            //Taking the string and replacing a space with a --
            //myString = myString.Replace(" ", "--");

            //Same function, just replacing a letter
            //myString = myString.Replace("T", "--");

            //Removing a substring in a string
            //myString = myString.Remove(6, 14);

            //myString = String.Format("Length before: {0} -- Length after: {1}",
            //    myString.Length, myString.Trim().Length);

            //Using a loop to create a long string, but this takes a lot of resources
            /*string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //Use StringBuilder instead to append a string rather than having to replace it with new looped strings
            /*StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */

            string myString = "Hello my name is ";
            
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
