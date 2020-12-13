using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanoi_tower
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiTower ht = new HanoiTower();
            //string a = "Пользаватель выбрал а";
            //string b = "Пользаватель выбрал б";
            //string c = "Пользаватель выбрал ц";
            while (true)
            {
                Console.WriteLine("Введите пожалуйста букву a,b,c");
                string str = Console.ReadLine();
                if (str == "q") { break; }
                
                switch (str)
                {
                    case "a":
                        Console.WriteLine("Вы выбрали массив a,выберите b или с");
                        if (str == "b")
                        {
                            goto case "b";
                        }
                        else if (str == "c")
                        {
                            goto case "c";
                        }
                        break;
                       
                    case "b":
                        Console.WriteLine("Вы выбрали массив b");
                        ht.move(ht.a, ht.b);
                        ht.Display();
                        break;
                    case "c":
                        Console.WriteLine("Вы выбрали массив c");
                        ht.move(ht.a, ht.c);
                        ht.Display();
                        break;
                    default:
                        Console.WriteLine("Невозможно выполнить операцию");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
