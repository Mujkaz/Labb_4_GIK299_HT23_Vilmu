using System.Runtime.InteropServices;

namespace Labb_4_GIK299_HT23_Vilmu
{
    public class Program
    {
        static void Main(string[] args)

        {

                menuSelect = (Console.ReadLine());


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

            //Här presenteras allting till konsolen.
            Person person = new Person(FirstName, LastName, Age, gender, hair, birthDay, Eyecolor);

            Console.WriteLine(person.ToString());

             */
        }
    }
}
