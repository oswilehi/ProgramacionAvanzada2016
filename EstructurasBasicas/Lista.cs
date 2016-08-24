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

        public void Initialize(int size)
        {
            count = 0;
            elements = new int[size];
        }

        public bool InsertLast(int newElement)
        {
            if (count < elements.Length)
            {
                elements[count] = newElement;
                count++;
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
            if (count > 0)
                return elements[0];
            return 0;
        }

        public int LastElement()
        {
            if (count > 0)
                return elements[count - 1];
            else
                return 0;

        }

    }
}
