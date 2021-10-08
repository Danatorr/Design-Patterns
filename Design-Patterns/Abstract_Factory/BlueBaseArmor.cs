using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class BlueBaseArmor : IArmor
    {
        public void Composition()
        {
            Console.WriteLine("Equipping troops with blue armor!");
        }
    }
}
