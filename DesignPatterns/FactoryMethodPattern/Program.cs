
AntalyaPizzaStore antalyaPizzaStore = new AntalyaPizzaStore();
AnkaraPizzaStore ankaraPizzaStore = new AnkaraPizzaStore();

IPizza cheesePizza = antalyaPizzaStore.OrderPizza("cheese");
IPizza veggiePizza = ankaraPizzaStore.OrderPizza("veggie");
