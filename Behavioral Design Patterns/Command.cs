
// Receiver
class TV
{
    public void TurnOn()
    {
        Console.WriteLine("TV is turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is turned off");
    }
}

// Command
interface ICommand
{
    void Execute();
}

// Concrete Command
class TurnOnCommand : ICommand
{
    private readonly TV _tv;

    public TurnOnCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.TurnOn();
    }
}

// Concrete Command
class TurnOffCommand : ICommand
{
    private readonly TV _tv;

    public TurnOffCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.TurnOff();
    }
}

// Invoker
class RemoteControl
{
    private ICommand _onCommand;
    private ICommand _offCommand;

    public void SetOnCommand(ICommand onCommand)
    {
        _onCommand = onCommand;
    }

    public void SetOffCommand(ICommand offCommand)
    {
        _offCommand = offCommand;
    }

    public void TurnOnTV()
    {
        _onCommand.Execute();
    }

    public void TurnOffTV()
    {
        _offCommand.Execute();
    }
}

// Client
// class Program
// {
//     static void Main(string[] args)
//     {
//         TV tv = new TV();
//         ICommand turnOnCommand = new TurnOnCommand(tv);
//         ICommand turnOffCommand = new TurnOffCommand(tv);

//         RemoteControl remoteControl = new RemoteControl();
//         remoteControl.SetOnCommand(turnOnCommand);
//         remoteControl.SetOffCommand(turnOffCommand);

//         remoteControl.TurnOnTV();
//         remoteControl.TurnOffTV();
//     }
// }
