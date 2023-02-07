using Command.RemoteLoader.Command;
using Command.RemoteLoader.Command.CommandObjects;
using Command.RemoteLoader.Command.Commands.CeilingFan;
using Command.RemoteLoader.Command.Commands.GarageDoor;
using Command.RemoteLoader.Command.Commands.Light;
using Command.RemoteLoader.Command.Commands.Stereo;
using Command.RemoteLoader.Remote;

ICommand[] onCommands = new ICommand[7];
ICommand[] offCommands = new ICommand[7];

RemoteControl remoteControl = new RemoteControl(onCommands,offCommands);

// living room lights
Light livingRoomLight = new Light();
{
    LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight, "living room");
    LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight, "living room");

    remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
}

// garage door
GarageDoor garageDoor = new GarageDoor();
{
    GarageDoorOnCommand garageDoorOn = new GarageDoorOnCommand(garageDoor);
    GarageDoorOffCommand garageDoorOff = new GarageDoorOffCommand(garageDoor);
    remoteControl.SetCommand(1, garageDoorOn, garageDoorOff);
}

// garage door
Stereo stereo = new Stereo();
{
    StereoOnWithCDCommand stereoOnWithCd = new StereoOnWithCDCommand(stereo);
    StereoOffWithCDCommand stereoOffWithCd = new StereoOffWithCDCommand(stereo);
    
    remoteControl.SetCommand(2,stereoOnWithCd,stereoOffWithCd);
}

// ceiling fan
CeilingFan ceilingFanLivingRoom = new CeilingFan("living room");
{
    CeilingFanOffCommand livingRoomCeilingFanOff = new CeilingFanOffCommand(ceilingFanLivingRoom, "living room");
    CeilingFanLowCommand livingRoomCeilingFanLow = new CeilingFanLowCommand(ceilingFanLivingRoom, "living room");
    CeilingFanMediumCommand livingRoomCeilingFanMedium = new CeilingFanMediumCommand(ceilingFanLivingRoom, "living room");
    CeilingFanHighCommand livingRoomCeilingFanHigh = new CeilingFanHighCommand(ceilingFanLivingRoom, "living room");
    
    remoteControl.SetCommand(3,livingRoomCeilingFanLow,livingRoomCeilingFanOff);
    remoteControl.SetCommand(4,livingRoomCeilingFanMedium,livingRoomCeilingFanOff);
    remoteControl.SetCommand(5,livingRoomCeilingFanHigh,livingRoomCeilingFanOff);
}


Console.WriteLine(remoteControl.ReturnCommands());




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