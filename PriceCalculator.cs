using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class PriceCalculator
    {
        public const int SmallCoffeeQuantity = 100;
        public const int NormalCoffeeQuantity = 150;
        public const int DoubleCoffeeQuantity = 300;

        public cashmachine()
        {

        }
        public double Calcprice(int quantity)
        {
            switch (quantity)
            {
                case SmallCoffeeQuantity:
                    return 0.20;
                case NormalCoffeeQuantity:
                    return 0.30;
                case DoubleCoffeeQuantity:
                    return 0.40;
                default:

                    throw new InvalidOperationException("unsupported coffee quantity:" + quantity);

            }
        }
    }
}
