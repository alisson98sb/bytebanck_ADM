using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios.SistemaInterno
{
    public interface iAutenticavel
    {
        public bool Autenticar(string senha);
    }
}
