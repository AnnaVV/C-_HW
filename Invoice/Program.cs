using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice firstInvoice = new Invoice(39067, "SomeCustomer", "Book", 30, 100.45);
            double amountWithoutVAT;
            double amountWithVAT;

            firstInvoice.OrderAmountCalculator(out amountWithoutVAT, out amountWithVAT);

            Console.WriteLine("Your order amount is: {0} UAH without VAT, {1} UAH with VAT", amountWithoutVAT, amountWithVAT);

            Console.ReadLine();
        }
    }
}
