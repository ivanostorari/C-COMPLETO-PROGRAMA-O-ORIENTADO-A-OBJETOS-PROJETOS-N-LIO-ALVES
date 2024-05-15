﻿using System;
using System.Globalization;

namespace Aula17
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double _saldo;
        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
    }
}