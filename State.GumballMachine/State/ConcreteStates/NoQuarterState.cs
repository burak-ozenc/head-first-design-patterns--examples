namespace State.GumballMachine.State.ConcreteStates;

public class NoQuarterState : IState
{
    private Context.GumballMachine _gumballMachine;

    public NoQuarterState(Context.GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter.");
        _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
    }

    public override void EjectQuarter()
    {
        Console.WriteLine("You have not inserted a quarter yet.");
    }
}