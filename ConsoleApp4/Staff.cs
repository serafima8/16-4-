using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Staff
    {
        /// <summary>
        /// Создание поля Табельный номер
        /// </summary>
        private int tabel;
        /// <summary>
        /// Создание поля Фамилия
        /// </summary>
        private string sername;
        /// <summary>
        /// Создание поля Имя
        /// </summary>
        private string name;
        /// <summary>
        /// Создание поля Отчество
        /// </summary>
        private string patronymic;
        /// <summary>
        /// Создание поля Дата рождения
        /// </summary>
        private DateTime birth;
        /// <summary>
        /// Создание поля Должность
        /// </summary>
        private string position;
        /// <summary>
        /// Создание поля Оклад
        /// </summary>
        private int salary;
        /// <summary>
        /// Свойство поля Табельный номер
        /// </summary>
        public int Tabel { get { return tabel; } set { tabel = value; } }
        /// <summary>
        /// Свойство поля Фамилия
        /// </summary>
        public string Sername { get { return sername; } set { sername = value; } }
        /// <summary>
        /// Свойство поля Имя
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Свойство поля Отчество
        /// </summary>
        public string Patronymic { get { return patronymic; } set { patronymic = value; } }
        /// <summary>
        /// Свойство поля Дата рождения
        /// </summary>
        public DateTime Birth { get { return birth; } set { birth = value; } }
        /// <summary>
        /// Свойство пола Должность
        /// </summary>
        public string Position { get { return position; } set { position = value; } }
        /// <summary>
        /// Свойство поля Оклад
        /// </summary>
        public int Salary { get { return salary; } set { salary = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Staff() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="tabel">поле табельный номер</param>
        /// <param name="sername">поле фамилия</param>
        /// <param name="name">поле имя</param>
        /// <param name="patronymic">поле отчество</param>
        /// <param name="birth">поле день рождения</param>
        /// <param name="position">поле должность</param>
        /// <param name="salary">поле оклад</param>
        public Staff(int tabel, string sername, string name, string patronymic, DateTime birth, string position, int salary)
        {
            this.Tabel = tabel;
            this.Sername = sername;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Birth = birth;
            this.Position = position;
            this.Salary = salary;
        }
        /// <summary>
        /// Метод, который выводит информацию о сотрудниках
        /// </summary>
        /// <returns></returns>
        public string ShowInfo()
        {
            return $"Табельный номер: {Tabel}\nФИО: {Sername}\t {Name}\t {Patronymic}\nДата рождения: {Birth.ToShortDateString()}\nДолжность: {Position}\nОклад: {Salary}";
        }
    }
}
