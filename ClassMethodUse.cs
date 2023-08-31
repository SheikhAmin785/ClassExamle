using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class ClassMethodUse
    {
        public string name = "alamin";

        public void Gazi()
        {
            Console.WriteLine("my name is gazi:");
        }
        static void Main()
        {
            ClassMethodUse myName = new ClassMethodUse();
            Console.WriteLine("my name is:"+myName.name);
            myName.Gazi();
            myName.name;

        }
    }
}
