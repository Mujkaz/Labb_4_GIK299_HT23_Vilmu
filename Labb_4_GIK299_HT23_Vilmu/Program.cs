
namespace Labb_4_GIK299_HT23_Vilmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här hårdkodar jag data och kopplat in struct och enumen från de andra klasserna.
            string FirstName = "Pablo";
            string LastName = "Escobar";
            int Age = 44;
            string Eyecolor = "Brown";
            Gender gender = Gender.Man;
            Hair hair = new Hair { hairColor = "Brown", hairLength = "6 cm long" };
            DateTime birthDay = new DateTime(1949, 12, 1);


            //Här presenteras allting till konsolen.
            Person person = new Person(FirstName, LastName, Age, gender, hair, birthDay, Eyecolor);

            Console.WriteLine(person.ToString());
        }
    }
}
