using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Cat : Dog
    {
        public override void Play()
        {
            Console.WriteLine($"Asteroid Destroyer is playing with it's favorite toy, the yarn!");
        }
        public override void Eat()
        {
            Console.WriteLine($"Asteroid Destroyer is eating fish");
        }
    }
}
