using Contabilidade;

var horasExtras = new HorasExtras(); // Esta declaração quebra o SOLID, mas isso é para outro momento

horasExtras.CalculaHorasExtras(TiposCargosEnum.Gerente, 10);
horasExtras.CalculaHorasExtras(TiposCargosEnum.Coordenador, 10);
horasExtras.CalculaHorasExtras(TiposCargosEnum.Analista, 10);
