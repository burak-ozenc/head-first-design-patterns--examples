namespace Command.RemoteLoader.Command.Commands.CeilingFan;

public class CeilingFanHighCommand : ICommand
{
    CommandObjects.CeilingFan _ceilingFan;
    private string _location;
    private int previousSpeed;


    public CeilingFanHighCommand(CommandObjects.CeilingFan ceilingFan, string location)
    {
        _ceilingFan = ceilingFan;
        _location = location;
    }

    public void Execute()
    {
        previousSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.High(_location);
    }

    public void Undo()
    {
        if (previousSpeed == CommandObjects.CeilingFan.off)
            _ceilingFan.Off(_location);
        else if( previousSpeed == CommandObjects.CeilingFan.low)
            _ceilingFan.Low(_location);
        else if( previousSpeed == CommandObjects.CeilingFan.medium)
            _ceilingFan.Medium(_location);
        else if( previousSpeed == CommandObjects.CeilingFan.high)
            _ceilingFan.High(_location);
    }
}