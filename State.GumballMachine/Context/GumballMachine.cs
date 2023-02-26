using System.Text;
using State.GumballMachine.State;
using State.GumballMachine.State.ConcreteStates;

namespace State.GumballMachine.Context;

public class GumballMachine
{
    private static IState soldOutState;
    private static IState noQuarterState;
    private static IState hasQuarterState;
    private static IState soldState;
    private static IState winnerState;
    
    // initial state is soldOutState
    // we forecast this is an empty machine
    private static IState _state = soldOutState;
    private int count = 0;
    

    public GumballMachine(int initialGumball)
    {
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);
        winnerState = new WinnerState(this);
        
        count = initialGumball;
        if (initialGumball > 0)
            _state = noQuarterState;
    }
    
    public void InsertQuarter()
    {
        _state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        _state.EjectQuarter();
    }

    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball incomiiiiing...");
        if (count != 0)
            count--;
    }

    public IState GetNoQuarterState()
    {
        return noQuarterState;
    }
    
    public IState GetHasQuarterState()
    {
        return hasQuarterState;
    }
    
    public IState GetSoldOutState()
    {
        return soldOutState;
    }
    
    public IState GetSoldState()
    {
        return soldState;
    }
    public IState GetWinnerState()
    {
        return winnerState;
    }

    public int GetCount()
    {
        return count;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("\n Welcome to the Gumball Machine");
        sb.Append("\n There are " + count + " available gum"  + (count != 1 ? "s" : "") + " in this machine available.");

        sb.Append("\n Machine state is " + _state.GetType().Name);

        return sb.ToString();
    }
}