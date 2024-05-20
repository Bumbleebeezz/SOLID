using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SOLID
{
	public class SRP
	{
		// NOT SRP: "or"
		public static void SayHelloOrGoodbye(int choice) 
		{
			if (choice == 0)
                Console.WriteLine("Hellooooooo");
            else
				Console.WriteLine("Byeeee");
        }

		// SRP
		private static Dictionary<int,Action> _messageStrategies = new()
		{
			{0,SayHello},
			{1,SayGoodbye}
		};
		public static void MessageChoice(int choice)
		{
			_messageStrategies[choice]();
		}
		public static void SayHello()
		{
			Console.WriteLine("Hellooooooo");
		}
		public static void SayGoodbye()
		{
			Console.WriteLine("Byeeee");
		}
	}
}
