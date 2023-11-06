

class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Cheese pizza baked"); 
    }

    public void Cut()
    {
        Console.WriteLine("Cheese pizza cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Cheese pizza prepared");
    }
}
