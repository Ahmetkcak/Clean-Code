
using System;

// State arayüzü
public interface IState
{
    void Handle(Context context);
}

// Context sınıfı
public class Context


{
    private IState state;

    public Context(IState state)
    {
        this.state = state;
    }

    public void Request()
    {
        state.Handle(this);
    }

    public IState State
    {
        get { return state; }
        set { state = value; }
    }
}

// ConcreteState sınıfları
public class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateA sınıfı çalışıyor.");
        context.State = new ConcreteStateB();
    }
}

public class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateB sınıfı çalışıyor.");
        context.State = new ConcreteStateA();
    }
}

// public class Program
// {
//     public static void Main()
//     {
//         Context context = new Context(new ConcreteStateA());

//         // her 3 saniyede bir istek at
//         for (int i = 0; i < 10; i++)
//         {
//             context.Request();
//             System.Threading.Thread.Sleep(3000);
//         }

//     }
// }
