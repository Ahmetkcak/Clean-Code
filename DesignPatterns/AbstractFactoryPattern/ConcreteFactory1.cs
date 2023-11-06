public class ConcreteFactory1 : IFactory
{
    public IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}
