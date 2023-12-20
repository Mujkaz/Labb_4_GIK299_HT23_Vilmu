using System.Runtime.InteropServices;

namespace Labb_4_GIK299_HT23_Vilmu
{
    public class Program
    {
   

        static void Main (string[] args)
        {
            //Programmet som körs.
            UserMenu userMenu = new UserMenu();
            userMenu.MenuSelect();
        }
    }
}

