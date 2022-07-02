using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio_classe
{
    public class Pessoas
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string LocalNascimento { get; set; }
        public Pessoas (string cpf, string nome, string dataNascimento, string nomePai, string nomeMae, string localNascimento)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.NomePai = nomePai;
            this.NomeMae = nomeMae;
            this.LocalNascimento = localNascimento;
        }
        public Pessoas() { }
    }

    class Program
    {
        public static string cpf { get; private set; }

        static void Main(string[] args)
        {
            List<Pessoas> pessoa = new List<Pessoas>();
           

            Operacao operacao;
            Console.WriteLine("Informe a opcao desejada");
            Console.WriteLine("0 - Cadastrar");
            Console.WriteLine("1 - Atualizar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Sair");
            operacao = (Operacao)Convert.ToInt32(Console.ReadLine());

            while (operacao != Operacao.Sair)
            {
                if (operacao == Operacao.Cadastrar)
                {
                    string nome = Console.ReadLine();
                    string cpf = Console.ReadLine();
                    string dataNascimento = Console.ReadLine();
                    string nomePai = Console.ReadLine();
                    string nomeMae = Console.ReadLine();
                    string localNascimento = Console.ReadLine();
                    var Pessoa = new Pessoas(cpf, nome, nomePai, nomeMae, dataNascimento, localNascimento);
                    pessoa.Add(Pessoa);
                }
                if (operacao == Operacao.Atualizar)
                {
                    string cpf;
                    Pessoas pessoas = null;
                    Console.WriteLine("Qual o CPF");
                    cpf = Console.ReadLine();

                    for (int i = 0; i < pessoa.Count; i++)
                    {
                        if (pessoa[i].CPF == cpf)
                        {
                            pessoas = pessoa[i];
                        }
                    }
                    if (pessoas != null)
                    {
                        string nome = Console.ReadLine();
                        string Cpf = Console.ReadLine();
                        string dataNascimento = Console.ReadLine();
                        string nomePai = Console.ReadLine();
                        string nomeMae = Console.ReadLine();
                        string localNascimento = Console.ReadLine();
                        var Pessoa = new Pessoas(cpf, nome, nomePai, nomeMae, dataNascimento, localNascimento);
                        pessoa.Add(Pessoa);
                    }
                }
                if (operacao == Operacao.Remover)
                {
                    
                }
            }
        }
    }
    enum Operacao
    {
        Cadastrar,
        Atualizar,
        Remover,
        Sair

    }
}
