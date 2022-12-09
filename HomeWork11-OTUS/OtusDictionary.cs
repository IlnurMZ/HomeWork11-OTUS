using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_OTUS
{
    internal class OtusDictionary
    {
        int Size { get; set; } = 32;        
        PairKeyValue[] array = new PairKeyValue[32];

        public string this[int i]
        {
            get 
            {
                if (array[i] != null)
                {
                    return array[i].Value;
                }
                else
                {
                    throw new Exception("Такого элемента не существует");
                }                
            }
            set 
            {
                if (array[i] != null)
                {
                    array[i].Value = value;
                }
                else
                {
                    throw new Exception("Такого элемента не существует");
                }               
            }
        }

        public void Add(int key, string value)
        {
            if (value == null || key < 0)
            {
                throw new Exception("Вы попытались добавить null в качестве значения");
            }

            if (key < 0 )
            {
                throw new Exception("Индекс меньше нуля");
            }

            PairKeyValue pair = new PairKeyValue(key, value);
            int position = key % Size;

            if (array[position] == null)
            {
                array[position] = pair;
            }
            else 
            {
                if (array[position].Key == key)
                {
                    throw new Exception("В OtusDictionary уже есть такой ключ");
                }
                else
                {
                    ResizeOtusDictionary(pair);
                }               
            }            
        }

        private void ResizeOtusDictionary(PairKeyValue pair)
        {
            Size *= 2;
            PairKeyValue[] array2 = new PairKeyValue[Size];
            int position;

            foreach (var item in array)
            {
                if (item == null)
                {
                    continue;
                }
                position = item.Key % Size;
                array2[position] = item;
            }

            position = pair.Key % Size;
            array2[position] = pair;
            array = array2;
        }

        public string Get(int key)
        {
            int position = key % Size;

            if (array[position] == null)
            {
                throw new Exception("Такого элемента не существует");
            }

            return array[position].Value;
        }
    }
}
