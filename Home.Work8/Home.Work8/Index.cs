using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*Создать индексатор, для одномерного массива, который при установке 
    значения будет возводить в квадрат передаваемое значение переменной и 
    устанавливать его для указанного индекса. При получении элемента массива по
    индексу будет возвращаться его текущее значение.*/

namespace Home.Work8
{
    public class Index
    {
        public int[] arr;
        public int size;

        public Index(int size)
        {
            this.size = size;
            arr = new int[size];

        }

        public int this[int index]
        {
            set
            {
                if (index < arr.Length)
                    arr[index] = value * value;
                else
                    throw new CustomException("Вы вышли за границы массива!",$"Введите число меньше чем {arr.Length}");
            }

            get
            {
                if (index < arr.Length)
                    return arr[index];
                else
                    throw new CustomException("Вы вышли за границы массива!", $"Введите число меньше чем {arr.Length}");
            }
        }

    }
}
