// Nota-se abaixo uma God Class, que executa todas as funções de uma lanchonete simples..

namespace Funcionarios
{
    public class Funcionario
    {
        public void PrepararAlimentos()
        {
            Console.WriteLine("Alimento preparado...");
        }
        public void Cozinhar()
        {
            Console.WriteLine("Alimento cozido...");
        }
        public void MontarPrato()
        {
            Console.WriteLine("Prato preparado...");
        }

        public void AnotarPedido()
        {
            Console.WriteLine("Pedido anotado...");
        }

        public void ServirMesa()
        {
            Console.WriteLine("Aqui está seu pedido Senhor(a)...");
        }
        public void FinalizarConta()
        {
            Console.WriteLine("Sua conta Senhor(a)...");
        }

        public void ReceberPagamento()
        {
            Console.WriteLine("Tudo okay! Volte sempre...");
        }
    }
}
