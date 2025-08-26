public class Program
{
    public static void Main(string[] args)
    {
        int posicaoLinha, posicaoColuna;

        Console.WriteLine("   | |  ");
        Console.WriteLine(" --+-+--- ");
        Console.WriteLine("   | |  ");
        Console.WriteLine(" --+-+--- ");
        Console.WriteLine("   | |  ");

        Console.WriteLine("Jogador, escolha a linha: ");
        posicaoLinha = int.Parse(Console.ReadLine()) - 1

        Console.WriteLine("Jogador, escolha a coluna: ");
        posicaoColuna = int.Parse(Console.ReadLine()) - 1;
    }
}