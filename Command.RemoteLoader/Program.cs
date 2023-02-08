using Command.RemoteLoader.Command;
using Command.RemoteLoader.Command.CommandObjects;
using Command.RemoteLoader.Command.Commands;
using Command.RemoteLoader.Command.Commands.CeilingFan;
using Command.RemoteLoader.Command.Commands.GarageDoor;
using Command.RemoteLoader.Command.Commands.Light;
using Command.RemoteLoader.Command.Commands.Stereo;
using Command.RemoteLoader.Remote;

ICommand[] onCommands = new ICommand[7];
ICommand[] offCommands = new ICommand[7];

ICommand[] macroOn = new ICommand[7];
ICommand[] macroOff = new ICommand[7];

RemoteControl remoteControl = new RemoteControl(onCommands,offCommands);

// living room lights
Light livingRoomLight = new Light();
{
    LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight, "living room");
    LightOnCommand kitchenLightOn = new LightOnCommand(livingRoomLight, "kitchen");
    LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight, "living room");
    LightOffCommand kitchenLightOff = new LightOffCommand(livingRoomLight, "kitchen");
    macroOn[0] = livingRoomLightOn;
    macroOff[0] = livingRoomLightOff;
    macroOn[1] = kitchenLightOn;
    macroOff[1] = kitchenLightOff;

    remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
}

// garage door
GarageDoor garageDoor = new GarageDoor();
{
    GarageDoorOnCommand garageDoorOn = new GarageDoorOnCommand(garageDoor);
    GarageDoorOffCommand garageDoorOff = new GarageDoorOffCommand(garageDoor);
    macroOn[2] = garageDoorOn;
    macroOff[2] = garageDoorOff;
    
    remoteControl.SetCommand(1, garageDoorOn, garageDoorOff);
}

// stereo
Stereo stereo = new Stereo();
{
    StereoOnWithCDCommand stereoOnWithCd = new StereoOnWithCDCommand(stereo);
    StereoOffWithCDCommand stereoOffWithCd = new StereoOffWithCDCommand(stereo);

    macroOn[3] = stereoOnWithCd;
    macroOff[3] = stereoOffWithCd;
    
    remoteControl.SetCommand(2,stereoOnWithCd,stereoOffWithCd);
}

// ceiling fan
CeilingFan ceilingFanLivingRoom = new CeilingFan("living room");
{
    CeilingFanOffCommand livingRoomCeilingFanOff = new CeilingFanOffCommand(ceilingFanLivingRoom, "living room");
    CeilingFanLowCommand livingRoomCeilingFanLow = new CeilingFanLowCommand(ceilingFanLivingRoom, "living room");
    CeilingFanMediumCommand livingRoomCeilingFanMedium = new CeilingFanMediumCommand(ceilingFanLivingRoom, "living room");
    CeilingFanHighCommand livingRoomCeilingFanHigh = new CeilingFanHighCommand(ceilingFanLivingRoom, "living room");
    
    macroOn[4] = livingRoomCeilingFanLow;
    macroOff[4] = livingRoomCeilingFanOff;
    macroOn[5] = livingRoomCeilingFanMedium;
    macroOff[5] = livingRoomCeilingFanOff;
    macroOn[6] = livingRoomCeilingFanHigh;
    macroOff[6] = livingRoomCeilingFanOff;
    
    remoteControl.SetCommand(3,livingRoomCeilingFanLow,livingRoomCeilingFanOff);
    remoteControl.SetCommand(4,livingRoomCeilingFanMedium,livingRoomCeilingFanOff);
    remoteControl.SetCommand(5,livingRoomCeilingFanHigh,livingRoomCeilingFanOff);
}


// macro command
Console.WriteLine();
{
    MacroCommand macroOnCommand = new MacroCommand(macroOn);
    MacroCommand macroOffCommand = new MacroCommand(macroOff);

    remoteControl.SetCommand(6, macroOnCommand,macroOffCommand);
}

Console.WriteLine(remoteControl.ReturnCommands());
Console.WriteLine();



Console.WriteLine("macroOn pressed");
Console.WriteLine();
remoteControl.OnButtonPressed(6);
Console.WriteLine(); 
Console.WriteLine("macroOff pressed");
remoteControl.OffButtonPressed(6);


Console.WriteLine();


remoteControl.OnButtonPressed(0);
remoteControl.OffButtonPressed(0);
remoteControl.UndoButtonPressed();

Console.WriteLine();

remoteControl.OnButtonPressed(1);
remoteControl.OffButtonPressed(1);
remoteControl.UndoButtonPressed();

Console.WriteLine();

remoteControl.OnButtonPressed(2);
remoteControl.OffButtonPressed(2);
remoteControl.UndoButtonPressed();

Console.WriteLine();



remoteControl.OnButtonPressed(3);
remoteControl.OffButtonPressed(3);
remoteControl.UndoButtonPressed();

remoteControl.OnButtonPressed(4);
remoteControl.OffButtonPressed(4);
remoteControl.UndoButtonPressed();

remoteControl.OnButtonPressed(5);
remoteControl.OffButtonPressed(5);
remoteControl.UndoButtonPressed();