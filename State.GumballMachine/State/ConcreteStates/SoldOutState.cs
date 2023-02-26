namespace State.GumballMachine.State.ConcreteStates;

public class SoldOutState : IState
{
    private Context.GumballMachine _gumballMachine;

    public SoldOutState(Context.GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("gumball machine is empty");
    }

    public override void EjectQuarter()
    {
        Console.WriteLine("you have not inserted any quarter");
    }

}