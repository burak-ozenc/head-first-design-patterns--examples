namespace State.GumballMachine.State.ConcreteStates;

public class WinnerState : IState
{
    private readonly Context.GumballMachine _gumballMachine;

    public WinnerState(Context.GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public override void InsertQuarter()
    {
        throw new NotImplementedException();
    }

    public override void EjectQuarter()
    {
        throw new NotImplementedException();
    }

    public override void Dispense()
    {
        _gumballMachine.ReleaseBall();
        if(_gumballMachine.GetCount() == 0)
            _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
        else
        {
            _gumballMachine.ReleaseBall();
            Console.WriteLine("Congratz! You win an extra free gumball,");
            if(_gumballMachine.GetCount() > 0)
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
                Console.WriteLine("Sorry, out of gumball.");
            }
        }
    }
}