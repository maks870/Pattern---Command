class SpawnMeleeCommand : ICommand
{
    private Barrack barrack;
    public SpawnMeleeCommand(Barrack barrack)
    {
        this.barrack = barrack;
    }

    public void Execute()
    {
        barrack.SpawnMeleeArmy();
    }

    public void Undo()
    {
        barrack.StopSpawning();
    }
}
