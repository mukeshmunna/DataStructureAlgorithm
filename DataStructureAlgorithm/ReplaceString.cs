﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class ReplaceString
    {
        public void replaceString()
        {
            string line = "Hello <<name>>, We have your fullname as << full name >> in our system. your contact number is 91 - xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine("Enter Your name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Your Full name :");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNumber :");
            string number = Console.ReadLine();
            line = line.Replace("<<name>>", Name);
            line = line.Replace("<< full name >>", fullName);
            line = line.Replace("xxxxxxxxxx", number);
            Console.WriteLine("Final Result :" + line);
        }
    }
}