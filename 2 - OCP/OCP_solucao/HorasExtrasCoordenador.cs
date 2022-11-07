namespace Contabilidade
{
    public class HorasExtrasCoordenador : IHorasExtras
    {
        public void CalcularHorasExtras(int qtdeTotalHoras)
        {
            var valorHoras = qtdeTotalHoras * 80;
            Console.WriteLine("Valor das horas são: " + valorHoras);
        }
    }
}
