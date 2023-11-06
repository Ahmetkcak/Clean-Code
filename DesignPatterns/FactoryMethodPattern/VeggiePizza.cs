

class VeggiePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Veggie Pizza baked");
    }

    public void Cut()
    {
        Console.WriteLine("Veggie Pizza cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Veggie Pizza prepared");
    }
}
