using bytebank_ADM.Funcionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas: Autenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um Gerente de Contas.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.5; //5%?
        }

        //override significa que vamos sobrescrever o metodo getbonificação na classe pai que é virtual. 
        public override double getBonificacao()
        {
            // GerenteDeContas - 25% de bonificação.
            //base: Significa que o método que estamos usando é o getBonificação de Funcionario, e não o que está declarado nesta classe Diretor;
            return Salario * 0.25;
        }

        //public string Senha { get; set; }

        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}


    }
}
