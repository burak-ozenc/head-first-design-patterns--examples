namespace Command.RemoteLoader.Command.Commands.GarageDoor;

public class GarageDoorOnCommand : ICommand
{
    private CommandObjects.GarageDoor _garageDoor;

    public GarageDoorOnCommand(CommandObjects.GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.On();
    }

    public void Undo()
    {
        _garageDoor.Off();
    }
}