using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            Console.Write("Введите количество сотрудников: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Staff[] omas = new Staff[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Информация о сотруднике {i + 1}: ");
                Console.Write("Табельный номер: ");
                int tabel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Фамилия: ");
                string sername = Console.ReadLine();
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Отчество: ");
                string patronymic = Console.ReadLine();
                Console.Write("Дата рождения: ");
                DateTime birth = DateTime.Parse(Console.ReadLine());
                Console.Write("Должность: ");
                string position = Console.ReadLine();
                Console.Write("Оклад: ");
                int salary = Convert.ToInt32(Console.ReadLine());
                if (DateTime.Now < (birth.AddYears(DateTime.Now.Year - birth.Year)))
                {
                    Console.WriteLine($"Возраст: {DateTime.Now.Year - birth.Year - 1}");
                }
                else
                {
                    Console.WriteLine($"Возраст: {DateTime.Now.Year - birth.Year}");
                }
                omas[i] = new Staff(tabel, sername, name, patronymic, birth, position, salary);
            }

            Console.ReadKey();
        }
    }
}
