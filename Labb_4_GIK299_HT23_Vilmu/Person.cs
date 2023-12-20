
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
        public string Birthday { get; set; }
        public string Eyecolor { get; set; }

        //Construct

        public Person(string firstName, string lastName, int ageSelect, Gender gendertype, Hair hairtype, string birthday, string eyecolor)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = ageSelect;
            gender = gendertype;
            Hair = hairtype;
            Birthday = birthday;
            Eyecolor = eyecolor;
        }


        //Vad som skrivs ut i konsolen när man trycker på alternativ 2 i menyn.
        public override string ToString()
        {
            return $"First name: {FirstName}" +
                $"\nLast name: {LastName}" +
                $"\nAge: {Age}" +
                $"\nGender: {gender}" +
                $"\nHair: {Hair.hairColor} {Hair.hairLength}" +
                $"\nBirthday: {Birthday:yyyy/MM/dd}" +
                $"\nEyecolor: {Eyecolor}\n";
        }
    }
}

