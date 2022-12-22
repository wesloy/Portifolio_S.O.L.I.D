// ISP respeitado, foi deixado apenas funções comuns para IAve
// Não obrigando nenhuma Ave a implementar funções que não podem executar
// Para as funções específicas de cada Ave, foi feita interfaces específicas
// desta forma durante a implementação foi possível herdar o que cada classe realmente iria usar

Gaviao gaviao = new Gaviao();
gaviao.Bicar();
gaviao.Voar();

Pinguim pinguim = new Pinguim();
pinguim.Bicar();
pinguim.Nadar();
