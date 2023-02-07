namespace Command.RemoteLoader.Command.Commands.GarageDoor;

public class GarageDoorOffCommand : ICommand
{
    private CommandObjects.GarageDoor _garageDoor;

    public GarageDoorOffCommand(CommandObjects.GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Off();
    }

    public void Undo()
    {
        _garageDoor.On();
    }
}