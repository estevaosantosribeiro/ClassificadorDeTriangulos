namespace ClassificadorDeTriangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // exibir o cabeçalho
                Console.Clear();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Classificador de Triângulos");
                Console.WriteLine("-----------------------------------------------");

                // receber a entrada (input) de dados
                Console.Write("Informe o valor do lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado Y: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado Z: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                // exibir os valores digitados
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado Y: " + ladoY);
                Console.WriteLine("Lado Z: " + ladoZ);

                Console.WriteLine("-----------------------------------------------");
                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
