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
        public int index;
        public int value;
        public Index(int size, int index, int value)
        {
            this.size = size;
            arr = new int[size];
            this.index = index;
            this.value = value;
            IndexMethod(index, value);
        }

        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }

        public void IndexMethod(int index, int value)
        {
            if (index < arr.Length)
            {
                for (int i = index; i < arr.Length; i++)
                {
                    if (index < arr.Length)

                        arr[i] = value * value;

                }
            }
            else
            {
                throw new CustomException("Значение Index не может быть больше границ массива",
                    "Введите значение Index<arr.Length");
            }
        }

    }
}
