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
            //mostrando carta  e atribuindo o valor da variavel cartaAtual
            int cartaAtual = PedirCartas(pibCartasP1);
            lblValorCartaP1.Text = cartaAtual.ToString();
            
            //realizando o processo de pontos e mostrando na tela
            pontosP1 += cartaAtual;
            lblPontosP1.Text = pontosP1.ToString();

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //zerando os pontos e motrando na tela
            pontosP1 = 0;
            lblPontosP1.Text = pontosP1.ToString();
        }
    }

}
