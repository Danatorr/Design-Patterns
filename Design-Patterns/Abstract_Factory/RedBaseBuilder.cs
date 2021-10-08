using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class RedBaseBuilder : IBaseBuilder
	{
		public RedBaseBuilder()
		{
			BuildBase();
		}
		public void BuildBase()
		{
			Console.WriteLine("Red base has been built!");
			RedBaseArmor armor = new RedBaseArmor();
			armor.Composition();
			RedBaseEnergy energy = new RedBaseEnergy();
			energy.Composition();
		}
	}
}
