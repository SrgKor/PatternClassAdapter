using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_ClassAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITargetInterface r;
            r = new ClassAdapter();
            r.targetMethod();
        }
    }

    interface ITargetInterface
    {
        void targetMethod();
    }

    class Adaptee
    {
        protected void Method() // Закрыт на уровне объекта
        {
            Console.WriteLine("Работает наш метод.");
            Console.ReadLine();
        }
    }

    class ClassAdapter: Adaptee, ITargetInterface
    {
        public void targetMethod()
        {
            Method();
        }
    }
}
