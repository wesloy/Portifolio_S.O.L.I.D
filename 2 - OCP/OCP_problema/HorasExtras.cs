// Aqui se vê que todas as vezes que se adicionar um novo cargo será necessário ALTERAR a classe.
// Dessa forma, quebra a OCP, já que se está alterando uma classe ou invés de estender..

namespace Contabilidade
{
    public enum TiposCargosEnum
    {
        Gerente,
        Coordenador,
        Analista

    }

    public class HorasExtras
    {
        public void CalculaHorasExtras(TiposCargosEnum cargos, int qtdeTotalHoras)
        {
            if (cargos == TiposCargosEnum.Gerente)
            {
                var valorHoras = qtdeTotalHoras * 100;
                Console.WriteLine("Valor das horas são: " + valorHoras);
            }
            if (cargos == TiposCargosEnum.Coordenador)
            {
                var valorHoras = qtdeTotalHoras * 80;
                Console.WriteLine("Valor das horas são: " + valorHoras);
            }
            if (cargos == TiposCargosEnum.Analista)
            {
                var valorHoras = qtdeTotalHoras * 40;
                Console.WriteLine("Valor das horas são: " + valorHoras);
            }
        }
    }

}
