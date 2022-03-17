using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            HerosTable<Knight> ht = new HerosTable<Knight>(4);
            Knight k1 = new Knight();
            Knight k2 = new Knight();
            ht.Set(k1, 0);
            ht.Set(k2, 1);
            Knight k3 = ht[10];

            HerosTable<Sword> ht1 = new HerosTable<Sword>(4);
            Sword s1 = new Sword();
            Sword s2 = new Sword();
            ht1.Set(s1, 0);
            ht1.Set(s2, 1);
            Sword s3 = ht1[10];
        }

    }


}