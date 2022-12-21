// Neste exemplo está obdecido o OCP, sendo que se houver cálculo de horas extras para outro cargo
// basta apenas extender da interface IHorasExtras e não se modifica as classes já implantadas

using Contabilidade;

var horasExtrasGerente = new HorasExtrasGerente();
var horasExtrasCoordenador = new HorasExtrasCoordenador();
var horasExtrasAnalista = new HorasExtrasAnalista();


horasExtrasGerente.CalcularHorasExtras(10);
horasExtrasCoordenador.CalcularHorasExtras(10);
horasExtrasAnalista.CalcularHorasExtras(10);
