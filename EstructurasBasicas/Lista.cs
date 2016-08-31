using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasBasicas
{
    public class Lista
    {
        private int[] elements;
        private int count;

        public int Count { get { return count; } }

        public Lista(int size)
        {
            count = 0;
            elements = new int[size];
        }

        public bool InsertLast(int newElement)
        {
            if (count < elements.Length)
            {
                elements[count++] = newElement;                
                return true;
            }
            return false;
        }

        public bool InsertFirst(int newElement)
        {
            if (count == elements.Length)
                return false;

            for (int i = count; i > 0 ; i--)
            {
                elements[i] = elements[i - 1];                
            }
            count++;
            elements[0] = newElement;
            return true;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int FirstElement()
        {
            return count > 0 ? elements[0] : 0;
        }

        public int LastElement()
        {
            return count > 0 ? elements[count - 1] : 0;           
        }

    }
}
