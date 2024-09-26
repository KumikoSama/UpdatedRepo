using System;
namespace FamilyActivity
{
#pragma warning disable
    class FamilyData
    {
        public static void Main(string[] args)
        {
            bool choice;
            string n, g, o, another, family;
            int a, count;
            List<Parents> parents = new List<Parents>();
            List<Children> children = new List<Children>();

            do
            {
                Console.WriteLine("Hello, user! Please enter your family name(surname)");
                family = Console.ReadLine().ToUpper();

                Console.WriteLine("What's your name? ");
                n = Console.ReadLine();
                Console.WriteLine("Age? ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gender? ");
                g = Console.ReadLine();

                You you = new You(n, a, g);

                Console.WriteLine("How many siblings do you have?");
                count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Sibling {i + 1}'s name: ");
                    n = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gender: ");
                    g = Console.ReadLine();
                    Console.WriteLine();

                    Children sibling = new Children(n, a, g);
                    children.Add(sibling);
                }

                Console.WriteLine("What's your mother's name? ");
                n = Console.ReadLine();
                Console.WriteLine("Age? ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Her occupation?");
                o = Console.ReadLine();
                Parents mother = new Parents(n, a, "Mother", o);
                parents.Add(mother);

                Console.WriteLine();

                Console.WriteLine("What's your father's name? ");
                n = Console.ReadLine();
                Console.WriteLine("Age? ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("His occupation?");
                o = Console.ReadLine();
                Parents father = new Parents(n, a, "Father", o);
                parents.Add(father);

                Console.WriteLine($"\n{family} FAMILY's DATA\n");

                Console.WriteLine($"User's name: {you.name}\nUser's age: {you.age}\nUser's gender: {you.gender}\n");
                Console.WriteLine("---------------");

                foreach (var item in parents)
                {
                    Console.WriteLine($"Parent's name: {item.name}\nParent's role: {item.role}\nParent's age: {item.age}\nParent's occupation: {item.occupation}\n");
                }

                Console.WriteLine("---------------");

                foreach (var item in children)
                {
                    Console.WriteLine($"Name: {item.name}\nAge: {item.age}\nGender: {item.gender}\n");
                }

                Console.WriteLine("---------------\n");

                Console.WriteLine("\nWould you like to add another set of data? Y/N");
                another = Console.ReadLine();

                if (another == "Y")
                {
                    choice = true;
                }
                else
                {
                    choice = false;
                }

            } while (choice != false);

            Console.WriteLine("\nThank you for participating!");
        }
    }
}