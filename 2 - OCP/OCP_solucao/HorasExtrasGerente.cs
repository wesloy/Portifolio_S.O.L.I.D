namespace Contabilidade
{
    public class HorasExtrasGerente : IHorasExtras
    {
        public void CalcularHorasExtras(int qtdeTotalHoras)
        {
            var valorHoras = qtdeTotalHoras * 100;
            Console.WriteLine("Valor das horas são: " + valorHoras);
        }
    }
}
