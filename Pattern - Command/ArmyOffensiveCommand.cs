class ArmyOffensiveCommand : ICommand
{
    private Army army;

    public ArmyOffensiveCommand(Army army)
    {
        this.army = army;
    }

    public void Execute()
    {
        army.GoToBattle();
    }

    public void Undo()
    {
        army.Retreat();
    }
}
