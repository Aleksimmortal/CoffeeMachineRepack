namespace CoffeeMachineRepack.TypesCoffee;

public class Raff : Coffee
{
    public override Raff Make(int countOfSugar)
    {
        CountofSugar = countOfSugar;
        Console.WriteLine("Make Raff");
        return new Raff();
    }
}