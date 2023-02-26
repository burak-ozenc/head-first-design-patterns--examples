namespace State.GumballMachine.State.ConcreteStates;

public class HasQuarterState : IState
{
    private readonly Context.GumballMachine _gumballMachine;
    private readonly Random random = new ();

    public HasQuarterState(Context.GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("You can not insert another quarter");
    }

    public override  void EjectQuarter()
    {
        Console.WriteLine("Quarter returned.");
        _gumballMachine.EjectQuarter();
    }

    public override  void TurnCrank()
    {
        Console.WriteLine("You turned ...");
        var winner = random.Next(0, 3);
        if(winner == 0 && _gumballMachine.GetCount() > 1)
            _gumballMachine.SetState(_gumballMachine.GetWinnerState());
        else
            _gumballMachine.SetState(_gumballMachine.GetSoldState());
    }
}