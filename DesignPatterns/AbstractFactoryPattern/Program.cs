
IFactory factory1 = new ConcreteFactory1();
IProduct product1 = factory1.CreateProduct();
product1.Create();

IFactory factory2 = new ConcreteFactory2();
IProduct product2 = factory2.CreateProduct();
product2.Create();