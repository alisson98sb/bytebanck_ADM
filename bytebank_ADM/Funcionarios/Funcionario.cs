using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Dsigner
        //private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            Cpf = cpf;
            totalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        //Virtual permite que a classe filha sobrescreva o metodo getBonificação da classe pai
        //Abstract significa que toda classe que herdar de funcionario precisa obrigatóriamente implementar o método getBonificacao. Isso é importante para o caso de esquecer de implementar na classe.
        public abstract double getBonificacao();

    }
}
