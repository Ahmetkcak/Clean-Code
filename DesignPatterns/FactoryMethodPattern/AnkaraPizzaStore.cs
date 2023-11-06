

class AnkaraPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggie" => new VeggiePizza(),
            _ => throw new ArgumentException("Invalid pizza type",nameof(type)),
        };
    }
}
