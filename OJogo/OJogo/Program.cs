using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
public class Program
{

    public static void Main(string[] args)
    {
        string[,] tabuleiro = new string[3, 3];
        int posicaoLinha = 0, posicaoColuna = 0, qttJogadas = 1;
        char jogadorDaVez = 'X';
        bool deuCerto = false;
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
                DefinirSimbolo(jogadorDaVez);

                LimparTabuleiro(tabuleiro);

                MostrarTabuleiroVazio();


                do
                {
                    
                   
                    
                        EscolherPosicao(ref jogadorDaVez, ref deuCerto, ref posicaoLinha, ref posicaoColuna, ref tabuleiro, ref qttJogadas);

                        

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
                        else if (qttJogadas == 10)
                        {
                            houveGanhador = false;
                            Console.WriteLine("Deu velha!");
                        }
                    

                } while (qttJogadas <= 9);

                qttJogadas = 1;

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

            Console.WriteLine("Escolha seu símbolo: 'X' ou 'O'");
            jogadorDaVez = char.Parse(Console.ReadLine());
            DefinirSimbolo(jogadorDaVez);

            LimparTabuleiro(tabuleiro);
            do
            {
                

                EscolherPosicao(ref jogadorDaVez, ref deuCerto, ref posicaoLinha, ref posicaoColuna, ref tabuleiro, ref qttJogadas);


            } while (qttJogadas <= 9);

        }
    }

    private static void MostrarTabuleiroVazio()
    {
        Console.WriteLine("   | |  ");
        Console.WriteLine(" --+-+--- ");
        Console.WriteLine("   | |  ");
        Console.WriteLine(" --+-+--- ");
        Console.WriteLine("   | |  ");
    }

    private static void LimparTabuleiro(string[,] tabuleiro)
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

    }

    private static void DefinirSimbolo(char jogadorDaVez)
    {
        do
        {
            Console.WriteLine("Quem começa? Digite 'X' ou 'O' ");
            jogadorDaVez = char.Parse(Console.ReadLine());
            if (jogadorDaVez != 'X' && jogadorDaVez != 'O')
            {
                Console.WriteLine("Jogador inválido! Tente novamente.");
                jogadorDaVez = char.Parse(Console.ReadLine());
            }
        } while (jogadorDaVez != 'X' && jogadorDaVez != 'O');
    }

    private static void EscolherPosicao(ref char jogadorDaVez, ref bool DeuCerto, ref int posicaoLinha, ref int posicaoColuna, ref string[,] tabuleiro, ref int qttJogadas)
    {
        do
        {
            Console.WriteLine("Jogador {0}, escolha a linha: ", jogadorDaVez);
            DeuCerto = int.TryParse(Console.ReadLine(), out posicaoLinha);
            if (DeuCerto == true)
            {
                posicaoLinha--;
            }
            else
            {
                Console.WriteLine("Escreva um número! Tente novamente.");
            }
        } while (DeuCerto == false);
        do
        {
            Console.WriteLine("Jogador, escolha a coluna: ");
            DeuCerto = int.TryParse(Console.ReadLine(), out posicaoColuna);
            if (DeuCerto == true)
            {
                posicaoColuna--;
            }
            else
            {
                Console.WriteLine("Escreva um número! Tente novamente.");
            }
        } while (DeuCerto == false);
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
                qttJogadas++;
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
    }
}


    





/* visto dia 02/09
 
          *Visibilidade:
          * publica - public
          * privada - private (so a classe consegue acessar)
          * protected - todo o pacote tem acesso
          * 
          * 
          * 
          *Tipos de retorno;
          * int, double, float, char, string, bool, void 
          * (vazio - nao retorna nada)
        
         visibilidade tipoDeRetorno nomeDaFuncao(parametros)
         {

         }
         */

