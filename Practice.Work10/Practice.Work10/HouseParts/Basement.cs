﻿using Practice.Work10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work10.HouseParts
{
    internal class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Фундамент построен");
        }
    }
}
