using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    class BankAccount<T>
    {
        public T Number {get;set;}
        public double Balance { get; set; }
        public string Owner { get; set; }       

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Введите баланс счета");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счета");
            Owner = Console.ReadLine();

        }
        public string Getinfo()
        {
            return $"Номер счета: {Number}. Баланс: {Balance}. Владелец: {Owner}";
        }


    }
}
