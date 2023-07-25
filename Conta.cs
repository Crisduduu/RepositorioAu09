using System;
using System.Collections.Generic;

namespace SolucaoExercicio01.Classes
{
    public abstract class Conta
    {
        public int Agencia { get; private set; }
        public int Numero { get; private set; }
        public Cliente Correntista { get; set; }
        public double Saldo { get; private set; }
        public static int QuantidadeConta { get; set; }

        public Conta(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }
        public virtual void Sacar(double valor)
        {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo Insuficiente");
            }

            if (valor < 0) {
                throw new ArgumentException("Não pode efetuar saque de valor negativo");
            }
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {

            if (valor < 0) {
                throw new ArgumentException("Não pode efetuar deposito de valor negativo");
            }
            Saldo += valor;
        }

        public override bool Equals(object obj)
        {
            if (obj is Conta) 
            {
                Conta conta = (Conta) obj;
                return (conta.Agencia == Agencia) && (conta.Numero == Numero);
            }
            return false;
        }
    }
}