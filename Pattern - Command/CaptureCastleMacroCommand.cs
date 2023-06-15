class CaptureCastleMacroCommand : MacroCommand
{
    public CaptureCastleMacroCommand(ICommand[] orders) : base(orders)
    {
    }

    public override void Undo()
    {
        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i].GetType() == typeof(SiegeStartCommand))
                orders[i].Undo();

            if (orders[i].GetType() == typeof(ArmyOffensiveCommand))
                orders[i].Undo();
        }
    }
}
