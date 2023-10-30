using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Work8
{
    public class CustomException : Exception
    {
        public string CustomProperty { get; } // Пример пользовательского свойства

        public CustomException(string message, string customProperty) : base(message)
        {
            CustomProperty = customProperty; // Инициализация пользовательского свойства
        }

    }
}
