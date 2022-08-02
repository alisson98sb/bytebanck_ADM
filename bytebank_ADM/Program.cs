using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;
using System;

CalculaBonificacao();

void CalculaBonificacao()
{
    Bonificacao gerenciador = new Bonificacao();

    Designer pedro = new Designer("833.5565.5696-44");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("733.5565.5696-24");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("222.5565.5696-44");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("833.5565.5696-44");
    camila.Nome = "Camila";

    Desenvolvedor samya = new Desenvolvedor("055.194.551-77");
    samya.Nome = "Samya";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de bonificação: " + gerenciador.GetBonificacao() );
}

Console.ReadKey();