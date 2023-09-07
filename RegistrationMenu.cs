
using System.Numerics;

namespace OOPCaseOpgave
{
    internal class RegistrationMenu
    {
        public RegistrationMenu()
        {
            while (true) Register();
        }


        private void Register()
        {
            Console.Clear();
            Gui.Print(10, 8, "*** Registration Menu ***");

            Pasient pasientRegistration = new Pasient();
            Gui.Print(10, 9, "Patient fornavn:");
            pasientRegistration.FirstName = Console.ReadLine();
            Gui.Print(10, 10, "Patient efternavn:");
            pasientRegistration.LastName = Console.ReadLine();
            Gui.Print(10, 11, "Patient tlf.nr.:");
            pasientRegistration.PhoneNumber = Console.ReadLine();
            Gui.Print(10, 11, "Tildelt læge");

            Console.Clear();

        }

        // not working
        private static void Write(RegistrationMenu , Pasient pasientRegistration)
        {
            //Skrive fil og derud appende til samme fil.
            StreamWriter fil = File.AppendText(@"DataBase.txt");
            fil.WriteLine("{0},{1},{2},{3}}", pasientRegistration.FirstName, pasientRegistration.LastName, pasientRegistration.PhoneNumber);
            fil.Close();
        }

    }
}
