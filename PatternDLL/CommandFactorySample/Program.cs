using CommandFactory;
using CommandFactorySample.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CommandFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ICommand> commands = GetCommands();

            try
            {
                var parser = new CommandParser(commands);
                ICommand command = parser.Parse(args);
                command.Execute();
            }
            catch (Exception e)
            {
                if (args.Length == 0) args = null;
                Debug.WriteLine(e.InnerException);
                Console.WriteLine("Invalid command {0}", args);
                PrintInstructions(commands);
            }
        }

        private static IEnumerable<ICommand> GetCommands()
        {
            return new List<ICommand>
            {
                new DoSomethingOne(),
                new DoSomethingTwo(),
            };
        }

        private static void PrintInstructions(IEnumerable<ICommand> commands)
        {
            Console.WriteLine();
            Console.WriteLine("# VENDING MACHINE commands #");
            Console.WriteLine();

            foreach (ICommand command in commands)
            {
                Console.WriteLine("- {0}", command.CommandDescription);
            }

            Console.WriteLine();
        }
    }
}