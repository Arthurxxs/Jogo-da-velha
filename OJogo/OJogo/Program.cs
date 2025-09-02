using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {
        string[,] tabuleiro = new string[3, 3];
        int posicaoLinha, posicaoColuna, qtddJogadas = 1;
        char jogadorDaVez = 'X';
        bool deuCerto;
        bool houveGanhador = false;
        int jogarNovamente = 0;
        int placarX = 0, placarO = 0;
        int jogadores = 1;
        
        Console.WriteLine("Bem-vindo ao jogo da velha!");
        Console.WriteLine("Com quantos jogadores você quer jogar? (1 ou 2)");
        jogadores = int.Parse(Console.ReadLine());

        if (jogadores == 2)
        {
                        Console.WriteLine("Jogo para 2 jogadores selecionado.");
            do
            {
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
                    if (jogadorDaVez != 'X' && jogadorDaVez != 'O')
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
                        if (deuCerto == true)
                        {
                            posicaoColuna--;
                        }
                        else
                        {
                            Console.WriteLine("Escreva um número! Tente novamente.");
                        }
                    } while (deuCerto == false);

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
                                jogadorDaVez = 'O';
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

                        if ((tabuleiro[0, 0] == "X" && tabuleiro[0, 1] == "X" && tabuleiro[0, 2] == "X") ||
                            (tabuleiro[1, 0] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[1, 2] == "X") ||
                            (tabuleiro[2, 0] == "X" && tabuleiro[2, 1] == "X" && tabuleiro[2, 2] == "X") ||
                            (tabuleiro[0, 0] == "X" && tabuleiro[1, 0] == "X" && tabuleiro[2, 0] == "X") ||
                            (tabuleiro[0, 1] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 1] == "X") ||
                            (tabuleiro[0, 2] == "X" && tabuleiro[1, 2] == "X" && tabuleiro[2, 2] == "X") ||
                            (tabuleiro[0, 0] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 2] == "X") ||
                            (tabuleiro[0, 2] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 0] == "X"))
                        {
                            Console.WriteLine("Jogador X venceu!");
                            houveGanhador = true;
                            placarX++;
                            break;
                        }
                        else if ((tabuleiro[0, 0] == "O" && tabuleiro[0, 1] == "O" && tabuleiro[0, 2] == "O") ||
                                 (tabuleiro[2, 0] == "O" && tabuleiro[2, 1] == "O" && tabuleiro[2, 2] == "O") ||
                                 (tabuleiro[0, 0] == "O" && tabuleiro[1, 0] == "O" && tabuleiro[2, 0] == "O") ||
                                 (tabuleiro[0, 1] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 1] == "O") ||
                                 (tabuleiro[0, 2] == "O" && tabuleiro[1, 2] == "O" && tabuleiro[2, 2] == "O") ||
                                 (tabuleiro[0, 0] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 2] == "O") ||
                                 (tabuleiro[1, 0] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[1, 2] == "O") ||
                                 (tabuleiro[0, 2] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 0] == "O"))
                        {
                            Console.WriteLine("Jogador O venceu!");
                            houveGanhador = true;
                            placarO++;
                            break;
                        }
                        else if (qtddJogadas == 10)
                        {
                            houveGanhador = false;
                            Console.WriteLine("Deu velha!");
                        }
                    }

                } while (qtddJogadas <= 9);

                qtddJogadas = 1;

                if (houveGanhador == true)
                {
                    Console.WriteLine("Deseja jogar novamente? Digite 0 para não ou 1 para sim.");
                    jogarNovamente = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Placar do jogador X: " + placarX);
                Console.WriteLine("Placar do jogador O: " + placarO);
            } while (houveGanhador == false || jogarNovamente == 1);

        }
        else
        {
            Console.WriteLine("Jogo para 1 jogador selecionado.");
            Console.WriteLine("Voce jogará com a máquina.");
        }
    }
} 

           
