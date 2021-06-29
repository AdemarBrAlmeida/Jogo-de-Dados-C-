using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogandoDado
{
    public partial class frmJogo : Form
    {
        int face = 0;//sorteado usuario
        int face1 = 0;//sorteado cpu
        int lado = 0;//escolha do jogador
        int soma = 0;
        int soma1 = 0;//se não alocar aqui não mostra o ultimo valor somado       
        int cpu = 0;
        int usuario = 0;


        public frmJogo()
        {
            InitializeComponent();
            btnLancarDados.Focus();
            playSoundFileIni();
        }

        //----------------------------------------Inserção de sons dos recursos
        private void playSoundFileIni()
        {
            /*using (SoundPlayer som = new SoundPlayer(@"C:\Users\Ademar\Documents\Projetos C#\repos\JogandoDado\sound\Bass E.wav"))
            {
                som.Play();
            }*/
            System.Media.SoundPlayer player = new SoundPlayer(Properties.Resources.aerosol_shake_01);
            player.Play();
        }

        private void playSoundFileUsu()
        {
            System.Media.SoundPlayer player = new SoundPlayer(Properties.Resources.guitar_8);
            player.Play();
        }

        private void playSoundFileCpu()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.tng_doorbell);
            player.Play();
        }


        //-----------------------------------Desabilita imagens Lado Bonus
        private void DesabilitarPcb()
        {
            pcbUm.Enabled = false;
            pcbDois.Enabled = false;
            pcbTres.Enabled = false;
            pcbQuatro.Enabled = false;
            pcbCinco.Enabled = false;
            pcbSeis.Enabled = false;
        }

        // -------------------------------Metodos abaixo selecionam o lado escolhido
        private void pcbUm_Click(object sender, EventArgs e)
        {
            pcbUm.BackColor = Color.White;
            lado = 1;
            DesabilitarPcb();
            SystemSounds.Asterisk.Play();
        }


        private void pcbDois_Click(object sender, EventArgs e)
        {
            pcbDois.BackColor = Color.White;
            lado = 2;
            DesabilitarPcb();
            SystemSounds.Asterisk.Play();
        }


        private void pcbTres_Click(object sender, EventArgs e)
        {
            pcbTres.BackColor = Color.White;
            lado = 3;
            DesabilitarPcb();
            SystemSounds.Asterisk.Play();
        }

        private void pcbQuatro_Click(object sender, EventArgs e)
        {
            pcbQuatro.BackColor = Color.White;
            lado = 4;
            DesabilitarPcb();
            SystemSounds.Asterisk.Play();
        }

        private void pcbCinco_Click(object sender, EventArgs e)
        {
            pcbCinco.BackColor = Color.White;
            lado = 5;
            DesabilitarPcb();
            SystemSounds.Asterisk.Play();
        }

        private void pcbSeis_Click(object sender, EventArgs e)
        {
            pcbSeis.BackColor = Color.White;
            lado = 6;
            DesabilitarPcb();
            SystemSounds.Asterisk.Play();
        }

        // -----------------------------------------------Fim da Seleção de Lado
        private void Sorteio()
        {
            Random dado = new Random();
            face = dado.Next(1, 7);
        }

        //----------------------------------------------Calculo valor Cpu
        private void CalcCpu()
        {
            Random dado2 = new Random();
            face1 = dado2.Next(3, 19);
            cpu = cpu + face1;
            lblSomaCpu.Text = "+ " + Convert.ToString(face1);
        }

        private void btnLancarDados_Click(object sender, EventArgs e)
        {
            int a;

            lblGbx1.Text = string.Empty;
            lblGbx2.Text = string.Empty;
            lblGbx3.Text = string.Empty;

            //--------------------------------------------Calculo da Pontuação
            if (usuario < 200 && cpu < 200)
            {
                for (a = 1; a < 4; a++)
                {

                    if (a == 1)
                    {
                        Sorteio();
                        PcbUmResult();
                        if (lado == face)
                        {
                            lblGbx1.Text = "Bonus\n  +1";
                            lblGbx1.ForeColor = Color.White;
                            soma = face + 1;
                        }
                        else
                        {

                            soma = face;
                        }
                        Thread.Sleep(400);
                    }
                    else if (a == 2)
                    {
                        Sorteio();
                        PcbDoisResult();
                        if (lado == face)
                        {
                            lblGbx2.Text = "Bonus\n  +1";
                            lblGbx2.ForeColor = Color.White;
                            soma = soma + face + 1;
                        }
                        else
                        {

                            soma = soma + face;
                        }
                        Thread.Sleep(400);
                    }
                    else
                    {
                        Sorteio();
                        PcbTresResult();
                        if (lado == face)
                        {
                            lblGbx3.Text = "Bonus\n  +1";
                            lblGbx3.ForeColor = Color.White;
                            soma1 = soma + face + 1;//------variavel trocada porque "soma" dava erro no calculo final
                        }
                        else
                        {
                            soma1 = soma + face;
                        }
                    }

                    lblSomaUsu.Text = "+ " + Convert.ToString(soma1);
                    usuario = usuario + soma1;//---------- Calcula pontuação do Usuario
                    soma1 = 0;//-----------------------Reset necessário para não acumular a cada laço
                    lblTotUsu.Text = Convert.ToString(usuario);

                }

                CalcCpu();//-------------------------------- Calcula pontuação da Cpu
                lblTotCpu.Text = Convert.ToString(cpu);
                lblVencedor.Text = "...Lançar Dados Novamente...";
                SystemSounds.Asterisk.Play();


            //-----------------------------------------Comparativo do Vencedor
                if (cpu >= 200 && cpu > usuario)
                {

                    lblSomaCpu.Text = string.Empty;
                    lblSomaUsu.Text = string.Empty;
                    lblVencedor.Text = "xiii...CPU VENCEU !!!";
                    pcbVencedor.Image = Properties.Resources.dados_colors;
                    btnLancarDados.Enabled = false;
                    btnOutravez.Enabled = true;
                    btnOutravez.Focus();
                    playSoundFileCpu();
                }


                else if (usuario >= 200 && usuario >= cpu)
                {

                    lblSomaUsu.Text = string.Empty;
                    lblSomaCpu.Text = string.Empty;
                    lblVencedor.Text = "VOCÊ VENCEU...PARABÉNS !!!";
                    pcbVencedor.Image = Properties.Resources.dados_colors;
                    btnLancarDados.Enabled = false;
                    btnOutravez.Enabled = true;
                    btnOutravez.Focus();
                    playSoundFileUsu();
                }
            }


        }

        //------------------------------------------Chamada de imagens
        private void PcbUmResult()
        {

            switch (face)
            {
                case 1:
                    pcbResulUm.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    pcbResulUm.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    pcbResulUm.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    pcbResulUm.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    pcbResulUm.BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    pcbResulUm.BackgroundImage = Properties.Resources._6;
                    break;
            }
        }

        private void PcbDoisResult()
        {
            switch (face)
            {
                case 1:
                    pcbResulDois.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    pcbResulDois.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    pcbResulDois.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    pcbResulDois.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    pcbResulDois.BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    pcbResulDois.BackgroundImage = Properties.Resources._6;
                    break;
            }
        }

        private void PcbTresResult()
        {
            switch (face)
            {
                case 1:
                    pcbResulTres.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    pcbResulTres.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    pcbResulTres.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    pcbResulTres.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    pcbResulTres.BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    pcbResulTres.BackgroundImage = Properties.Resources._6;
                    break;
            }
        }


        private void btnOutraVez_Click(object sender, EventArgs e)
        {
            frmJogo abrir = new frmJogo();
            abrir.Show();
            Hide();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            Close();
        }

    }
}
