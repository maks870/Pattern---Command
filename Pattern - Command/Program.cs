using System;

namespace Pattern___Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmyControl armyControl = new ArmyControl(11);
            Army army = new Army();
            Barrack barrack = new Barrack();
            Siege siege = new Siege();

            ICommand spawnMelee = new SpawnMeleeCommand(barrack);
            ICommand spawnRange = new SpawnRangeCommand(barrack);
            ICommand spawnMounted = new SpawnMountedCommand(barrack);
            ICommand spawnPartisan = new SpawnPartisansCommand(barrack);

            ICommand armyOffensive = new ArmyOffensiveCommand(army);
            ICommand partisanSabotage = new PartisanSabotageCommand(army);

            ICommand siegePreparing = new SiegePreparingCommand(siege);
            ICommand siegeStart = new SiegeStartCommand(siege);

            ICommand recruitArmies = new RecruitArmiesMarcoCommand(new ICommand[] { spawnMelee, spawnRange, spawnMounted });
            ICommand destroyEnemyMorale = new DestroyEnemyMoraleMacroCommand(new ICommand[] { spawnPartisan, partisanSabotage });
            ICommand captureCastle = new CaptureCastleMacroCommand(new ICommand[] { recruitArmies, new UndoCommand(recruitArmies), destroyEnemyMorale, new UndoCommand(destroyEnemyMorale), siegePreparing, siegeStart, armyOffensive });

            armyControl.SetOrder(0, spawnMelee);
            armyControl.SetOrder(1, spawnRange);
            armyControl.SetOrder(2, spawnMounted);
            armyControl.SetOrder(3, spawnPartisan);
            armyControl.SetOrder(4, armyOffensive);
            armyControl.SetOrder(5, partisanSabotage);
            armyControl.SetOrder(6, siegePreparing);
            armyControl.SetOrder(7, siegeStart);
            armyControl.SetOrder(8, recruitArmies);
            armyControl.SetOrder(9, destroyEnemyMorale);
            armyControl.SetOrder(10, captureCastle);

            armyControl.PerformOrder(0);
            armyControl.UndoLastOrder();
            Console.WriteLine();

            Console.WriteLine("Execute capture castle order");
            armyControl.PerformOrder(10);
            Console.WriteLine();

            armyControl.UndoLastOrder();
            Console.WriteLine();

            Console.WriteLine("Execute capture castle order again");
            armyControl.UndoLastOrder();
            Console.ReadKey();


        }
    }
}
