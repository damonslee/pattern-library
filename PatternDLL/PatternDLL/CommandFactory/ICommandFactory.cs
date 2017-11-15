namespace CommandFactory
{
    public interface ICommandFactory
    {
        ICommand Create(string[] args);
    }
}
