using bytebank_ADM.Funcionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15; //15%
        }

        //override significa que vamos sobrescrever o metodo getbonificação na classe pai que é virtual. 
        public override double getBonificacao()
        {
            // Diretor - 100% de bonificação.
            //base: Significa que o método que estamos usando é o getBonificação de Funcionario, e não o que está declarado nesta classe Diretor;
            return Salario * 0.5;
        }

    }
}
