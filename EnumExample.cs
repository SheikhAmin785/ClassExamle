using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class EnumExample
    {
        public CoffeeSize size;
        public EnumExample(CoffeeSize size)
        {
            this.size = size;
        }
        public CoffeeSize size
        {
            get { retuen size; }
        }
        public EnumExample()
        {
          
        }
        public enum CoffeeSize
        {
            Small=100, normal=150,Double=300;
        }
        static void Main()
        {
            EnumExample normalcoffee = new EnumExample(CoffeeSize.normal);
            EnumExample doubcoffee = new EnumExample(CoffeeSize.Double);
            Console.WriteLine("the {0} coffee is {1} m1.",normalcoffee.size,(int)normalcoffee.size);
        }
        public double calprice(CoffeeSize coffeeSize)
        {
            switch (coffeeSize)
            {
                case coffeeSize.Small:
                    return 0.20;
                case coffeeSize.Normal:
                    return 0.30;
                case coffeeSize Double:
                    return 0.60;
                default:
                    throw new InvalidOperationException(
                        "unsupported coffee quantity:" + (int)coffeeSize);
            }

        }
    }
}

//output
normalcoffee 150 ml
    doublecoffe 300ml




