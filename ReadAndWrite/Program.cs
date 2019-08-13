using System;

namespace ReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string age;
            //double age;

            Console.WriteLine("Hvad er dit fornavn?");

            firstname = Console.ReadLine();

            Console.WriteLine("Hvad er dit efternavn?");

            lastname = Console.ReadLine();

            Console.WriteLine("Hvad er din alder?");

            age = Console.ReadLine();

        







            Console.WriteLine("Du hedder {0} {1} og er {2} år gammel.", firstname, lastname, age);
        }
    }
}
