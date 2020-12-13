using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanoi_tower
{
    class HanoiTower
    {
        public int[] a = new int[5] { 4, 3, 2, 1, 3 };
        public int[] b = new int[5] { 0, 0, 0, 0, 0 };
        public int[] c = new int[5] { 0, 0, 0, 0, 0 };



        public HanoiTower()
        {

        }
        public bool move(int[] x, int[] y)
        {
            if (x[x[4]] > y[y[4]] && y[y[4]]!=0)
            {
                Console.WriteLine("Операцию выполнить невозможно");
                return false;
            }
            else
            {
                swap(ref x[x[4]], ref y[y[4]]);
                x[4]--;
                y[4]++;
                return true;
            }

        }

    
        public void Display()
        {
            ConsoleColor cc = Console.ForegroundColor;
            for (int i = 3; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(a[i] + "                     ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(b[i] + "                     ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(c[i] + "                     ");
                Console.WriteLine();
            }
            Console.WriteLine(  " "  );
        }   

        public void swap(ref int x,ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

    }
}
