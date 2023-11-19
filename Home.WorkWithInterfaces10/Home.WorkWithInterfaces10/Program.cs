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

            advancedCalculator.LastResult = advancedCalculator.SquareRoot(9);

            // Пример использования IStorable
            advancedCalculator.SaveToFile("C:\\Users\\Admin\\Desktop\\SU\\Осенний семестр 2023\\C#\\Домашняя работа\\Home.WorkWithInterfaces10\\Home.WorkWithInterfaces10\\calculator_state.txt");
            advancedCalculator.LoadFromFile("C:\\Users\\Admin\\Desktop\\SU\\Осенний семестр 2023\\C#\\Домашняя работа\\Home.WorkWithInterfaces10\\Home.WorkWithInterfaces10\\calculator_state.txt");
        }
    }
}