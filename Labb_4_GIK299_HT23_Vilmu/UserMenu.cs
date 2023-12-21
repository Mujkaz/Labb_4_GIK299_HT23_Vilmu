using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labb_4_GIK299_HT23_Vilmu
{
    //Klass Usermenu där jag har kodat menyn.
    public class UserMenu
    {   //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender genderType { get; private set; }
        public Hair Hair { get; set; }
        public string Birthday { get; set; }
        public string Eyecolor { get; set; }

        //Lista som sparar data när man lägger till en ny person medhjälp av list döpt listan till "people".
        List<Person> people = new List<Person>();

        

        public void MenuSelect()
        {
            {
                //Här skapar jag en meny som har en whileloop med bool (true) så att man kan återkomma till menyn när man är klar med sitt alternativ.
                int menuPick = 0;
                string menuSelect;
                while (true)
                {
                    Console.WriteLine(" [1] Add person." +
                        "\n [2] Show persons in database." +
                        "\n [3] Exit program.");

                    menuSelect = (Console.ReadLine());

                    Console.WriteLine("");
                    //Här kommer en try-catch sats som ska felhantera menyn. Exempelvis ska man ej kunna skriva bokstäver när man ska välja alternativ. 
                    //Kommer flera try-catch satser längre ner i programmet.
                    try
                    {
                        

                        if (!int.TryParse(menuSelect, out menuPick))
                        {
                            throw new FormatException("Press number 1 to 3 to advance in the menu.");
                        }
                        if (menuPick is < 1 or > 3)
                        {
                            throw new Exception("Alternative is number 1 to 3");
                        } 
                    }
                    catch (ArgumentOutOfRangeException wrongMenu)
                    {
                        Console.WriteLine($"Error: {wrongMenu.Message}");
                    }
                    catch (ArgumentException wrongMenu)
                    {
                        Console.WriteLine($"Error: {wrongMenu.Message}");
                    }
                    catch (FormatException wrongMenu)
                    {
                        Console.WriteLine($"Error: {wrongMenu.Message}");
                    }
                    catch (Exception wrongMenu)
                    {
                        Console.WriteLine($"An unexpected error occurred: {wrongMenu.Message}");
                    }

                    {
                        
                        Console.WriteLine("");

                       
                        //I menyn så har jag lagt in 3 case. Case 1 som lägger till personen, Case 2 som visar alla personer och Case 3 som stänger ner programmet.
                        switch (menuSelect)
                        {
                            case "1":

                                Console.WriteLine("please pick a alternative");

                                Console.Clear();
                                Console.WriteLine("What is the persons first name?");
                                FirstName = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("What is the persons last name?");
                                LastName = Console.ReadLine();

                                //Lagt in en While-loop med bool true för att om man skulle skriva fel när man väljer kön så kommer alternativen tillbaka och användaren får en ny chans att skriva in värde.
                                //När man sedan valt ett värde mellan 1 - 4 så ändras boolen och släpper igenom loopen så man kan ta sig vidare i programmet.
                                bool genderSelectLoop = true;
                                while (genderSelectLoop)

                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Pick one of the following gender " + "1. "  + Gender.Man + " 2. " + Gender.Woman + " 3. " + Gender.Nonbinary + " 4. " + Gender.Other);

                                    try

                                    {
                                        Console.WriteLine("");
                                        int genderPick = 0;
                                        Console.WriteLine("Please pick an alternative");
                                        string genderSelect = Console.ReadLine();

                                        if (!int.TryParse(genderSelect, out genderPick) || genderPick < 1 || genderPick > 4)
                                        {

                                            throw new FormatException("You put the wrong input on selecting gender, please select the right one before continue. HINT button number 1-4.");
                                        }
                                        //If-else som bestämmer att om man skulle skriva fel värde så kommer man tillbaka till switch satsen där man får välja köns alternativ.
                                        else
                                        {
                                            switch (genderPick)
                                            {
                                                case 1:
                                                    genderType = Gender.Man;
                                                    break;
                                                case 2:
                                                    genderType = Gender.Woman;
                                                    break;
                                                case 3:
                                                    genderType = Gender.Nonbinary;
                                                    break;
                                                case 4:
                                                    genderType = Gender.Other;
                                                    break;
                                                default:
                                                    break;
                                            }
                                            //Här ändras boolen till falsk och programmet fortsätter.
                                            genderSelectLoop = false;

                                            break;
                                        }
                                    }
                                    catch (ArgumentOutOfRangeException wrongGender)
                                    {
                                        Console.WriteLine($"Error: {wrongGender.Message}");
                                    }
                                    catch (ArgumentException wrongGender)
                                    {
                                        Console.WriteLine($"Error: {wrongGender.Message}");
                                    }
                                    catch (FormatException wrongGender)
                                    {
                                        Console.WriteLine($"Error: {wrongGender.Message}");
                                    }
                                    catch (Exception wrongGender)
                                    {
                                        Console.WriteLine($"An unexpected error occurred: {wrongGender.Message}");
                                    }
                                }
                                //Lägger också en while-loop som loopar om denna del om man skulle skriva ålder fel. 
                                //exempel om man skulle skriva bokstav på ålder och istället för att programmet fortsätter eller kraschar så får man börja om och göra rätt!
                                bool ageSelectLoop = true;
                                int ageSelect = 0;
                                while (ageSelectLoop)
                                {
                                    try
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("What is the age?");
                                        ageSelect = int.Parse(Console.ReadLine());
                                        ageSelectLoop = false;

                                    }
                                    catch (FormatException wrongAge)
                                    {
                                        Console.WriteLine($"Error: {wrongAge.Message}");
                                        ageSelectLoop = true;
                                    }
                                }
                                //Datum har jag kodat som en sträng för att enklare kunna skriva in värdet.
                                Console.WriteLine("");
                                Console.WriteLine("Birthday please write in (YYYY/MM/DD).");
                                Birthday = Console.ReadLine();

                                Console.WriteLine("");
                                Console.WriteLine("Eyecolor?");
                                Eyecolor = Console.ReadLine();

                                Console.WriteLine("");
                                Console.WriteLine("Haircolor?");
                                string hairColor = Console.ReadLine();

                                Console.WriteLine("");
                                Console.WriteLine("Hairlenght?");
                                string hairLenght = Console.ReadLine();
                                Hair = new Hair() { hairColor = hairColor, hairLength = hairLenght };

                                //När man nu skrivit in alla värden så ska det alla variablar sparas in i en "Person"
                                Person person = new Person(FirstName, LastName, ageSelect, genderType, Hair, Birthday, Eyecolor);
                                //Här läggs "Person" in i listan som skapades i början av programmet.
                                people.Add(person);

                                Console.Clear();

                                break;

                            case "2":
                                //Här är en foreach loop som ska visa personer man har lagt in. Tar in då värden från "Person" och visar listan som data är sparad i.

                                Console.Clear();
                                {
                                    foreach (Person showPerson in people)
                                    {
                                    Console.WriteLine(showPerson.ToString()+"");
                                    }
                        
                                }

                                break;

                            case "3":
                                {

                                }

                                return;

                            default:
                                break;

                        }

                    }
                }
            }
        }
    }
}

