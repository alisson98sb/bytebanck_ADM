﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string cpf) : base(cpf, 300)
        {
            Console.WriteLine("Criando um Designer.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11; //11%
        }

        //override significa que vamos sobrescrever o metodo getbonificação na classe pai que é virtual. 
        public override double getBonificacao()
        {
            // Diretor - 17% de bonificação.
            //base: Significa que o método que estamos usando é o getBonificação de Funcionario, e não o que está declarado nesta classe Diretor;
            return Salario * 0.17;
        }

    }
}
