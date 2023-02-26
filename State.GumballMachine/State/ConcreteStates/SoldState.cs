namespace State.GumballMachine.State.ConcreteStates;

public class SoldState : IState
{
    private Context.GumballMachine _gumballMachine;

    public SoldState(Context.GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("please wait. we are already given you a gumball.");
    }

    public override void EjectQuarter()
    {
        Console.WriteLine("You already turned the crank.");
    }

    public override void Dispense()
    {
        _gumballMachine.ReleaseBall();
        if(_gumballMachine.GetCount() > 0)
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        else
        {
            Console.WriteLine("ooops, out of gumball");
            _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
        }
    }
}