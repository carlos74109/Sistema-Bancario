using System;
using AplicativoBancario.Models;

namespace AplicativoBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Selecione 1 para pessoa Juridica");
            Console.WriteLine("Selecione 2 para pessoa Fisica");
            String selecionarPessoa = Console.ReadLine();

            if (selecionarPessoa == "1")
            {
                Console.WriteLine("Digite seu nome: ");
                String nomePessoaJuridica = Console.ReadLine();
                Console.WriteLine("Digite sua idade: ");
                int idadeNomePessoaJuridica = Int32.Parse(Console.ReadLine());

                if (idadeNomePessoaJuridica < 18)
                {
                    Console.WriteLine("Lamento " + nomePessoaJuridica + " mas voce é de menor");
                    return;
                }

                Console.WriteLine("Digite o seu saldo atual");
                double saldoPessoaJuridica = Double.Parse(Console.ReadLine());

                PessoaJuridica pessoaJ = new PessoaJuridica(nomePessoaJuridica, idadeNomePessoaJuridica, saldoPessoaJuridica);

                Console.WriteLine("Agora digite o valor do seu deposito: ");
                double valorDepositoPessoaJuridica = Double.Parse(Console.ReadLine());

                pessoaJ.depositar(valorDepositoPessoaJuridica);

                Console.WriteLine("Digite um valor que voce deseja sacar: ");
                double valorSaque = Double.Parse(Console.ReadLine());
                pessoaJ.sacar(valorSaque);

                Console.WriteLine("Deseja checar seu imposto de renda? digite sim");
                String checarImpostoRenda = Console.ReadLine();

                if (checarImpostoRenda == "sim")
                {
                    Console.WriteLine("O Valor do imposto de renda foi: " + pessoaJ.impostoRenda());
                    double saldoFinal = pessoaJ.contaBancaria - pessoaJ.impostoRenda();
                    var escrita = "Oque sobrou em sua conta bancaria foi: " + saldoFinal;
                    Console.WriteLine(escrita);
                }
                else
                {
                    Console.WriteLine("Aplicação encerrada");
                }

            } else if (selecionarPessoa == "2")
            {
                Console.WriteLine("Digite seu nome: ");
                String nomePessoaFisica = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                int idadeNomePessoaFisica = Int32.Parse(Console.ReadLine());
                if (idadeNomePessoaFisica < 18)
                {
                    Console.WriteLine("Lamento " + nomePessoaFisica + " mas voce é de menor");
                    return;
                }

                Console.WriteLine("Digite o seu saldo atual");
                double saldoPessoaFisica = Double.Parse(Console.ReadLine());

                PessoaFisica pessoaF = new PessoaFisica(nomePessoaFisica, idadeNomePessoaFisica, saldoPessoaFisica);

                Console.WriteLine("Agora digite o valor do seu deposito: ");
                double valorDepositoPessoaFisica = Double.Parse(Console.ReadLine());
                pessoaF.depositar(valorDepositoPessoaFisica);

                Console.WriteLine("Digite o valor que vc quer sacar: ");
                double valorSacarPessoaFisica = Double.Parse(Console.ReadLine());
                pessoaF.sacar(valorSacarPessoaFisica);

                String desejaContinuar = "sim";

                while (desejaContinuar == "sim") {
                    Console.WriteLine("digite 1 para checar o imposto de renda");
                    Console.WriteLine("Digite 2 para calcular seu rendimento da poupança anual: ");
                    Console.WriteLine("Digite 3 para calcular o seu rendimento de diario da poupança");
                    Console.WriteLine("Digite 4 caso queira visualizar tudo");
                    String captarEscolha = Console.ReadLine();

                    if (captarEscolha == "1")
                    {
                        Console.WriteLine("O Valor do imposto de renda foi: " + pessoaF.impostoRenda());
                    } else if (captarEscolha == "2")
                    {
                        Console.WriteLine("O valor de rendimento da sua poupança é: " + pessoaF.calculoPoupancaAnual());
                    } else if (captarEscolha == "3")
                    {
                        Console.WriteLine("O rendimento diario da poupança é: " + pessoaF.calculoPoupancaDia());
                    } else if (captarEscolha == "4")
                    {
                        Console.WriteLine("O Valor do imposto de renda foi: " + pessoaF.impostoRenda());
                        Console.WriteLine("Ovalor de rendimento da sua poupança é: " + pessoaF.calculoPoupancaAnual());
                        Console.WriteLine("O rendimento diario da poupança é: " + pessoaF.calculoPoupancaDia());
                    }

                    Console.WriteLine("Deseja visualizar os dados novamente?");
                    desejaContinuar = Console.ReadLine();

                }
            }
            else
            {
                Console.WriteLine("Digite um valor valido");
            }

           
        }

        

        
    }
}
