using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;
using System;

namespace bytebank_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas vindas ao Bytebank Administração!");

            Funcionario joao = new Funcionario();
            Bonificacao bonificacao = new Bonificacao();

            joao.Nome = "João";
            joao.Cpf = "05319470777";
            joao.Salario = 2000;

            Diretor Alisson = new Diretor();
            Alisson.Nome = "Alisson Santana Barbosa";
            Alisson.Cpf = "05319470177";
            Alisson.Salario = 30000;

            bonificacao.Registrar(joao);
            Console.WriteLine("Bonificação do funcionario: " + bonificacao.GetBonificacao());

            bonificacao.Registrar(Alisson);
            Console.WriteLine("Bonificação do funcionario + Diretor: " + bonificacao.GetBonificacao());


            //Console.WriteLine(joao.Salario);
            //Console.WriteLine("Bonificação: " + joao.getBonificacao());
            //Console.WriteLine("Salario Diretor " + Alisson.Nome + ": " + Alisson.Salario);
            //Console.WriteLine( "Bonificação Diretor "+ Alisson.Nome +": "+ Alisson.getBonificacao());


        }
    }
}
