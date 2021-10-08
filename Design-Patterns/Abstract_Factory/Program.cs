using System;

namespace Abstract_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			IBaseBuilder factory;
			Console.Write("Choose a base to build:	1-Blue | 2 - Red:	");											
		switch (Console.ReadLine())
			{
				case "1":
					factory = new BlueBaseBuilder();
					break;
				case "2":
					factory = new RedBaseBuilder();
					break;
			}
			Console.ReadLine();
		}
	}
}
