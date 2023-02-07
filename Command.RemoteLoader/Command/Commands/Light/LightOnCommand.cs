namespace Command.RemoteLoader.Command.Commands.Light;

public class LightOnCommand : ICommand 
{
    private CommandObjects.Light _light;
    private string _place;

    public LightOnCommand(CommandObjects.Light light, string place)
    {
        _light = light;
        _place = place;
    }

    public void Execute()
    {
        _light.On(_place);
    }

    public void Undo()
    {
        _light.Off(_place);
    }
}