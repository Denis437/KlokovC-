using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intarray = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 4, 3, 2, 1 },
                new int[] { 3, 2, 6, 1 }
            };
            JaggedArrayInfo info = new JaggedArrayInfo(intarray);
            Console.WriteLine(info.Lowers);//вывести кол-во строк по убыванию
            Console.WriteLine(info.Uppers);//вывести кол-во строк по возрастанию
            Console.WriteLine(info.Ravnie);//вывести кол-во строк равных
            Console.WriteLine(info.Lost);//вывести кол-во строк не отсортированных

            Console.Read();
        }
    }
    class JaggedArrayInfo
    {
        public int Ravnie { get; private set; }
        public int Uppers { get; private set; }
        public int Lowers { get; private set; }
        public int Lost { get; private set; }
        public JaggedArrayInfo(int[][] intarray)
        {
            Uppers = UpperStrings(intarray);
            Ravnie = RavnieStrings(intarray);
            Lowers = LowerStrings(intarray);
            Lost = intarray.Length - Uppers - Ravnie - Lowers;
        }


        int UpperStrings(int[][] intarray)
        {
            int result = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                bool status = true;
                for (int i2 = 1; i2 < intarray[i].Length; i2++)
                {

                    if (intarray[i][i2] > intarray[i][i2 - 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    result++;
            }
            return result;
        }
        int LowerStrings(int[][] intarray)
        {
            int result = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                bool status = true;
                for (int i2 = 1; i2 < intarray[i].Length; i2++)
                {
                    if (intarray[i][i2] < intarray[i][i2 - 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    result++;
            }
            return result;
        }
        int RavnieStrings(int[][] intarray)
        {
            int result = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                bool status = true;
                for (int i2 = 1; i2 < intarray[i].Length; i2++)
                {
                    if (intarray[i][i2] != intarray[i][i2 - 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    result++;
            }
            return result;
        }
    }
}
