namespace State.GumballMachine.State;

public abstract class IState
{
    public abstract void InsertQuarter();
    public abstract void EjectQuarter();

    public virtual void TurnCrank()
    {
        Console.WriteLine("Not available");
    }

    public virtual void Dispense()
    {
        Console.WriteLine("Not available");
    }
}