using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ArraySum
    {
        private int[] data;

        public ArraySum(params int[] values)
        {
            data = values;
        }

        public void AddNumber(int i)
        {
            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] == 0) // Проверка, что элемент равен 0 (пустой)
                {
                    data[index] = i; // Добавление элемента
                    break; // Выходим из цикла после добавления
                }
            }
        }

        public static bool operator <(ArraySum array1, ArraySum array2)
        {
            return array1.data.Sum() < array2.data.Sum();
        }

        public static bool operator >(ArraySum array1, ArraySum array2)
        {
            return array1.data.Sum() > array2.data.Sum();
        }

    }

}
