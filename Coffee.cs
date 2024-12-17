namespace CoffeeMachineRepack.TypesCoffee;

public class Coffee
{
    public int CountofSugar { get; set; }
    public virtual Coffee Make(int countofSugar)
    {
        Console.WriteLine("Make some coffee");
        return new Coffee();
    }
}
