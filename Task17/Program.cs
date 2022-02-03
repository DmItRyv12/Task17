using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер счета:");
            int accnum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер счета (прописью):");
            string accnum2 = Console.ReadLine();
            Console.Write("Введите баланс :");
            double balance1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Ф.И.О.:");
            string fioname1 = Console.ReadLine();
            Account<int> account1 = new Account<int>(accnum1, balance1, fioname1);
            Account<string> account2 = new Account<string>(accnum2, balance1, fioname1);
            account1.Print();
            Console.WriteLine();
            account2.Print();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T AccNumb;
        private double Balance;
        private string FiolName;
        public Account(T accnumb, double balance, string fioname)
        {
            AccNumb = accnumb;
            Balance = balance;
            FiolName = fioname;
        }
        public void Print()
        {
            Console.Write("Номер счета:{0} ", AccNumb);
            Console.Write("Баланс:{0} ", Balance);
            Console.Write("Ф.И.О.:{0} ", FiolName);
        }
    }
}
