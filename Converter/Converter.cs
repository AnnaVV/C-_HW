using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        private double _rateEUR;
        private double _rateUSD;
        private double _rateRUR;

        public Converter(double eur, double usd, double rur)
        {
            this._rateEUR = eur;
            this._rateUSD = usd;
            this._rateRUR = rur;
        }

        public double ConvertToEur(double amountToConvert)
        {
            return amountToConvert/_rateEUR;
        }

        public double ConvertFromEurToUah(double amountToConvert)
        {
            return amountToConvert * _rateEUR;
        }

        public double ConvertToUsd(double amountToConvert)
        {
            return amountToConvert / _rateUSD;
        }

        public double ConvertFromUsdToUah(double amountToConvert)
        {
            return amountToConvert * _rateUSD;
        }

        public double ConvertToRur(double amountToConvert)
        {
            return amountToConvert / _rateRUR;
        }

        public double ConvertFromRurToUah(double amountToConvert)
        {
            return amountToConvert * _rateRUR;
        }
    }
}
