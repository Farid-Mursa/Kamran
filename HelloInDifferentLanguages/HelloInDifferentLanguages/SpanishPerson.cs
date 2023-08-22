using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloInDifferentLanguages
{
    internal class SpanishPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Hola");
        }
    }
}
