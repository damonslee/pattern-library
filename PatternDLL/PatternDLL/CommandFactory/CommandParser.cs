﻿using System.Collections.Generic;
using System.Linq;

namespace CommandFactory
{
    public class CommandParser
    {
        private readonly IEnumerable<ICommand> _commands;
        public CommandParser(IEnumerable<ICommand> commands)
        {
            _commands = commands;
        }

        public ICommand Parse(string[] args)
        {
            string commandName = args[0];
            ICommand command = Find(commandName);

            return ((ICommandFactory)command).Create(args);
        }

        private ICommand Find(string commandName)
        {
            return _commands.FirstOrDefault(c => c.CommandName == commandName);
        }
    }
}