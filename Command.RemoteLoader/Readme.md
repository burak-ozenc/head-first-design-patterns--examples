# Chapter 5 - RemoteLoader

## Command Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Command Pattern</b> encapsulates a request as an object thereby letting you parameterize with different requests, 
queue or or log request and suppurt undoable operations.
</pre>

### Problem
Need to create an API which receives the actions on a remote control, depending on the request, switch between on and off or between levels, undo last action 
and take the necessary actions.
This remote control can access lights in rooms, garage door, ceiling fan, stereo, etc.
Also a macro command will be added which will start and stop multiple tasks at once. 

### Solution
Command Pattern decouples an object, making a request from the one that knows how to perform it.

All commands will have ICommand interface with their own methods. They will use registered command object to execute commands.
Client will create this object, register the desired requests(on-off or levels) to the RemoteControl panel which has 7 slots.  
Later, whenever a button pressed, this will invoke necessary command and it will be executed.

CommandObjects are in the center of decoupling and encapsulates a receiver(RemoteControl) with an action/actions(Commands). 

For handling not registered command slots, NoCommand object is used. 
Again it has ICommand interface, and in constructor on RemoteControl it is automatically set.

Undo button, saves the last action executed, in case of pressed it calls last action executed and restores the object to previous state.

MacroCommand inherits from ICommand and just applies the registered on and off commands' Execute and Undo methods.