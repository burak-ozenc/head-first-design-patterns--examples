namespace Command.RemoteLoader.Command.Commands.CeilingFan;

public class CeilingFanLowCommand : ICommand
{
    private CommandObjects.CeilingFan _ceilingFan;
    private int previousSpeed;
    private string _location;

    public CeilingFanLowCommand(CommandObjects.CeilingFan ceilingFan, string location)
    {
        _ceilingFan = ceilingFan;
        _location = location;
    }

    public void Execute()
    {
        previousSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.Low(_location);
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