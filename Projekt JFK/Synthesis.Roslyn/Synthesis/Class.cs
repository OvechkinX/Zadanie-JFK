namespace Playground
{
    using System;
    using static System.Console;

    public static class Class
    {
        public static string Upper(string s)
        {
            string aux = s.ToUpper();
            return aux;
        }

        public static int metoda(int a, int b, int c)
        {
            a = 2;
            b = 3;
            c = 4;
            return a + b + c;
        }

        public static int Count(string s)
        {
            int length = s.Length;
            return length;
        }

        public static void Main()
        {
            string imie;
            imie = "Michal";
        }

        private static void Log(string str)
        {
            ConsoleColor aux = ForegroundColor;
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(str);
            ForegroundColor = aux;
        }
    }
}

