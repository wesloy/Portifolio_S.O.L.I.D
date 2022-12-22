// O problema aqui para o ISP está no pinguim que tem como contrato, uma interface de ave 
// que o obriga a implementar o método VOAR, algo que ele não pode fazer.
// Desta forma, sendo necessário fazer uma tratativa de exceção

IAve gaviao = new Gaviao();
gaviao.Bicar();
gaviao.Voar();

IAve pinguim = new Pinguim();
pinguim.Bicar();
pinguim.Voar();
