
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Labb_4_GIK299_HT23_Vilmu
{
    public class Program

    {
        static void Main(string[] args)

        {
            //Här skapar jag en meny som har en whileloop med bool (true).
            int menuPick = 0;
            string menuSelect;
            while (true)
            {
                Console.WriteLine(" [1] Add person." +
                    "\n [2] Show persons in database." +
                    "\n [3] Exit program.");

                menuSelect = (Console.ReadLine());

                //Här kommer en try-catch sats som ska felhantera programmet. Exempelvis ska man ej kunna skriva bokstäver när man ska välja alternativ.
                try

                {
                    Console.WriteLine("please pick a alternative");

                    if (!int.TryParse(menuSelect, out menuPick))
                    {
                        throw new FormatException("Press number 1 to 3 to advance in the menu.");
                    }

                    if (menuPick is < 1 or > 3)

                    {
                        throw new Exception("Alternative is number 1 to 3");
                    }

                    Console.WriteLine($"You pressed: {menuPick} ");
                }



                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }


                switch (menuSelect)
                {
                    case "1":

                        Console.Clear();
                        addPerson();
                        break;

                }
                void addPerson()
                {
                    int [] extraPerson;
                  

                }
            }




            /*


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

             */
        }
    }
}
