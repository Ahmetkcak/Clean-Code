using System;

abstract class CookingTemplate
{
    public void Cook()
    {
        PrepareIngredients();
        CookIngredients();
        ServeDish();
    }

    public abstract void PrepareIngredients();

    public abstract void CookIngredients();
    public void ServeDish()
    {
        Console.WriteLine("Dish is served!");
    }
}

class SpaghettiBolognese : CookingTemplate
{
    public override void PrepareIngredients()
    {
        Console.WriteLine("Preparing spaghetti and bolognese sauce...");
    }

    public override void CookIngredients()
    {
        Console.WriteLine("Boiling spaghetti and cooking bolognese sauce...");
    }
}

class FriedRice : CookingTemplate
{
    public override void PrepareIngredients()
    {
        Console.WriteLine("Preparing rice and vegetables...");
    }

    public override void CookIngredients()
    {
        Console.WriteLine("Frying rice and vegetables...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CookingTemplate spaghetti = new SpaghettiBolognese();
        spaghetti.Cook();

        CookingTemplate friedRice = new FriedRice();
        friedRice.Cook();
    }
}
