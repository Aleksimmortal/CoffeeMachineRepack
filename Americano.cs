namespace CoffeeMachineRepack.TypesCoffee;

public class Americano : Coffee
{
    public override Americano Make(int countOfSugar)
    {
        CountofSugar = countOfSugar;
        Console.WriteLine("Make Americano");
        return new Americano();
    }
}