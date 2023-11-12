using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Home.WorkWithInterfaces10
{
    public class AdvancedCalculator : SimpleCalculator, IStorable
    {
        public double Power(double x, double exponent) => Math.Pow(x, exponent);

        public double SquareRoot(double x) => Math.Sqrt(x);

        private CalculatorState currentState;

        public AdvancedCalculator()
        {
            currentState = new CalculatorState();
        }

        public double LastResult
        {
            get { return currentState.LastResult; }
            set { currentState.LastResult = value; }
        }

        public void SaveToFile(string fileName)
        {
            try
            {
                // Используем StreamWriter для записи значения LastResult в файл
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(LastResult);
                    writer.Flush(); // Фиксация данных в файле
                }

                Console.WriteLine($"Saved to file: {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
            }
        }

        public void LoadFromFile(string fileName)
        {
            try
            {
                // Используем StreamReader для считывания значения LastResult из файла
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string resultString = reader.ReadLine();
                    if (double.TryParse(resultString, out double result))
                    {
                        LastResult = result;
                        Console.WriteLine($"Loaded from file: {fileName}");
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing result from file.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from file: {ex.Message}");
            }
        }

    }
}
