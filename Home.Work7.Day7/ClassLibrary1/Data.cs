using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Data
    {
        public int Value { get; set; }

        public Data(int value)
        {
            Value = value;
        }

        public static bool operator ==(Data data1, Data data2)
        {
            return data1.Value == data2.Value;
        }

        public static bool operator !=(Data data1, Data data2)
        {
            return data1.Value != data2.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Data data)
            {
                return Value == data.Value;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }

}
