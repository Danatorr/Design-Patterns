using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class BlueBaseEnergy : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Gathering blue energy!");
        }
    }
}
