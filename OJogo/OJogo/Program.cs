public class Program
{
    public static void Main(string[] args)
    {
        string[,] tabuleiro = new string[3, 3];
        int posicaoLinha, posicaoColuna, qtddJogadas = 1;
        char jogadorDaVez = 'X';
        bool deuCerto;

        tabuleiro[0, 0] = " ";
        tabuleiro[0, 1] = " ";
        tabuleiro[0, 2] = " ";
        tabuleiro[1, 0] = " ";
        tabuleiro[1, 1] = " ";
        tabuleiro[1, 2] = " ";
        tabuleiro[2, 0] = " ";
        tabuleiro[2, 1] = " ";
        tabuleiro[2, 2] = " ";   


        Console.WriteLine("   | |  ");
        Console.WriteLine(" --+-+--- ");
        Console.WriteLine("   | |  ");
        Console.WriteLine(" --+-+--- ");
        Console.WriteLine("   | |  ");

        

        do
        {
            Console.WriteLine("Quem começa? Digite 'X' ou 'O' ");
            jogadorDaVez = char.Parse(Console.ReadLine());
            if(jogadorDaVez != 'X' && jogadorDaVez != 'O')
            {
                Console.WriteLine("Jogador inválido! Tente novamente.");
            }
        } while (jogadorDaVez != 'X' && jogadorDaVez != 'O');



         
        do
        {
            do
            {
                Console.WriteLine("Jogador {0}, escolha a linha: ", jogadorDaVez);
                deuCerto = int.TryParse(Console.ReadLine(), out posicaoLinha);
                if (deuCerto == true)
                {
                    posicaoLinha--;
                }
                else
                {
                  Console.WriteLine("Escreva um número! Tente novamente.");
                }
            } while (deuCerto == false);


            do
            {
                Console.WriteLine("Jogador, escolha a coluna: ");
                deuCerto = int.TryParse(Console.ReadLine(), out posicaoColuna);
                if(deuCerto == true)
                {
                  posicaoColuna--;
                }
                else
                {
                    Console.WriteLine("Escreva um número! Tente novamente.");
                }
            } while(deuCerto == false);



            if (posicaoLinha >= 3 || posicaoColuna >= 3 || posicaoLinha < 0 || posicaoColuna < 0) 
            {

                Console.WriteLine("Posição inválida! Tente novamente.");

            }
            else
            {


                if (tabuleiro[posicaoLinha, posicaoColuna] == " ")
                { 
                    
                    tabuleiro[posicaoLinha, posicaoColuna] = jogadorDaVez.ToString();
                    if (jogadorDaVez == 'X')
                    {
                        jogadorDaVez ='O';
                    }
                    else
                    {
                        jogadorDaVez = 'X';
                    }

                    qtddJogadas++;

                    Console.Clear();

                    Console.WriteLine(" {0} | {1} | {2} ", tabuleiro[0, 0], tabuleiro[0, 1], tabuleiro[0, 2]);
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" {0} | {1} | {2} ", tabuleiro[1, 0], tabuleiro[1, 1], tabuleiro[1, 2]);
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" {0} | {1} | {2} ", tabuleiro[2, 0], tabuleiro[2, 1], tabuleiro[2, 2]);
                }
                else
                {
                    Console.WriteLine("Posição já ocupada! Tente novamente.");

                }



            }
        } while(qtddJogadas <= 9);

        

        







    }
}