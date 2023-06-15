
class SiegeStartCommand : ICommand
{
    private Siege siege;

    public SiegeStartCommand(Siege siege)
    {
        this.siege = siege;
    }

    public void Execute()
    {
        siege.StartSiege();
    }

    public void Undo()
    {
        siege.CancelSiege();
    }
}