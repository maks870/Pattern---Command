


class SpawnPartisansCommand : ICommand
{
    private Barrack barrack;
    public SpawnPartisansCommand(Barrack barrack)
    {
        this.barrack = barrack;
    }

    public void Execute()
    {
        barrack.SpawnPartisanSquads();
    }

    public void Undo()
    {
        barrack.StopSpawning();
    }
}
