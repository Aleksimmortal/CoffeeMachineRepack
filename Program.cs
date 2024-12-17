using CoffeeMachineRepack.TypesCoffee;

namespace CoffeeMachineRepack
{
    public class Program
    {
        public static void Main(string[] arhs)
        {
            string action = null;
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "Welcome, Добрый день, введите цифру от 1 до 4 чтобы выбрать следующие виды кофе: 1 - Чёрный, 2 - Американо, 3 - Рафф, 4 - Эспрессо!");
                var coffeeMachine = new CoffeeMachine();
                var input = Convert.ToInt32(Console.ReadLine());
                var typecoffee = (CoffeeEnum)input;
                switch (typecoffee)
                {
                    case CoffeeEnum.Black:
                        var black = coffeeMachine.MakeCoffee(new Black(), 2);
                        break;
                    case CoffeeEnum.Americano:
                        var americano = coffeeMachine.MakeCoffee(new Americano(), 1);
                        break;
                    case CoffeeEnum.Raff:
                        var raff = coffeeMachine.MakeCoffee(new Raff(), 3);
                        break;
                    case CoffeeEnum.Espresso:
                        var espresso = coffeeMachine.MakeCoffee(new Espresso(), 2);
                        break;

                    default:
                        Console.WriteLine("Такого кофе не существует");
                        break;
                }

                Console.WriteLine("Чтобы выйти введите exit");
                action = Console.ReadLine();
            } while (action != "exit");
        }
    }
}
