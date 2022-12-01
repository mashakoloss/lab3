using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
     class B //Базовий клас
    {
       
        
            string name;
        int line;
            public B(string name)
            {
                this.name = name;
                Console.WriteLine("B(string name)");
            }
            public B(string name, int line) : this(name)
            {
            this.line = line;
                Console.WriteLine("B(string name, int line)");
            }
        }
    class A : B
    {
        string letters;
        public A(string name, int age, string letters)
            : base(name, age)
        {
            this.letters = letters;
            Console.WriteLine("A(string name, int line, string letters)");
        }
    }
    }
