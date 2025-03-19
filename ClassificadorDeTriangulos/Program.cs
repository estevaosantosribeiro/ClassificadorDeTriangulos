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
                int ladoX;

                while (true)
                {
                    Console.Write("Informe o valor do lado X: ");

                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoX);

                    if (conseguiuConverter)
                        break;
                }

                int ladoY;

                while (true)
                {
                    Console.Write("Informe o valor do lado Y: ");

                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoY);
                    if (conseguiuConverter)
                        break;
                }

                int ladoZ;

                while (true)
                {
                    Console.Write("Informe o valor do lado Z: ");

                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoZ);

                    if (conseguiuConverter)
                        break;
                }

                // exibir os valores digitados
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado Y: " + ladoY);
                Console.WriteLine("Lado Z: " + ladoZ);
                Console.WriteLine("-----------------------------------------------");

                // verificar a validade do triângulo
                bool medidasTrianguloValidas =
                    ladoX + ladoY > ladoZ &&
                    ladoX + ladoZ > ladoY &&
                    ladoY + ladoZ > ladoX;

                if (medidasTrianguloValidas == true)
                {
                    string tipoTriangulo = "Não classificado";

                    if (ladoX == ladoY && ladoY == ladoZ)
                        tipoTriangulo = "Eqüilátero";

                    else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                        tipoTriangulo = "Escaleno";

                    else
                        tipoTriangulo = "Isósceles";

                    Console.WriteLine($"O triângulo é {tipoTriangulo}.");
                }
                else
                    Console.WriteLine("Os valores informados não formam um triângulo válido");

                Console.WriteLine("-----------------------------------------------");
                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
