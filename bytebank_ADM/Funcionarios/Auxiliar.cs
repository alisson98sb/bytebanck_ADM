using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando um Auxiliar.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10; //10%
        }

        //override significa que vamos sobrescrever o metodo getbonificação na classe pai que é virtual. 
        public override double getBonificacao()
        {
            // Auxiliar - 20% de bonificação.
            //base: Significa que o método que estamos usando é o getBonificação de Funcionario, e não o que está declarado nesta classe Diretor;
            return Salario * 0.2;
        }

    }
}
