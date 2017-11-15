using System.Collections.Generic;
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
            string commandName = string.Empty;
           
            if(args.Length > 0) commandName = args[0];

            ICommand command = Find(commandName);

            return ((ICommandFactory)command).Create(args);
        }

        private ICommand Find(string commandName)
        {
            ICommand cmd;

            if (string.IsNullOrEmpty(commandName))
                cmd = _commands.FirstOrDefault();
            else
                cmd = _commands.FirstOrDefault(c => c.CommandName == commandName);

            return cmd;
        }
    }
}