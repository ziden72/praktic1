using System;

namespace KMV_PRACTIKA_1
{
    public class lib1
    {
        public static void strow(string a, int b)
        {
            string a1 = "";
            for (int i = 0; i < b; i++)
            {
                a1 = a1 + a;
            }
            Console.WriteLine("2)" + a1);
        }
        public static void rev(string a)
        {
            string a2 = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                a2 = a2 + a[i];
            }
            Console.WriteLine("3)" + a2);
            Console.WriteLine("4)" + a2);
        }
        public static void remove(string a, char a3)
        {
            string a4 = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a3)
                {
                    a4 = a4 + a[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("5)" + a4);
        }
        public static void leng(string a)
        {
            Console.WriteLine("6)" + a.Length);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2) Введите строку");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("2) Введите количество повторений строки");
            int b = Convert.ToInt32(Console.ReadLine());
            lib1.strow(a, b);
            Console.WriteLine("3) Введите строку");
            a = Convert.ToString(Console.ReadLine());
            lib1.rev(a);
            Console.WriteLine("5) Введите строку");
            a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("5) Введите подстроку для удаления");
            char a3 = Convert.ToChar(Console.ReadLine());
            lib1.remove(a, a3);
            Console.WriteLine("6)Введите строку");
            a = Convert.ToString(Console.ReadLine());
            lib1.leng(a);
        }
    }
}