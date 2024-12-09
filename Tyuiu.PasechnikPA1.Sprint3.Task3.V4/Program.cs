using Tyuiu.PasechnikPA1.Sprint3.Task3.V4.Lib;
namespace Tyuiu.PasechnikPA1.Sprint3.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Сафронов В. В. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУб-23-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach, удалить из строки все буквы j в строке:         *");
            Console.WriteLine("* plkjjdw cvjkl                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string value = "plkjjdw cvjkl";
            char item = 'j';

            Console.WriteLine($"* Строка: {value}                                                   *");
            Console.WriteLine($"* Буква, которую нужно удалить: {item}                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
