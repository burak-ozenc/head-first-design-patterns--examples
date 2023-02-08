namespace Command.RemoteLoader.Command.Commands;

public class MacroCommand : ICommand
{
    private ICommand[] _commands;
    private NoCommand _noCommand;

    public MacroCommand(ICommand[] commands)
    {
        _commands = commands;
    }

    public void Execute()
    {
        for (int i = 0; i < _commands.Length; i++)
        {
            _commands[i].Execute();
        }
    }

    public void Undo()
    {
        for (int i = 0; i < _commands.Length; i++)
        {
            _commands[i].Undo();
        }
    }
}