using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_OTUS
{
    internal class PairKeyValue
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public PairKeyValue(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
