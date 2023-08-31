using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    public class ConstantAndReadonlyExample
    {
        public const double PI = 3.1416;
        public readonly double size;

        public ConstantAndReadonlyExample(int size){
            this.Size = size;
           static void Main()
            {
                Console.WriteLine(PI);
                Console.WriteLine(ConstantAndReadonlyExampl.PI);
                ConstantAndReadonlyExampl instance = new ConstantAndReadonlyExampl();
                Console.WriteLine(instance.Size);
                Console.WriteLine(ConstantAndReadonlyExampl.Size);
                ConstantAndReadonlyExampl.PI = 0;
                instance.Size = 0;
            }

}

        public object ConstantAndReadonlyExampl { get; private set; }
    }
}
