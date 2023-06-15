class SiegePreparingCommand : ICommand
{
    private Siege siege;

    public SiegePreparingCommand(Siege siege)
    {
        this.siege = siege;
    }

    public void Execute()
    {
        siege.PreparingToSiege();
    }

    public void Undo()
    {
        siege.CancelSiege();
    }
}
