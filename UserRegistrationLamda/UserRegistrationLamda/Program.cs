﻿using System;

namespace UserRegistrationLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            SetValidation validation = new SetValidation(); 
            Console.WriteLine("\nWelcome to C# User's Information validation using Regular Expression");
            //User First name validation            
            Firstname:
            Console.WriteLine("\nNote : Your first name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.Write("\n\nEnter your first name :   ");
            string fName = Console.ReadLine(); 
            bool checkFirstName = validation.FirstNameValidation(fName);  
            if (!checkFirstName)//If not valid then ask user to enter first name again
                goto Firstname;
        }
    }
}
