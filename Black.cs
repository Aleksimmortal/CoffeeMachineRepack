namespace CoffeeMachineRepack.TypesCoffee;

public class Black : Coffee
{
    public override Black Make(int countOfSugar)
    {
        CountofSugar = countOfSugar;
        Console.WriteLine("Make Black");
        return new Black();
    }
}