namespace Command.RemoteLoader.Command.Commands.Stereo;

public class StereoOnWithCDCommand : ICommand
{
    private CommandObjects.Stereo _stereo;

    public StereoOnWithCDCommand(CommandObjects.Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(3);
    }

    public void Undo()
    {
        _stereo.Off();
    }
}