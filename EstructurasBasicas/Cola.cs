using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasBasicas
{
    public class Cola
    {
        private int[] elements;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Cola(int size)
        {
            count = 0;
            elements = new int[size];
        }

        public bool Queue(int newElement)
        {
            if (count < elements.Length)
            {
                elements[count++] = newElement;                
                return true;
            }
            return false;
        }

        public int Dequeue()
        {            
            int t = elements[0];

            for (int i = 0; i < count - 1; i++)
            {
                elements[i] = elements[i + 1];
                elements[i + 1] = 0;
            }
            count--;
            return t;

        }
    }
}
