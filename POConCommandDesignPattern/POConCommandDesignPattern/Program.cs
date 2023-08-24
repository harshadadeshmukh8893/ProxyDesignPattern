
using POConCommandDesignPattern.Model;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create a receiver
        Light livingRoomLight = new Light();

        // Create concrete command objects
        ICommand turnOnCommand = new TurnOnLightCommand(livingRoomLight);
        ICommand turnOffCommand = new TurnOffLightCommand(livingRoomLight);

        // Create an invoker
        RemoteControl remote = new RemoteControl();

        // Associate commands with the invoker
        remote.SetCommand(turnOnCommand);

        // Press the button
        remote.PressButton(); // Output: Light is on

        // Change the command associated with the invoker
        remote.SetCommand(turnOffCommand);

        // Press the button again
        remote.PressButton(); // Output: Light is off
    }
}


