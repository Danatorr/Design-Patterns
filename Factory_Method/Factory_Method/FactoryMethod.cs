using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class FactoryMethod
    {
        public ICharacter Pick_Character(string character)
        {
            switch (character)
            {
                case "Rengar": return new Rengar();
                case "Warwick": return new Warwick();
                case "Braum": return new Braum();
                default: return null;
            }
        }
    }
}
