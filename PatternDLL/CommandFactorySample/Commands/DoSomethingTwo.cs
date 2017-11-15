using CommandFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFactorySample.Commands
{
    class DoSomethingTwo : ICommand, ICommandFactory
    {
        public string CommandName => "something2";

        public string CommandDescription => "Validation comamnd name " + CommandName;

        public string CommandParam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand Create(string[] args)
        {
            return new DoSomethingTwo { };
        }

        public void Execute()
        {
            Console.WriteLine("do something .....");
        }
    }
}
