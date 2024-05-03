namespace FibonacciPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine(">>> Fibonacci <<<");

            bool resultadoTry;
            int tamanho, temp = 0, anterior = 0, atual = 1;
            PilhaNumero pilha = new PilhaNumero();

            do
            {
                Console.WriteLine("Digite a quantidade de numeros da sequencia:");
                Console.Write("R: ");

                resultadoTry = int.TryParse(Console.ReadLine(), out tamanho);

            } while (!resultadoTry);

            if (tamanho <= 0)
            {
                Console.WriteLine("Numero incorreto!");
            }
            else
            {
                if (tamanho >= 1)
                    pilha.Push(new Numero(anterior));
                if (tamanho >= 2)
                    pilha.Push(new Numero(atual));
                for (int i = 2; i < tamanho; i++)
                {
                    temp = atual + anterior;
                    anterior = atual;
                    atual = temp;

                    pilha.Push(new Numero(atual));
                }

                Console.WriteLine("Sequencia fibonacci: ");
                pilha.Print();
            }
            Console.ReadKey();
        }
    }
}
