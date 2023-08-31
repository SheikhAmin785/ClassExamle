using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class PublicClassScopeTest
    {
        int myValue = 3;
        void printmyvalue()
        {
            Console.WriteLine("my value is"+myvalue);
        }
        static void Main()
        {
            PublicClassScopeTest instance = new PublicClassScopeTest();
            instance.printmyvalue;
        }
    }
    class Dog
    {
        public string name = "Doggy";
        public string Name
        {
            get { return this.name; }
        }
        public void Bark()
        {
            Console.WriteLine("wow-wow");
        }
        public void DoSomething()
        {
            this.Bark();
        }
    }
    Kid.cs
class Kid
    {
        public void CallTheDog(Dog dog)
        {
            Console.WriteLine("Come, " + dog.name);
        }
        public void WagTheDog(Dog dog)
        {
            dog.Bark();
        }
    }
    D
    R
D
D
R
R
Chapter 14. Defining Classes 527
As we can see, we implement without problem the access to the field name
and the method Bark() of the class Dog from the body of the same class. 
Independently, if the namespace of the class Kid is the same as Dog, we can,
from its body, access the field name and to call the method Bark() via the
“dot” operator, applied to the reference dog of the object from type Dog.
Access Level "internal"
When a member of some class is declared with access level internal, then
this element from the class can be accessed from every class in the same
assembly(i.e. in the same project in Visual Studio), but not from classes
outside it(i.e.from other projects in Visual Studio – from the same solution
or from a different solution).
Not that if we have a Visual Studio project, all classes in it are from the same
assembly and classes defined in different Visual Studio projects(in the same
or in a different solution) are from different assemblies.
Below is the explanation about the access level internal:
Dog.cs
class Dog
    {
        internal string name = "Doggy";
        public string Name
        {
            get { return this.name; }
        }
        internal void Bark()
        {
            Console.WriteLine("wow-wow");
        }
        public void DoSomething()
        {
            this.Bark();
        }
    }
    }
