using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyLibrary
{
    public class DummyClass
    {
        public int Property { get; set; }

        public string Greet(string name)
        {
            return string.Format("{0} {1}!", "Hello", name);
        }

        public string GreetBye(string name)
        {
            return string.Format("{0} {1}!", "Bye", name);
        }
    }
}
