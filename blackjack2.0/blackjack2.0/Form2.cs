using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace blackjack2._0
{
    public partial class Form2 : Form
    {
        Thread varThread;
        public Form2()
        {
            InitializeComponent();

            //desabilitando a visualizaçao label de pontos
            lblResultadoP1.Visible = false;

            //desabilitando o botao reiniciar
            btnReiniciar.Enabled = false;
            btnReiniciar.BackgroundImage = Properties.Resources.reiniciar_disable;

            //desabilitando o botao manter
            btnManterP1.Enabled = false;
            btnManterP1.BackgroundImage = Properties.Resources.manter_disable;
            btnManterP2.Enabled = false;
            btnManterP2.BackgroundImage = Properties.Resources.manter_disable;

            //desabilitando o botao de  pedir carta p2
            btnPedirMaisP2.Enabled = false;

            //visibilidade lblresultadofinal
            lblResultadoFinal.Visible = false;
        }

        //Método para apresentar as cartas!
        public static int PedirCartas(PictureBox carta)
        {
            int numAleatorio, numAleatorioNipe;
            Random sorteio = new Random();

            numAleatorio = sorteio.Next(1, 14);
            numAleatorioNipe = sorteio.Next(1, 5);

            switch (numAleatorio)
            {
                case 1:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._01___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._01___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._01___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._01___paus;
                    }
                    break;

                case 2:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._02___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._02___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._02___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._02___paus;
                    }
                    break;

                case 3:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._03___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._03___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._03___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._03___paus;
                    }
                    break;

                case 4:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._04___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._04__espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._04___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._04___paus;
                    }
                    break;

                case 5:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._05___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._05___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._05___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._05___paus;
                    }
                    break;

                case 6:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._06___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._06___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._06___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._06___paus;
                    }
                    break;

                case 7:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._07___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._07___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._07___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._07___paus;
                    }
                    break;

                case 8:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._08___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._08___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._08___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._08___paus;
                    }
                    break;

                case 9:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._09___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._09___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._09___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._09___paus;
                    }
                    break;

                case 10:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._10___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._10___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._10___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._10___paus;
                    }
                    break;

                case 11:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._11___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._11___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._11___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._11___paus;
                    }
                    break;

                case 12:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._12___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._12___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._12___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._12___paus;
                    }
                    break;

                case 13:
                    if (numAleatorioNipe == 1)
                    {
                        carta.Image = Properties.Resources._13___copas;
                    }
                    else if (numAleatorioNipe == 2)
                    {
                        carta.Image = Properties.Resources._13___espada;
                    }
                    else if (numAleatorioNipe == 3)
                    {
                        carta.Image = Properties.Resources._13___ouro;
                    }
                    else
                    {
                        carta.Image = Properties.Resources._13___paus;
                    }
                    break;
            }


            //aplicando a regra do 21 que figuras equivalem ao valor de 10
            int valor = numAleatorio;
            if (valor == 11 || valor == 12 || valor == 13)
            {
                valor = 10;
            }
            return valor;


        }

        //método de resultado final
        private void ResultadoFinal()
        {
            /*

                jogador 1   x   jogador 2   resultado
                <= 21           <= 21       maior ponto ganha   REGRA 1
                > 21            <= 21       jogador 2 ganha     REGRA 2
                <= 21           > 21        jogador 1 ganha     REGRA 3
                > 21            > 21        2 perderam          REGRA 4
                jogador 2       jogador 1   EMPATE              REGRA 5

            */


            if (pontosP1 > pontosP2 && pontosP1 <= 21)
            {
                vitoriasP1 += 1;
                lblResultadoFinal.Text = "Jogador 1 GANHOU!";
            }

            else if (pontosP1 < pontosP2 && pontosP2 <= 21)
            {
                lblResultadoFinal.Text = "Jogador 2 GANHOU!";
                vitoriasP2 += 1;
            }
            else if (pontosP1 <= 21 && pontosP2 <= 21)
            {
                lblResultadoFinal.Text = "EMPATE";
            }
            else
            {
                lblResultadoFinal.Text = "SEM VENCEDOR.";
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //mostrando vitorias p1
            lblVitoriasP1.Text = vitoriasP1.ToString();

            //mostrando vitorias p2
            lblVitoriasP2.Text = vitoriasP2.ToString();

            //visibilidade lblresultadofinal
            lblResultadoFinal.Visible = false;

            //zerando label  valor de  carta atual
            lblValorCartaP1.Text = "0";
            lblValorCartaP2.Text = "0";

            //virando as cartas
            pibCartasP1.Image = Properties.Resources.cartavirada;
            pibCartasP2.Image = Properties.Resources.cartavirada;

            //desabilitando a visualizaçao label de pontos
            lblResultadoP1.Visible = false;
            lblResultadoP2.Visible = false;



            //desabilitando o botao reiniciar
            btnReiniciar.Enabled = false;
            btnReiniciar.BackgroundImage = Properties.Resources.reiniciar_disable;



            //desabilitando o botao manter
            btnManterP1.Enabled = false;
            btnManterP1.BackgroundImage = Properties.Resources.manter_disable;

            btnManterP2.Enabled = false;
            btnManterP2.BackgroundImage = Properties.Resources.manter_disable;



            //zerando os pontos e motrando na tela
            pontosP1 = 0;
            lblPontosP1.Text = pontosP1.ToString();

            pontosP2 = 0;
            lblPontosP2.Text = pontosP2.ToString();



            //habilitando btnPedirmais
            btnPedirMaisP1.Enabled = true;
            btnPedirMaisP1.BackgroundImage = Properties.Resources.pedir;

            btnPedirMaisP2.Enabled = false;
            btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir_disable;


        }


        //variáveis globais de pontuação player 1
        int pontosP1 = 0;
        int vitoriasP1 = 0;
        private void btnPedirMaisP1_Click(object sender, EventArgs e)
        {

            //hablitando  o botao manter
            btnManterP1.Enabled = true;
            btnManterP1.BackgroundImage = Properties.Resources.manter;

            //habilitando o botao Reiniciar!
            btnReiniciar.Enabled = true;
            btnReiniciar.BackgroundImage = Properties.Resources.reiniciar;

            //mostrando carta  e atribuindo o valor da variavel cartaAtual
            int cartaAtual = PedirCartas(pibCartasP1);
            lblValorCartaP1.Text = cartaAtual.ToString();

            //realizando o processo de pontos e mostrando na tela
            pontosP1 += cartaAtual;
            lblPontosP1.Text = pontosP1.ToString();


            //executando a função Resultado
            if (pontosP1 > 21)
            {
                lblResultadoP1.Text = "ESTOUROU";

                btnPedirMaisP1.Enabled = false;

                //habilitando o botao P2
                btnPedirMaisP2.Enabled = true;
                btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir;

                //desabilitando o botao manter
                btnManterP1.Enabled = false;
                btnManterP1.BackgroundImage = Properties.Resources.manter_disable;

                //habilitando a visualizaçao label de pontos
                lblResultadoP1.Visible = true;

            }
            else if (pontosP1 == 21)
            {
                lblResultadoP1.Text = "GANHOU!!!";
                btnPedirMaisP1.Enabled = false;

                //mostrando vitorias p1
                lblVitoriasP1.Text = vitoriasP1.ToString();
                //mostrando vitorias p2
                lblVitoriasP2.Text = vitoriasP2.ToString();

                //mostrando resultado final
                ResultadoFinal();
                //visibilidade lblresultadofinal
                lblResultadoFinal.Visible = true;

                //desabilitando o botao manter
                btnManterP1.Enabled = false;
                btnManterP1.BackgroundImage = Properties.Resources.manter_disable;

                //habilitando a visualizaçao label de pontos
                lblResultadoP1.Visible = true;

            }

        }

        //variáveis globais de pontuação player 2
        int pontosP2 = 0;
        int vitoriasP2 = 0;
        private void btnPedirMaisP2_Click(object sender, EventArgs e)
        {
            //hablitando  o botao manter
            btnManterP2.Enabled = true;
            btnManterP2.BackgroundImage = Properties.Resources.manter;

            //habilitando o botao Reiniciar!
            btnReiniciar.Enabled = true;
            btnReiniciar.BackgroundImage = Properties.Resources.reiniciar;

            //mostrando carta  e atribuindo o valor da variavel cartaAtual
            int cartaAtual = PedirCartas(pibCartasP2);
            lblValorCartaP2.Text = cartaAtual.ToString();

            //realizando o processo de pontos e mostrando na tela
            pontosP2 += cartaAtual;
            lblPontosP2.Text = pontosP2.ToString();


            //executando a função Resultado
            if (pontosP2 > 21)
            {
                lblResultadoP2.Text = "ESTOUROU";

                btnPedirMaisP2.Enabled = false;

                //desabilitando o botao manter
                btnManterP2.Enabled = false;
                btnManterP2.BackgroundImage = Properties.Resources.manter_disable;

                //habilitando a visualizaçao label de pontos
                lblResultadoP2.Visible = true;

                //visibilidade lblresultadofinal
                lblResultadoFinal.Visible = true;

                //mostrando resultado final
                ResultadoFinal();

            }
            else if (pontosP2 == 21)
            {
                lblResultadoP2.Text = "GANHOU!!!";
                btnPedirMaisP2.Enabled = false;

                //mostrando vitorias p1
                lblVitoriasP1.Text = vitoriasP1.ToString();
                //mostrando vitorias p2
                lblVitoriasP2.Text = vitoriasP2.ToString();

                //desabilitando o botao manter
                btnManterP2.Enabled = false;
                btnManterP2.BackgroundImage = Properties.Resources.manter_disable;

                //habilitando a visualizaçao label de pontos
                lblResultadoP2.Visible = true;

                //visibilidade lblresultadofinal
                lblResultadoFinal.Visible = true;

                //mostrando resultado final
                ResultadoFinal();

            }
        }

        private void btnManterP1_Click(object sender, EventArgs e)
        {
            //habilitando o botao P2
            btnPedirMaisP2.Enabled = true;
            btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir;


            btnPedirMaisP1.Enabled = false;
            btnPedirMaisP1.BackgroundImage = Properties.Resources.pedir_disable;

            //desabilitando o botao manter
            btnManterP1.Enabled = false;
            btnManterP1.BackgroundImage = Properties.Resources.manter_disable;

        }

        private void btnManterP2_Click(object sender, EventArgs e)
        {
            //visibilidade lblresultadofinal
            lblResultadoFinal.Visible = true;

            //mostrando resultado final
            ResultadoFinal();

            btnPedirMaisP2.Enabled = false;
            btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir_disable;

            //desabilitando o botao manter
            btnManterP2.Enabled = false;
            btnManterP2.BackgroundImage = Properties.Resources.manter_disable;
        }

        private void btnPedirMaisP1_EnabledChanged(object sender, EventArgs e)
        {
            btnPedirMaisP1.BackgroundImage = Properties.Resources.pedir_disable;
        }

        private void btnPedirMaisP2_EnabledChanged(object sender, EventArgs e)
        {
            btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir_disable;
        }

        private void btnManterP1_EnabledChanged(object sender, EventArgs e)
        {
            btnManterP1.BackgroundImage = Properties.Resources.pedir_disable;
        }

        private void btnManterP2_EnabledChanged(object sender, EventArgs e)
        {
            btnManterP2.BackgroundImage = Properties.Resources.pedir_disable;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            varThread = new Thread(novoForm);
            varThread.SetApartmentState(ApartmentState.STA);
            varThread.Start();
        }
        private void novoForm()
        {
            Application.Run(new Form1());
        }
    }
}
