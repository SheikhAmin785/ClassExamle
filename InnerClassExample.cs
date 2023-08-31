using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
   public class OuterClassExample
    {
        public string name;

        public OuterClassExample(string name)
        {
            this.name = name;
        }
        private class Nestedclass
        {
            private string name;
            private OuterClassExample parent;

            public Nestedclass(OuterClassExample parent,string name)
            {
                this.parent = parent;
                this.name = name;
            }
            public void printName()
            {
                Console.WriteLine("nested name:"+this.name);
                Console.WriteLine("outer name:"+this.parent.name)
            }
            static void main()
            {
                OuterClassExample outerclass = new outerclass("outer");
                Nestedclass nestedclass = new OuterClassExample.Nestedclass(outerclass, "nestedclass");
                nestedclass.printName();

            }
        }
    }
}
