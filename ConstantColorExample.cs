using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class ConstantColorExample
    {
        private int red;
        private int green;
        private int blue;
        public ConstantColorExample(int red,int green,int blue){

            this.red = red;
            this.green = green;
            this.blue = blue;
            

}class color
        {
            public const color black = new color(0, 0, 0);
            public const color white = new color(255, 255, 255);
            private int red;
            private int green;
            private int blu;
        }
    }
}
