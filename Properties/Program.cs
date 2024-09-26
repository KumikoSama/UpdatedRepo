using System;
namespace Properties
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pass;

            Console.WriteLine("What's the password?");
            pass = Console.ReadLine();
            Password password = new Password(pass);

        }
    }
}