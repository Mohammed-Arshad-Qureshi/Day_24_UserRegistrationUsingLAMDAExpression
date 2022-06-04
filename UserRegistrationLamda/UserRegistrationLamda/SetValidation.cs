﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationLamda
{
    class SetValidation
    {
        public bool FirstNameValidation(string fName) 
        {

            // Regex for first name validation
            string pattern = "^[A-Z][a-z]{2,}$"; 
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(fName, pattern))
            {
                Console.WriteLine("\nYour first name {0} is valid",fName);
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of first name");
                return false;
            }
        }
    }
}
