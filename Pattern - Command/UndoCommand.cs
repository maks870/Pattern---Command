class UndoCommand : ICommand
{
    ICommand command;

    public UndoCommand(ICommand command)
    {
        this.command = command;
    }

    public void Execute()
    {
        command.Undo();
    }

    public void Undo()
    {
        command.Execute();
    }
}
