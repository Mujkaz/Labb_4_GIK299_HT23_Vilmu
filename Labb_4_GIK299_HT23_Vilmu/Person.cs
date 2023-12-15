
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_GIK299_HT23_Vilmu
{
    public class Person
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender gender { get; private set; }
        public Hair Hair { get; set; }
        public DateTime Birthday { get; set; }
        public string Eyecolor { get; set; }

        //Construct

        public Person(string firstName, string lastName, int age, Gender gendertype, Hair hairtype, DateTime birthday, string eyecolor)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            gender = gendertype;
            Hair = hairtype;
            Birthday = birthday;
            Eyecolor = eyecolor;
        }


        //Vad som skrivs till konsolen. 
        public override string ToString()
        {
            return $"First name: {FirstName}" +
                $"\nLast name: {LastName}" +
                $"\nAge: {Age}" +
                $"\nGender: {gender}" +
                $"\nHair: {Hair.hairColor} {Hair.hairLength}" +
                $"\nBirthday: {Birthday:yyyy/MM/dd}" +
                $"\nEyecolor: {Eyecolor}";
        }
    }
}

