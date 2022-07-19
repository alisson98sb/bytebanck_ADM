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

            Diretor Alisson = new Diretor("05319470177", 5000);
            Funcionario joao = new Funcionario("05319470777", 2000);
            Designer Lucas = new Designer("4541564345", 3000);
            GerenteDeContas Sabrina = new GerenteDeContas("241513165", 4000);
            Auxiliar Geovana = new Auxiliar("1515313541", 2000);

            Bonificacao bonificacao = new Bonificacao();

            joao.Nome = "João";
            Console.WriteLine("Total de funcionários: "+ Funcionario.totalDeFuncionarios);

            Alisson.Nome = "Alisson Santana Barbosa";
            Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);

            Lucas.Nome = "Lusas Designer";
            Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);

            Sabrina.Nome = "Sabrina Almeida Gerente";
            Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);

            Geovana.Nome = "Geovana Auxiliar";
            Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);


            //bonificacao.Registrar(joao);
            //Console.WriteLine("Bonificação do funcionario: " + bonificacao.GetBonificacao());


            //Console.WriteLine("Antigo salário do Alisson: " + Alisson.Salario);
            //bonificacao.Registrar(Alisson);
            //Console.WriteLine("Bonificação do funcionario + Diretor: " + bonificacao.GetBonificacao());
            //Console.WriteLine("Novo salário do Alisson: " + Alisson.Salario);

            //Alisson.AumentarSalario();

            //Console.WriteLine(joao.Salario);
            //Console.WriteLine("Bonificação: " + joao.getBonificacao());
            //Console.WriteLine("Salario Diretor " + Alisson.Nome + ": " + Alisson.Salario);
            //Console.WriteLine("Bonificação Diretor " + Alisson.Nome + ": " + Alisson.getBonificacao());


        }
    }
}
