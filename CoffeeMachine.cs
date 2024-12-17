using CoffeeMachineRepack.TypesCoffee;

namespace CoffeeMachineRepack;

public class CoffeeMachine
{
    public Coffee MakeCoffee(Coffee coffee, int countOfSugar)
    {
        return coffee.Make(countOfSugar);
    }
}