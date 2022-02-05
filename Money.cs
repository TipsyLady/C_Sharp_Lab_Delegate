using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab
{
    public delegate double MoneyConvertDelegate(double value);
    class Money
    {
        private string CurrencyCode { get; set; }
        private double Amount { get; set; }
         public Money (double amount, string currenyCode)
        {
            Amount = amount;
            CurrencyCode = currenyCode;
        }

        public override string ToString()
        {
            return $"Баланс составляет {Amount} {CurrencyCode}";
        }

        public void Convert (MoneyConvertDelegate del)
        {
            foreach (MoneyConvertDelegate item in del.GetInvocationList())
            {
                Console.Write("Курс в пересчете составил: ");
                item(Amount);
            }
        }

    }
}
