using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Generics
{
    internal class Knight
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public Knight()
        {
            Id = CreateRandomInteger(0, 1000);
            Name = CreateRandomString(8);
            Age = CreateRandomInteger(0, 100);
        }
        public static int CreateRandomInteger(int from, int to)
        {
            Random r = new Random();
            return r.Next(from, to);
        }
        public static string CreateRandomString(int length)
        {
            Random r = new Random();
            System.Text.StringBuilder str_build = new System.Text.StringBuilder();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = r.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }   
    }
}
