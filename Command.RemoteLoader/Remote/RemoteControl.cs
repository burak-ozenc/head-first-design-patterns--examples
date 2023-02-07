using System.Text;
using Command.RemoteLoader.Command;

namespace Command.RemoteLoader.Remote;

public class RemoteControl
{
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;
    private ICommand _undoCommand;

    public RemoteControl(ICommand[] onCommands, ICommand[] offCommands)
    {
        NoCommand noCommand = new NoCommand();
        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
        _onCommands = onCommands;
        _offCommands = offCommands;
        _undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonPressed(int slot)
    {
        _onCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }

    public void OffButtonPressed(int slot)
    {
        _offCommands[slot].Execute();
        _undoCommand = _offCommands[slot];
    }
    
    public void UndoButtonPressed()
    {
        _undoCommand.Undo();
    }

    public string ReturnCommands()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("---- Remote Control ----\n");
        for (int i = 0; i < _onCommands.Length; i++)
        {
            sb.Append("[slot " + i + "]" + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
        }

        return sb.ToString();
    }
}