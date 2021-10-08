using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class BlueBaseBuilder : IBaseBuilder
	{
		public BlueBaseBuilder()
		{
			BuildBase();
		}
		public void BuildBase()
		{
			Console.WriteLine("Blue base has been built!");
			BlueBaseArmor armor = new BlueBaseArmor();
			armor.Composition();
			BlueBaseEnergy energy = new BlueBaseEnergy();
			energy.Composition();
		}
	}
}
