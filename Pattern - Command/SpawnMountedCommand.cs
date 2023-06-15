

class SpawnMountedCommand : ICommand
{
    private Barrack barrack;
    public SpawnMountedCommand(Barrack barrack)
    {
        this.barrack = barrack;
    }

    public void Execute()
    {
        barrack.SpawnMountedArmy();
    }

    public void Undo()
    {
        barrack.StopSpawning();
    }
}
