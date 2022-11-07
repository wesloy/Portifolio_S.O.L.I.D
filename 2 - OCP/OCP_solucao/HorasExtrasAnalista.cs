namespace Contabilidade
{
    public class HorasExtrasAnalista : IHorasExtras
    {
        public void CalcularHorasExtras(int qtdeTotalHoras)
        {
            var valorHoras = qtdeTotalHoras * 40;
            Console.WriteLine("Valor das horas são: " + valorHoras);
        }
    }
}
