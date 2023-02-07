namespace Command.RemoteLoader.Command.Commands.Light;

public class LightOffCommand : ICommand
{
    private CommandObjects.Light _light;
    private string _place;

    public LightOffCommand(CommandObjects.Light light, string place)
    {
        _light = light;
        _place = place;
    }

    public void Execute()
    {
        _light.Off(_place);
    }

    public void Undo()
    {
        _light.On(_place);
    }
}