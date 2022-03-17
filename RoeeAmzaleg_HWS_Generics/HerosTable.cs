using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Generics
{
    internal class HerosTable<T> where T : Knight
    {
        public T[] knights { get; set; }
        public T this[int index]
        {
            get
            {
                if (KnightCount() == 0)
                    return null;
                else if (index <= knights.Length - 1)
                {
                    if (knights[index] == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (knights[i] != null)
                                return knights[i];
                        }
                        return null;
                    }
                    else
                        return knights[index];
                }
                else
                {
                    int knightIndex = index % knights.Length-1;
                    return knights[knightIndex];
                }
            }
        }

        public HerosTable(int size)
        {
            knights = new T[size];
        }
        public void Set(T someKnight, int index)
        {
            knights[index] = someKnight;
        }
        public void Delete(int index)
        {
            knights[index] = null;
        }
        public int KnightCount()
        {
            int counter = 0;
            foreach (T k in knights)
            {
                if (k != null)
                    counter++;
            }
            return counter;
        }
        public T[] KnightStatus()
        {
            T[] KnightsList = new T[KnightCount()];
            foreach (T A in knights)
            {
                int index = 0;
                if (A != null)
                {
                    KnightsList[index] = A;
                    index++;
                }
            }
            return KnightsList;

        }
    }
}
