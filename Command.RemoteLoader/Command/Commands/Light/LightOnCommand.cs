namespace Command.RemoteLoader.Command.Commands.Light;

public class LightOnCommand : ICommand 
{
    private readonly CommandObjects.Light _light;
    private readonly string _location;

    public LightOnCommand(CommandObjects.Light light, string location)
    {
        _light = light;
        _location = location;
    }

    public void Execute()
    {
        _light.On(_location);
    }

    public void Undo()
    {
        _light.Off(_location);
    }
}