using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Random rand = new Random();
            int number1, number2, number3;
            number1 = rand.Next(100);
            number2 = rand.Next(100);
            number3 = rand.Next(100);
            Console.Write(number1 + "  ");
            Console.Write(number2 + "  ");
            Console.Write(number3);
            Console.ReadLine();
            Console.ReadLine();


            //2.Вывести на экран числа 5, 10 и 21 одно под другим.
            int num5 = 5, num10 = 10, num21 = 21;
            Console.WriteLine(num5);
            Console.WriteLine(num10);
            Console.WriteLine(num21);
            Console.ReadLine();


            //3.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            Console.Write("Vvedite santimetri: ");
            int metr;
            int santimetr = int.Parse(Console.ReadLine());
            metr = santimetr / 100;
            Console.Write("V " + santimetr + " santimetrach " + metr + " metr");
            Console.ReadLine();
            Console.ReadLine();


            //4.С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период ?
            int dni = 234, nedeli;
            nedeli = dni / 7;
            Console.WriteLine("Za 234 dnya proshlo " + nedeli + " nedeli ");
            Console.ReadLine();


            //5.Дано двузначное число. Найти: a.число десятков в нем;  b.число единиц в нем;  c.сумму его цифр; d.произведение его цифр
            Console.Write("Vvedite 2-xznachnoe chislo: ");
            int chislo = int.Parse(Console.ReadLine());
            int chislo1 = chislo % 100 / 10;
            int chislo2 = chislo % 10;
            Console.WriteLine("desyatkov= " + chislo1 + " edenic= " + chislo2);
            int summa = chislo1 + chislo2;
            int proizv = chislo1 * chislo2;
            Console.WriteLine("summa chisel= " + summa + " proizvedenie chisel= " + proizv);
            Console.ReadLine();

            //7.Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            Console.WriteLine("Vvedite radius kruga i storonu kvadrata:");
            const double PI = 3.14;
            int radius = int.Parse(Console.ReadLine());
            int storona = int.Parse(Console.ReadLine());
            var ploshadKruga = PI * Math.Pow(radius, 2);
            var ploshadKvadrata = Math.Pow(storona, 2);
            if (ploshadKruga > ploshadKvadrata)
            { Console.WriteLine("Ploshad kruga bolshe; Ploshad kruga= " + ploshadKruga); }
            else
            { Console.WriteLine("Ploshad kvadrata bolshe; Ploshad kruga= " + ploshadKvadrata); }
            Console.ReadLine();


            //8.Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность ?
            Console.WriteLine("Введите массы тел:");
            int massa1 = int.Parse(Console.ReadLine());
            int massa2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объемы тел:");
            int obem1 = int.Parse(Console.ReadLine());
            int obem2 = int.Parse(Console.ReadLine());
            int plotnost1 = massa1 / obem1;
            int plotnost2 = massa2 / obem2;
            if (plotnost1 > plotnost2)
            { Console.WriteLine("PLotnost 1 tela bolshe; PLotnost 1 tela=" + plotnost1); }
            else
            { Console.WriteLine("PLotnost 2 tela bolshe; PLotnost 2 tela=" + plotnost2); }
            Console.ReadLine();


            //9.Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
            Console.WriteLine("Vvedite soprotivlenie i napryazhenie 1 cepi:");
            int sopr1 = int.Parse(Console.ReadLine());
            int napr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite soprotivlenie i napryazhenie 2 cepi:");
            int sopr2 = int.Parse(Console.ReadLine());
            int napr2 = int.Parse(Console.ReadLine());
            int menTok1 = napr1 / sopr1;
            int menTok2 = napr2 / sopr2;
            if (menTok1 > menTok2)
            { Console.WriteLine("Sila toka menshe v 1 cepi; Sila toka=" + menTok1); }
            else
            { Console.WriteLine("Sila toka menshe vo 2 cepi; Sila toka=" + menTok2); }
            Console.ReadLine();
        }
    }
}
