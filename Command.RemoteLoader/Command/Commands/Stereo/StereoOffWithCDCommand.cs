namespace Command.RemoteLoader.Command.Commands.Stereo;

public class StereoOffWithCDCommand : ICommand
{
    private CommandObjects.Stereo _stereo;

    public StereoOffWithCDCommand(CommandObjects.Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.Off();
    }

    public void Undo()
    {
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(3);
    }
}