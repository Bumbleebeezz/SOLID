namespace SOLID.Strategys
{
    public class MessageStrategy
    {
        // NOT SRP: "or"
        public static void SayHelloOrGoodbye(int choice)
        {
            if (choice == 0)
                Console.WriteLine("Hellooooooo");
            else
                Console.WriteLine("Byeeee");
        }

        // SRP, OCP
        private static Dictionary<int, Action> _messageStrategies = new()
        {
			// Is open for extensions 
			{0,SayHello},
            {1,SayGoodbye},
            {2,SayWelcomeBack}
        };
        private static Dictionary<string, Action> _endpointStrategies = new()
        {
			// Is open for extensions 
			{"/product",() => {}}
        };
        public static void MessageChoice(int choice)
        {
            if (!_messageStrategies.ContainsKey(choice))
            {
                return;
            }
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
        public static void SayWelcomeBack()
        {
            Console.WriteLine("Welcome baaaack");
        }
    }
}
