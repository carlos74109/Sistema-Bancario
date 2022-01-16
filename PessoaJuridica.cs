using System;

namespace AplicativoBancario.Models
{
    internal class PessoaJuridica : Pessoa, IDepositar
    {
        private const string textoSaldoAtual = "seu saldo atual é: ";

        public PessoaJuridica(String nome, int idade, double contaBancaria)
        {
            this.nome = nome;
            this.idade = idade;
            this.contaBancaria = contaBancaria;
        }

        public void depositar(double deposito)
        {
           if(deposito < 0)
            {
                Console.WriteLine("Adicione um valor valido!!!");
                return;
            }else
            {
                contaBancaria += deposito;
                var escrita = "seu saldo atual é após o deposito  " + contaBancaria;
                Console.WriteLine(escrita);
            }
        }

        public void sacar(double sacar)
        {
            if(sacar < 0 || sacar > contaBancaria)
            {
                Console.WriteLine("Por favor, digite um saldo valido");
                return;
            }else
            {
                contaBancaria -= sacar;
                var escrita = "seu saldo atual após o saque  " + contaBancaria;
                Console.WriteLine(escrita);
            }
           
        }

        public double impostoRenda() {
               return Math.Round(contaBancaria * 0.15, 2);
        }
    }
}
