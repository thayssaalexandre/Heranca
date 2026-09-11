using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    public class Animal
    {
        public string Nome { get; set; }

        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }

    }
}
