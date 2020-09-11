﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string getName()
        {
            return name;
        }
        public string getGender()
        {
            return gender;
        }
        public string getMaritalStatus()
        {
            return maritalStatus;
        }
    }
}
