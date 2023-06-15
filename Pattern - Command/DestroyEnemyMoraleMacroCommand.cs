class DestroyEnemyMoraleMacroCommand : MacroCommand
{
    public DestroyEnemyMoraleMacroCommand(ICommand[] orders) : base(orders)
    {
    }

    public override void Undo()
    {
        for (int i = 0; i < orders.Length; i++)
        {
            orders[i].Undo();
        }
    }
}
