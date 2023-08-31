using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class EncaptulationExample
    {
        private double x;
        private double y;
        public EncaptulationExample(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public double x
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        static void Main()
        {
            EncaptulationExample myTest = new EncaptulationExample(2,3);
            double myTestone = myTest.x; //access property
            double myTesttwo = myTest.y;
            Console.WriteLine("my test one is:" + myTestone);
            Console.WriteLine("my test two is:" + myTesttwo);
        }
    }
}
