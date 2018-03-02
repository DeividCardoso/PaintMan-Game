using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N2
{
    public partial class TelaPrincipal : Form
    {
        #region Variaveis Globais

        SoundPlayer musica = new SoundPlayer(@"Sounds\Voltaic.wav");
        bool musicaOnOff;

        #endregion

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        //Evento Load do form, carrega a musica
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {            
            this.musica.PlayLooping();
            musicaOnOff = true;
        }

        //Evento click do button Sair, fecha o form
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento click do butto Sound, da play ou pause na musica e muda a imagem do controle
        private void buttonSound_Click(object sender, EventArgs e)
        {
            if(musicaOnOff == true)
            {
                buttonSound.BackgroundImage = Image.FromFile(@"Imagens\soundOff.ico");
                buttonSound.BackgroundImageLayout = ImageLayout.Stretch;
                musica.Stop();
                musicaOnOff = false;
            }
            else
            {
                buttonSound.BackgroundImage = Image.FromFile(@"Imagens\soundOn.ico");
                buttonSound.BackgroundImageLayout = ImageLayout.Stretch;
                musica.Play();
                musicaOnOff = true;
            }
        }

        //Evento click do button sobre, abre form filho 
        private void button4_Click(object sender, EventArgs e)
        {
            About sobre = new About();
            sobre.ShowDialog();
        }

        //Evento click do button cadastro, abre form filho
        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            Cadastros novoCadastro = new Cadastros();
            novoCadastro.ShowDialog();
        }

        /*Evento click do button Jogar
        verifica se existem cadastros de palavras e temas
        se sim, cria form filho e atualiza o estado da musica do form filho
        Ao fechar o form filho pega o estado da musica*/
        private void buttonJogar_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Palavras.txt") || !File.Exists("Temas.txt"))
            {
                MessageBox.Show("Não há palavras cadastradas!\nFaço o cadastro das palavras para jogar!");
                return;
            }
            else
            {
                Jogar telaJogar = new Jogar();
                telaJogar.musicaOnOff = this.musicaOnOff;
                telaJogar.ShowDialog();
                if (!telaJogar.musicaOnOff)
                {
                    this.buttonSound.BackgroundImage = Image.FromFile(@"Imagens\soundOff.ico");
                    this.buttonSound.BackgroundImageLayout = ImageLayout.Stretch;
                    this.musica.Stop();
                    this.musicaOnOff = false;
                }
                else
                {
                    this.buttonSound.BackgroundImage = Image.FromFile(@"Imagens\soundOn.ico");
                    this.buttonSound.BackgroundImageLayout = ImageLayout.Stretch;
                    this.musica.Play();
                    this.musicaOnOff = true;
                }
            }
        }

        /*Evento click do button recordes, verifica se existe recorde salvo 
        Se sim, cria form filho*/
        private void buttonRecordes_Click(object sender, EventArgs e)
        {
            ConsultaRecord telaDeRecordes = new ConsultaRecord();

            if (File.Exists("Recordes.txt"))
            {
                telaDeRecordes.ShowDialog();
            }
            else
                MessageBox.Show("Não há recordes salvos!");
        }
    }
}
