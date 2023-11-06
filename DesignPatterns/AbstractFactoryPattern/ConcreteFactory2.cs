
internal class ConcreteFactory2:IFactory
{
    public IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}
