abstract class MacroCommand : ICommand
{
    protected ICommand[] orders;

    public MacroCommand(ICommand[] orders)
    {
        this.orders = orders;
    }

    public virtual void Execute()
    {
        for (int i = 0; i < orders.Length; i++)
        {
            orders[i].Execute();
        }
    }

    public virtual void Undo()
    {
        for (int i = 0; i < orders.Length; i++)
        {
            orders[i].Undo();
        }
    }
}
