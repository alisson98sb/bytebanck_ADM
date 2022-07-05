using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class Bonificacao
    {
        public double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.getBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            totalBonificacao += diretor.getBonificacao();
        }

        public double GetBonificacao()
        {
            return totalBonificacao;
        }
    }
}
