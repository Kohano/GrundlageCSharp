// A1
using System;
namespace ConsoleOutput
{
    internal class Programm
    {
        static void Main()
        {
            Console.WriteLine(" .-.\n(o o)\n| O |\n|   |\n'~~~' ");

        }
    }
}




//A2
     using System; 
    namespace ConsoleOutput
{

    internal class Program
    {

        static void Main()
        {

            string firstname = "Sumiyabazar";
            string Lastname = "Gerelt-Od";
            int age = 20;
            Console.WriteLine(firstname + "\n" + Lastname + "\n" + age);

        }
    }
}

//A3
using System;
 
namespace ConsoleOutput
{

    internal class Program
    {

        static void Main()
        {

            Console.WriteLine("What is your name?");

            string FirstName = Console.ReadLine();

            

            Console.WriteLine("What is your Lastname?");

            string Lastname = Console.ReadLine();

            Console.WriteLine("How old are you ?");

            string age = Console.ReadLine();

            Console.WriteLine($"\n{FirstName} is {age} and his last name is {Lastname} ");


        }
    }
}