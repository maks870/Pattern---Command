
class SpawnRangeCommand : ICommand
{
    private Barrack barrack;
    public SpawnRangeCommand(Barrack barrack)
    {
        this.barrack = barrack;
    }

    public void Execute()
    {
        barrack.SpawnRangeArmy();
    }

    public void Undo()
    {
        barrack.StopSpawning();
    }
}
