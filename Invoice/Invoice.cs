using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private string _article;
        private int _quantity;
        private double _pricePerUnit;

        public double PricePerUnit
        {
            get { return _pricePerUnit; }
            set { _pricePerUnit = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        public Invoice(int accountNumber, string customerName, string itemName, int orderedQty, double pricePerUnit)
        {
            this._account = accountNumber;
            this._customer = customerName;
            this._article = itemName;
            this._quantity = orderedQty;
            this._pricePerUnit = pricePerUnit;
        }

        public void OrderAmountCalculator(out double totalWithoutVAT, out double totalWithVAT)
        {
            totalWithoutVAT = this._quantity * this._pricePerUnit;
            double tmp = totalWithoutVAT;
            totalWithVAT = tmp * 1.2;
        }

    }
}
