namespace Home.WorkWithInterfaces10
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Пример использования SimpleCalculator
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            double sum = simpleCalculator.Add(5, 3);
            simpleCalculator.DisplayResult(sum);

            // Пример использования AdvancedCalculator
            AdvancedCalculator advancedCalculator = new AdvancedCalculator();
            double powerResult = advancedCalculator.Power(2, 3);
            advancedCalculator.DisplayResult(powerResult);

            double squareRootResult = advancedCalculator.SquareRoot(9);
            advancedCalculator.DisplayResult(squareRootResult);

            // Пример использования IStorable
            advancedCalculator.SaveToFile("calculator_state.txt");
            advancedCalculator.LoadFromFile("calculator_state.txt");
        }
    }
}