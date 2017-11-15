namespace CommandFactory
{
    public interface ICommand
    {
        string CommandName { get; }
        string CommandDescription { get; }
        string CommandParam { set; get; }
        void Execute();
    }
}
