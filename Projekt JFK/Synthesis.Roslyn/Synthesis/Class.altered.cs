namespace Playground
{
    using System;
    using static System.Console;

    public static class Class
    {

//Typ zwracany przez metodę: string
//Parametry metody:  string s 
public static string Upper(string s)
        {
            string aux = s.ToUpper();
            return aux;
        }

//Typ zwracany przez metodę: int
//Parametry metody:  int a int b int c 
public static int metoda(int a, int b, int c)
        {
            a = 2;
            b = 3;
            c = 4;
            return a + b + c;
        }

//Typ zwracany przez metodę: int
//Parametry metody:  string s 
public static int Count(string s)
        {
            int length = s.Length;
            return length;
        }

//Typ zwracany przez metodę: void
//Parametry metody:  Brak parametrów
public static void Main()
        {
            string imie;
            imie = "Michal";
        }

//Typ zwracany przez metodę: void
//Parametry metody:  string str 
private static void Log(string str)
        {
            ConsoleColor aux = ForegroundColor;
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(str);
            ForegroundColor = aux;
        }
    }
}

