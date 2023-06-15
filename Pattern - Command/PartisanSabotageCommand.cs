
class PartisanSabotageCommand : ICommand
{
    private Army army;

    public PartisanSabotageCommand(Army army)
    {
        this.army = army;
    }

    public void Execute()
    {
        army.StartDiversion();
    }

    public void Undo()
    {
        army.StopDiversion();
    }
}