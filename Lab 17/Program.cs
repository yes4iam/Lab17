using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> acc1 = new BankAccount<int>();
            BankAccount<string> acc2 = new BankAccount<string>();
            acc1.Input();
            Console.WriteLine(acc1.Getinfo());
            acc2.Input();
            Console.WriteLine(acc2.Getinfo());
            Console.ReadKey();

        }
    }
}
