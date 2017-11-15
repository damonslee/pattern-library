using CommandFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFactorySample.Commands
{
    class DoSomethingOne : ICommand, ICommandFactory
    {
        public string CommandName => "something1";

        public string CommandDescription => "Command description";

        public string CommandParam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand Create(string[] args)
        {
            return new DoSomethingOne { };
        }

        public void Execute()
        {
            Console.WriteLine("do something .....");
        }
    }
}
