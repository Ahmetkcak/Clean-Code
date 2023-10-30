using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingAbstractions;

public interface IVehicle
{
    void Go();
    void Stop();
}

public abstract class BaseVehicle : IVehicle
{
    public void Go()
    {
        Console.WriteLine("Vehcile is going ...");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle has stopped ...");
    }
}

public interface IRideable
{
    void Ride();
}

public interface IFlyable
{
    void Soar();
}

public class Car : BaseVehicle
{

}

public class Bike : BaseVehicle, IRideable
{
    public void Go()
    {
        throw new NotImplementedException();
    }

    public void Ride()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

