
using System;
using System.Collections.Generic;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        public static string NameFromEmail(string input)
        {
            string[] partsSeparatedByAt = input.Split('@');
            string[] nameParts = partsSeparatedByAt[0].Split('.');
            string name = "";
            for (int i = nameParts.Length; i > 0; i--)
            {
                name += (char.ToUpper(nameParts[i - 1][0]) + nameParts[i - 1].Substring(1) + " ");
            }
            return name;
        }
    }
}