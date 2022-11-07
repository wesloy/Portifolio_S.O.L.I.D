// Neste exemplo está obdecido o OCP, sendo que se houver cálculo de horas extras para outro cargo
// basta apenas extender da interface IHorasExtras e não se modifica as classes já implantadas

using Contabilidade;

var horasExtrasGerente = new HorasExtrasGerente(); // Esta declaração quebra o SOLID, mas isso é para outro momento
var horasExtrasCoordenador = new HorasExtrasCoordenador(); // Esta declaração quebra o SOLID, mas isso é para outro momento
var horasExtrasAnalista = new HorasExtrasAnalista(); // Esta declaração quebra o SOLID, mas isso é para outro momento


horasExtrasGerente.CalcularHorasExtras(10);
horasExtrasCoordenador.CalcularHorasExtras(10);
horasExtrasAnalista.CalcularHorasExtras(10);
