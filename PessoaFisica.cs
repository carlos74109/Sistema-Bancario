using System;

namespace AplicativoBancario.Models
{
    internal class PessoaFisica : Pessoa, IDepositar
    {

        public PessoaFisica(String nome, int idade, double contaBancaria)
        {
            this.nome = nome;
            this.idade = idade;
            this.contaBancaria = contaBancaria;
        }

        public void depositar(double deposito)
        {
            if (deposito < 0)
            {
                Console.WriteLine("Adicione um valor valido!!!");
                return;
            }
            else
            {
                contaBancaria += deposito;
                var escrita = "Seu saldo atual: " + contaBancaria;
                Console.WriteLine(escrita);
            }
        }
        public void sacar(double sacar)
        {
            if (sacar < 0 || sacar > contaBancaria)
            {
                Console.WriteLine("Por favor, digite um saldo valido");
                return;
            }
            else
            {
                contaBancaria -= sacar;
                var escrita = "Seu novo saldo atual é: "+ contaBancaria;
                Console.WriteLine(escrita);
            }
        }

        public double impostoRenda()
        {
            return Math.Round(contaBancaria * 0.08, 2);
        }


        public double calculoPoupancaAnual()
        {
            return Math.Round(contaBancaria * 0.06167 , 2);
        }

        public double calculoPoupancaDia()
        {
            return Math.Round(contaBancaria * 0.0022, 2);
        }
    }
}
