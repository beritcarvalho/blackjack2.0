using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack2._0
{
    public partial class Form1 : Form
    {
        public Form1()
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
            int  valor = numAleatorio;
            if (valor == 11 || valor == 12 || valor == 13)
            {
                valor = 10;
            }
            return valor;


        }

        
        //variável global de pontuação player 1
        int pontosP1 = 0;
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
            Resultado(pontosP1, btnPedirMaisP1, btnManterP1, lblResultadoP1);

        }

        //método de resultado de jogo
        private void Resultado(int pontos, Button btnPedirMais, Button btnManter, Label lblResultado)
        {
            if (pontos > 21)
            {
                lblResultado.Text = "ESTOUROU";

                btnPedirMais.Enabled = false;

                //desabilitando o botao manter
                btnManter.Enabled = false;
                btnManter.BackgroundImage = Properties.Resources.manter_disable;

                //habilitando a visualizaçao label de pontos
                lblResultado.Visible = true;

            }
            else if (pontosP1 == 21)
            {
                lblResultado.Text = "GANHOU!!!";
                btnPedirMais.Enabled = false;

                //desabilitando o botao manter
                btnManter.Enabled = false;
                btnManter.BackgroundImage = Properties.Resources.manter_disable;

                //habilitando a visualizaçao label de pontos
                lblResultado.Visible = true;

            }
           
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
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

            btnPedirMaisP2.Enabled = true;
            btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir;


        }

        private void btnManterP1_Click(object sender, EventArgs e)
        {
            btnPedirMaisP1.Enabled = false;
            btnPedirMaisP1.BackgroundImage = Properties.Resources.pedir_disable;

            //desabilitando o botao manter
            btnManterP1.Enabled = false;
            btnManterP1.BackgroundImage = Properties.Resources.manter_disable;

        }

        int pontosP2 = 0;
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
            Resultado(pontosP2, btnPedirMaisP2, btnManterP2, lblResultadoP2);
        }

        private void btnManterP2_Click(object sender, EventArgs e)
        {
            btnPedirMaisP2.Enabled = false;
            btnPedirMaisP2.BackgroundImage = Properties.Resources.pedir_disable;

            //desabilitando o botao manter
            btnManterP2.Enabled = false;
            btnManterP2.BackgroundImage = Properties.Resources.manter_disable;
        }
    }

}
