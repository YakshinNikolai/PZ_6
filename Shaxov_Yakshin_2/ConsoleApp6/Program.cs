using System;
namespace std;
class Program
{
    static void Main()
    {
        string str;
        str = "ФИО: {{ {0} }}, Возраст: {{ {1} }}, Дата рождения {{ {2} }}, Место рождения: {{ {3} }}";
        str = String.Format(str, "Шахов С.Ю.", 18, "06.01.2006", "г.Курск");
        string str1;
        str1 = "ФИО: {{ {0} }}, Возраст: {{ {1} }}, Дата рождения {{ {2} }}, Место рождения: {{ {3} }}";
        str1 = String.Format(str1, "Якшин Н.Н.", 17, "31.05.2007", "г.Курск");
        Console.WriteLine(str);
        Console.WriteLine(str1);
    }
}