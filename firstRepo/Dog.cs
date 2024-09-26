using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Dog
    {
        public virtual void Play()
        {
            Console.WriteLine($"Colby is playing with it's favorite toy, the ball!");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"Colby is eating dog food");
        }
    }
}
