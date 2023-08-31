using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
   class SampleClass
    {
        int age=5;
        long distance=234;
        string[] names =new string[] {"peter","martin"};
    

    }

    public void Alamin()
    {
        int myAge = this.GetAge();
        Console.WriteLine("my age is"+myAge);
    }
         
    public class Dog
    {
        string name="alamin";
        int age=24;
        int length=234;
        bool isMale=true;

        static void Main()
        {
            Dog dog = new Dog();

            Console.WriteLine("dog name is:" + dog.name);
        }

        private static void Main()
        {
            int notInitializedLocalVariable;
            Console.WriteLine(notInitializedLocalVariable);
        }

        public void Makeolder()
        {
            this.age++;
            Dog.MakeOlder()
           {
                Console.WriteLine("", +Dog.age);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
