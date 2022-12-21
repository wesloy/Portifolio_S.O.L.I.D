using Contabilidade;

var horasExtras = new HorasExtras();

horasExtras.CalculaHorasExtras(TiposCargosEnum.Gerente, 10);
horasExtras.CalculaHorasExtras(TiposCargosEnum.Coordenador, 10);
horasExtras.CalculaHorasExtras(TiposCargosEnum.Analista, 10);
