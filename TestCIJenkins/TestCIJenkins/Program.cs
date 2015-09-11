using System;

namespace TestCIJenkins
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Unknown command");
                return;
            }

            if (args[0].Equals("exit", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Goodbye");
                return;
            }

            Console.WriteLine(string.Format("Command: [{0}] processed", args[0]));
        }
    }
}
