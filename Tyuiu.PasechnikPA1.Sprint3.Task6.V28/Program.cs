using Tyuiu.PasechnikPA1.Sprint3.Task6.V28.Lib;
namespace Tyuiu.PasechnikPA1.Sprint3.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Пасечник П. А. | АСОиУБ-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                               *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #10                                                                *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-24-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу используя цикл foreach, которая удаляет символ из строк *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int startValue = 13;
            int stopValue = 19;

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Результат: " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
