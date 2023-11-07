
using System;
using System.Collections.Generic;

// Subject interface
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Concrete subject class
public class WeatherStation : ISubject
{
    private List<IObserver> observers;
    private float temperature;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float temperature)
    {
        this.temperature = temperature;
        NotifyObservers();
    }
}

// Observer interface
public interface IObserver
{
    void Update(float temperature);
}

// Concrete observer classes
public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone Display: The temperature is " + temperature + " degrees Celsius.");
    }
}

public class TVDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("TV Display: The temperature is " + temperature + " degrees Celsius.");
    }
}



// Client code
// public class Client
// {
//     public static void Main()
//     {
//         WeatherStation weatherStation = new WeatherStation();
//         PhoneDisplay phoneDisplay = new PhoneDisplay();
//         TVDisplay tvDisplay = new TVDisplay();

//         weatherStation.RegisterObserver(phoneDisplay);
//         weatherStation.RegisterObserver(tvDisplay);

//         weatherStation.SetTemperature(25.0f);
//         weatherStation.SetTemperature(30.0f);

//         weatherStation.RemoveObserver(tvDisplay);

//         weatherStation.SetTemperature(35.0f);
//     }
// }
