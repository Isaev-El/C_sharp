using MyLibrary;
using MyLibrary.WordOfTanks;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Home.Work7.Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] team1 = new Tank[5];
            Tank[] team2 = new Tank[5];

            // Инициализация танков для команды 1
            team1[0] = new Tank("T-34");
            team1[1] = new Tank("KV-1");
            team1[2] = new Tank("Sherman");
            team1[3] = new Tank("Panther");
            team1[4] = new Tank("Tiger");

            // Инициализация танков для команды 2
            team2[0] = new Tank("M4 Sherman");
            team2[1] = new Tank("Panzer IV");
            team2[2] = new Tank("T-iger");
            team2[3] = new Tank("T-34-85");
            team2[4] = new Tank("IS-2");

            int[] teamScore1 = new int[5];
            int[] teamScore2 = new int[5];
            
            ArraySum array1 = new ArraySum(teamScore1);
            ArraySum array2 = new ArraySum(teamScore2);

            // Проведение 5 боев
            for (int battle = 0; battle <= 4;battle++)
            {
                Console.WriteLine($"Battle {battle+1}");

                Console.WriteLine(team1[battle].GetTankName()+" vs "+ team2[battle].GetTankName());
                Console.WriteLine();
                Console.WriteLine(team1[battle].ToString());
                Console.WriteLine();
                Console.WriteLine(team2[battle].ToString());

                Console.WriteLine();

                if (team1[battle]*team2[battle])
                {
                    array1.AddNumber(1);
                    Console.WriteLine(team1[battle].GetTankName()+" WON!");
                }
                else
                {
                    array2.AddNumber(1);
                    Console.WriteLine(team2[battle].GetTankName() + " WON!");
                }

                Thread.Sleep(700);
                Console.Clear();
            }
            
            // Определение победившей команды
            if (array1 > array2)
            {
                Console.WriteLine($"Team 1 wins the battle! Score:{array1.SumNumber()}-{array2.SumNumber()}");
            }
            else if (array2 > array1)
            {
                Console.WriteLine($"Team 2 wins the battle! Score:{array1.SumNumber()}-{array2.SumNumber()}");
            }
            else
            {
                Console.WriteLine("It's a draw! No clear winner.");
            }

            for (int i = 0; i < array1.data.Length; i++)
            {
                Console.WriteLine("Element " + i + ": " + array1.data[i]);
            }

            Console.ReadLine();


        }
    }
}