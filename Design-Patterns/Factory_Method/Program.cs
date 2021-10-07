using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
		static void Main(string[] args)
		{
			FactoryMethod fm = new FactoryMethod();
			Console.WriteLine("Rengar	|	Warwick	|	Braum");
			Console.WriteLine();
			Console.Write("Choose your champion:	");
			string choice = Console.ReadLine();
			ICharacter character = fm.Pick_Character(choice);
			Console.WriteLine();
			Console.Write("You're going to play with: ");
			character.Picked();
			Console.ReadKey();
		}
	}
}
