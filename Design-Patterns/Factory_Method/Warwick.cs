using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Warwick : ICharacter
    {
        public void Picked()
        {
            Console.WriteLine("Warwick!");
        }
    }
}
