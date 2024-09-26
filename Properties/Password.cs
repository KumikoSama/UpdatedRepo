using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Password
    {
        private string pass;

        public Password(string _pass)
        {
            Pass = _pass;
        }

        public string Pass
        {
            get { return pass; }
            set
            {
                if (value == "password123" || value == "notapassword" || value == "thisisapassword")
                {
                    pass = value;
                    Console.WriteLine("Welcome back to your page!");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
        }
    }
}
