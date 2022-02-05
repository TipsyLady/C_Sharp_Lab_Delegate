using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Money currency = new Money(20, "руб");
            MoneyConvertDelegate conv = null;

            Console.WriteLine(currency);
            conv += delegate (double amount)
            {
                Console.WriteLine($"{ amount} руб = { amount*0.013} дол");
                return amount;
            };

            conv += delegate (double amount)
            {
                Console.WriteLine($"{ amount} руб = { amount * 0.084} юаней");
                return amount;
            };

            conv += delegate (double amount)
            {
                Console.WriteLine($"{ amount} руб = { amount * 5.70} тенге");
                return amount;
            };

            conv += delegate (double amount)
            {
                Console.WriteLine($"{ amount} руб = { amount * 15.82} вон");
                return amount;
            };
            
            conv += (double amount) =>
            {
                Console.WriteLine($"{ amount} руб = { amount * 0.000007} в золотишке");
                return amount;
            };
            currency.Convert(conv);
        }
    }
}
