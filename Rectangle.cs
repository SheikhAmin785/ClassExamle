using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class Rectangle
    {
        private float height;
        private float width;
        public Rectangle(float height,float width)
        {
            this.height = height;
            this.width = width;
        }
        public float Area
        {
            get { return this.height * this.width; }
        }
    }
}
