class ArmyControl
{
    private ICommand[] orders;
    private ICommand lastOrder;

    public ArmyControl(int ordersCount)
    {
        orders = new ICommand[ordersCount];
        for (int i = 0; i < ordersCount; i++)
        {
            orders[i] = new NoCommand();
        }

        lastOrder = new NoCommand();
    }


    public void SetOrder(int orderNumber, ICommand order)
    {
        orders[orderNumber] = order;
    }

    public void PerformOrder(int orderNumber)
    {
        orders[orderNumber].Execute();
        lastOrder = orders[orderNumber];
    }

    public void UndoOrder(int orderNumber)
    {
        orders[orderNumber].Undo();
        UndoCommand newUndoCommand = new UndoCommand(orders[orderNumber]);
        lastOrder = newUndoCommand;
    }

    public void UndoLastOrder()
    {
        lastOrder.Undo();
        UndoCommand newUndoCommand = new UndoCommand(lastOrder);
        lastOrder = newUndoCommand;
    }

}
