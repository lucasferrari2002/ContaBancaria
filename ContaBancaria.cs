using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace AprendizagemDotNet
{
    public class ContaBancaria
    {
        public int Numero{get; private set;}
        public string Titular{get; set;}
        public double Saldo{get; private set;}

        public ContaBancaria(int numero, string titular, double saldo){
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void Deposito(double quantia){
            Saldo += quantia;
        }
        public void Saque(double quantidade){
            Saldo -= quantidade + 5.0;
        }
        public override string ToString() {
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}