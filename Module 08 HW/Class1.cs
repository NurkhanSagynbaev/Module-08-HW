using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_HW
{
    class SquaredArray
    {
        private int[] array;

        public SquaredArray(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                array[index] = value * value;
            }
        }

        SquaredArray squaredArray = new SquaredArray(5);
        squaredArray[2] = 3;
int value = squaredArray[2]; }
}


