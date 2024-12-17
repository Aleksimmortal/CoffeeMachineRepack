namespace CoffeeMachineRepack.TypesCoffee;

public class Espresso : Coffee
{
    public override Espresso Make(int countOfSugar)
    {
        CountofSugar = countOfSugar;
        Console.WriteLine("Make Espresso");
        return new Espresso();
    }
}