using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloInDifferentLanguages
{
    internal class RussianPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Pirivit");
        }
    }
}
