// Nota-se que cada classe possui responsabilidades únicas, mesmo podendo ter várias ações (metodos)
// Obedecendo assim o princípio da responsabilidade única da letra S do SOLID

namespace Funcionarios
{
    public class Cozinheiro
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
    }

    public class Garcom
    {
        public void AnotarPedido()
        {
            Console.WriteLine("Pedido anotado...");
        }

        public void ServirMesa()
        {
            Console.WriteLine("Aqui está seu pedido Senhor(a)...");
        }
    }

    public class Caixa
    {
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
