using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Media;

namespace N2
{
    public partial class Jogar : Form
    {
        #region Variaveis Globais

        DirectoryInfo imagens = new DirectoryInfo(@"Imagens\DoJogo");
        FileInfo[] caminhos;

        TelaDicaDoJogo IniciaJogo = new TelaDicaDoJogo();
        SoundPlayer musica = new SoundPlayer(@"Sounds\Voltaic.wav");
        public bool musicaOnOff;
        Button[] buttonArray = new Button[20];
        PictureBox animacao = new PictureBox();
        string[] imagensDaAnimacaoGif;

        string[] temas;
        string[] palavras;
        int posicao;
        bool primeiraPartida;
        bool jogando;
        int chances;
        int erros;
        int tempo;
        int imagensDaAnimacao;
        int pararNaImagem;

        string palavraSorteada;
        string dica;
        #endregion

        public Jogar()
        {
            InitializeComponent();
        }

        /*Evento load do form
        Chama metodos que criam novos controles e inicializa as variaveis*/
        private void Jogar_Load(object sender, EventArgs e)
        {
            CriaNovosButtons();
            CarregaDados();
            VerificaMusica();
            CriaPictureBox();
            pegaImagens();
            primeiraPartida = true;
            jogando = false;
            erros = 0;
            tempo = 100;
        }

        //Método para pegar as imagens do documento que farão gifs com ciclo unico
        private void pegaImagens()
        {
            caminhos = imagens.GetFiles();
            imagensDaAnimacaoGif = new string[caminhos.Length];
            for (int i = 0; i < caminhos.Length; i++)
            {
                imagensDaAnimacaoGif[i] = caminhos[i].FullName;
            }
        }

        //Método que limpa os controles e atualiza as variaveis
        private void LimparRegistros()
        {
            btnDica.Enabled = false;
            chances = 5;
            erros = 0;
            tempo = 100;
            jogando = false;
            cmbEscolhaTema.Items.Clear();
            txtDica.Clear();
            txtChances.Clear();
            txtTempo.Text = "100";
            txtLetras.Text = "";
            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Text = "";
                buttonArray[i].Visible = false;
            }
            lblQuantidade.Text = "";
            lblQuantidade.Visible = false;
            if (!primeiraPartida)
                animacao.Image = N2.Properties.Resources.capa;

            lblChances.Visible = false;
            lblTempo.Visible = false;
            lblQuantidade.Visible = false;
            txtChances.Visible = false;
            txtLetras.Visible = false;
            picLetras.Visible = false;
            txtTempo.Visible = false;
            txtDica.Visible = false;

        }

        /*Método que carrega os dados e atualiza o comboBox temas para nova partida
        Limpa os controles
        Verifica se existem dados salvos
        se sim, atualiza o comboBox com as informações do txt*/
        private void CarregaDados()
        {
            LimparRegistros();

            if (!File.Exists("Palavras.txt") || !File.Exists("Temas.txt"))
            {
                MessageBox.Show("Não há palavras cadastradas!\nFaço o cadastro das palavras para jogar!");
                this.Close();
            }
            else
            {
                temas = File.ReadAllLines("Temas.txt");
                for (int i = 0; i < this.temas.Length; i++)
                {
                    posicao = temas[i].LastIndexOf("|");
                    cmbEscolhaTema.Items.Add(temas[i].Substring(posicao + 1));
                }
                palavras = File.ReadAllLines("Palavras.txt");
            }
        }

        //Método para inicializar o form com a musica tocando ou não
        private void VerificaMusica()
        {
            if (musicaOnOff == true)
            {
                musica.Play();
                buttonSound.BackgroundImage = N2.Properties.Resources.soundOn;
            }
            else
            {
                musica.Stop();
                buttonSound.BackgroundImage = Image.FromFile(@"Imagens\soundOff.ico");
                buttonSound.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        //Cria o controle pictureBox no form, setando os valores de tamanho e localização
        private void CriaPictureBox()
        {
            animacao = new PictureBox();
            animacao.Size = new Size(574, 473);
            animacao.Location = new Point(12, 95);
            this.Controls.Add(animacao);
            animacao.Image = N2.Properties.Resources.EscolhaTema;
            animacao.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Cria um array de 20 buttons e seta seus valores de size e localização
        private void CriaNovosButtons()
        {
            int horizotal = 11;
            int vertical = 439;


            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(52, 47);
                buttonArray[i].Location = new Point(horizotal, vertical);
                if (i == 9)
                {
                    horizotal = 11;
                    vertical = vertical + 53;
                }
                else
                    horizotal = horizotal + 58;
                this.Controls.Add(buttonArray[i]);
                buttonArray[i].Visible = false;
                buttonArray[i].Enabled = false;
                FontFamily dosButtons = new FontFamily("Arial");
                Font letraDosButtons = new Font(dosButtons, 18, FontStyle.Regular, GraphicsUnit.Point);
                buttonArray[i].Font = new Font(letraDosButtons, FontStyle.Bold);
            }
        }

        //Método que cria animações na tela a cada erro
        private void animacaoDosErros(int erro)
        {
            if (chances > 0)
                chances--;
            tempo -= 10;

            switch (erro)
            {
                case 1:
                    pararNaImagem = 6;
                    imagensDaAnimacao = 0;
                    timerDaAnimacao.Interval = 100;
                    timerDaAnimacao.Start();
                    break;

                case 2:
                    imagensDaAnimacao = 6;
                    pararNaImagem = 8;
                    timerDaAnimacao.Interval = 200;
                    timerDaAnimacao.Start();
                    break;

                case 3:
                    imagensDaAnimacao = 8;
                    pararNaImagem = 9;
                    timerDaAnimacao.Interval = 200;
                    timerDaAnimacao.Start();
                    break;

                case 4:
                    imagensDaAnimacao = 9;
                    pararNaImagem = 22;
                    timerDaAnimacao.Interval = 100;
                    timerDaAnimacao.Start();
                    break;

                case 5:
                    imagensDaAnimacao = 22;
                    pararNaImagem = 23;
                    timerDaAnimacao.Interval = 200;
                    timerDaAnimacao.Start();
                    break;

                case 6:
                    imagensDaAnimacao = 23;
                    pararNaImagem = 37;
                    timerDaAnimacao.Interval = 200;
                    timerDaAnimacao.Start();
                    break;
            }
        }

        /*Método que sorteia aleatoriamente a palavra do jogo
        Cria temporariamente um txt para salvar todas as palavras do tema selecionado
        salva essas palavras em um array
        e gera um numero aleatorio que corresponde ao index da palavra que sera jogada
        retorna true se conseguir gerar a palavra ou false caso contrário*/
        private bool SortearPalavra()
        {
            string[] palavrasDoTema;
            int pipingInicio, pipingFim, numeroDaSorte;

            for (int i = 0; i < palavras.Length; i++)
            {
                pipingFim = palavras[i].LastIndexOf("|");
                if (cmbEscolhaTema.SelectedIndex.ToString() == palavras[i].Substring(pipingFim + 1))
                {
                    pipingInicio = palavras[i].IndexOf("|") + 1;
                    pipingFim = palavras[i].LastIndexOf("|");
                    if (File.Exists("PalavrasDoTema.txt"))
                    {
                        File.AppendAllText("PalavrasDoTema.txt", Environment.NewLine +
                            palavras[i].Substring(pipingInicio, pipingFim - pipingInicio));
                    }
                    else
                    {
                        File.AppendAllText("PalavrasDoTema.txt", palavras[i].Substring(pipingInicio, pipingFim - pipingInicio));
                    }
                }
            }
            if (File.Exists("PalavrasDoTema.txt"))
            {
                palavrasDoTema = File.ReadAllLines("PalavrasDoTema.txt");
                File.Delete("PalavrasDoTema.txt");

                Random numeroRandomico = new Random();
                numeroDaSorte = numeroRandomico.Next(0, palavrasDoTema.Length);
                palavraSorteada = palavrasDoTema[numeroDaSorte];
                pipingInicio = palavraSorteada.IndexOf("|");
                dica = palavraSorteada.Substring(pipingInicio + 1);
                palavraSorteada = palavraSorteada.Substring(0, pipingInicio);
                return true;
            }
            else
            {
                MessageBox.Show("Não existem palavras cadastradas neste tema!\nEscolha outro tema!");
                return false;
            }
        }

        //Método que habilita os controles do jogo
        private void habilitaControles()
        {
            btnDica.Enabled = true;
            btnDica.Visible = true;
            lblChances.Visible = true;
            txtChances.Visible = true;
            txtTempo.Visible = true;
            lblTempo.Visible = true;
            picLetras.Visible = true;
            txtLetras.Visible = true;
        }

        //Evento do button Sound, toca ou para a musica do jogo
        private void buttonSound_Click(object sender, EventArgs e)
        {
            if (this.musicaOnOff)
            {
                musicaOnOff = false;
                musica.Stop();
                buttonSound.BackgroundImage = Image.FromFile(@"Imagens\soundOff.ico");
                buttonSound.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                musicaOnOff = true;
                musica.Play();
                buttonSound.BackgroundImage = N2.Properties.Resources.soundOn;
            }
        }

        //Evento gerado ao mudar a seleção do comboBox do jogo
        private void cmbEscolhaTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSortearPalavra.Enabled = true;
            if (primeiraPartida)
            {
                picSeta.Location = new Point(155, 56);
                animacao.Image = N2.Properties.Resources.DeInicio;
            }
            else
            {
                picSeta.Image = null;
            }
        }

        /*Evento click do button Começar jogo
        Caso consiga sortar a palavra pelo método atualiza os controles
        Mostra uma tela de dica
        Muda a imagem do jogo
        Mostra os buttons correspondentes a palavra na tela
        e inicia o timer*/
        private void btnSortearPalavra_Click(object sender, EventArgs e)
        {
            if (SortearPalavra())
            {

                int quantidadeLetras = 0;
                chances = 5;
                txtChances.Text = chances.ToString();
                btnSortearPalavra.Enabled = false;
                cmbEscolhaTema.Enabled = false;
                habilitaControles();
                primeiraPartida = false;



                animacao.Image = N2.Properties.Resources._1_0;
                picSeta.Visible = false;


                IniciaJogo.ShowDialog();


                for (int i = 0; i < palavraSorteada.Length; i++)
                {
                    if (palavraSorteada[i] != ' ')
                        buttonArray[i].Visible = true;
                    else
                        quantidadeLetras--;
                }
                quantidadeLetras += palavraSorteada.Length;

                lblQuantidade.Visible = true;
                lblQuantidade.Text = quantidadeLetras.ToString() + " Letras";

                jogando = true;
                btnDica.Enabled = true;

                timerDoJogo.Interval = 1000;
                timerDoJogo.Start();
            }
            else
                return;
        }

        /*Evento keyPress do form
        Verifica a variavel jogando
        Verifica se a tecla digitada esta entre os intervalos da tabela ascii de letras
        caso sim para as duas, verifica cada letra da palavra sorteada e muda caso a mesma possua acentuação
        coloca a letra em caixa alta e verifica se a letra digitada, também em caixa alta, é igual a da palavra sorteada
        se sim, apresenta a letra no button correspondente da palavra
        se não, apresenta mensagem de erro e decrementa 10 segundos do jogo*/
        private void Jogar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (jogando && Convert.ToChar(e.KeyChar.ToString().ToUpper()) >= 65 && Convert.ToChar(e.KeyChar.ToString().ToUpper()) <= 90)
            {
                for (int i = 0; i < palavraSorteada.Length; i++)
                {
                    palavraSorteada = palavraSorteada.Replace('ó', 'o');
                    palavraSorteada = palavraSorteada.Replace('ô', 'o');
                    palavraSorteada = palavraSorteada.Replace('á', 'a');
                    palavraSorteada = palavraSorteada.Replace('ã', 'a');
                    palavraSorteada = palavraSorteada.Replace('é', 'e');
                    palavraSorteada = palavraSorteada.Replace('ê', 'e');
                    palavraSorteada = palavraSorteada.Replace('í', 'i');
                    palavraSorteada = palavraSorteada.Replace('ç', 'c');

                    if (palavraSorteada[i].ToString().ToUpper() == e.KeyChar.ToString().ToUpper())
                    {
                        buttonArray[i].Text = e.KeyChar.ToString().ToUpper();
                        verButtons();
                    }
                }

                if (txtLetras.Text.IndexOf(e.KeyChar.ToString().ToUpper()) == -1 && cmbEscolhaTema.Enabled == false)
                {
                    txtLetras.Text += e.KeyChar.ToString().ToUpper();
                    if (palavraSorteada.ToLower().IndexOf(e.KeyChar.ToString().ToLower()) == -1)
                    {
                        erros++;
                        if (erros < 6)
                            MessageBox.Show(erros.ToString() + "º Erro\n-10 segundos", "Letra Errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            timerDoJogo.Stop();
                        }
                        animacaoDosErros(erros);
                    }
                }
                txtChances.Text = chances.ToString();
            }
        }

        /*Verifica se todas as letras da palavra sorteada estão preenchidas
        Se sim, cria form filho para salvar resultado*/
        private void verButtons()
        {
            bool acabou = true;
            for (int i = 0; i < buttonArray.Length; i++)
            {
                if (buttonArray[i].Visible == true && buttonArray[i].Text == "")
                    acabou = false;
            }
            if (acabou)
            {
                timerDoJogo.Stop();

                SalvaRecorde telaDeRecorde = new SalvaRecorde();
                telaDeRecorde.tempo = (100 - tempo).ToString();
                telaDeRecorde.palavra = palavraSorteada;
                telaDeRecorde.ShowDialog();

                if (MessageBox.Show("Deseja uma nova partida?", "Nova Partida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    this.Close();
                }
                CarregaDados();
                cmbEscolhaTema.Enabled = true;
            }
        }

        //Método que apresenta mensagens de game over pelo tempo ou pelos erros de letras, dependendo do parametro passado
        private void gameOver(int valor)
        {
            jogando = false;
            timerDoJogo.Stop();
            txtTempo.Text = "0";
            if (valor == 0)
                MessageBox.Show("Acabou o tempo!\nGAME OVER", "GAME OVER");
            else
                MessageBox.Show("Acabaram suas chances!\nGAME OVER", "GAME OVER");
            if (MessageBox.Show("Deseja uma nova partida?", "Nova Partida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                this.Close();
            }
            CarregaDados();
            cmbEscolhaTema.Enabled = true;
        }

        //Evento do timer do jogo
        private void timerDoJogo_Tick(object sender, EventArgs e)
        {
            if (tempo > 1)
            {
                tempo--;
                txtTempo.Text = tempo.ToString();
            }
            else
            {
                gameOver(0);
            }
        }

        //Evento do timer da animação dos gifs
        private void timerDaAnimacao_Tick(object sender, EventArgs e)
        {
            timerDaAnimacao.Stop();
            if (erros == 6)
            {
                MessageBox.Show(erros.ToString() + "º Erro\nFim de Jogo", "Letra Errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timerDaAnimacao.Start();
                erros++;
            }
            else
                timerDaAnimacao.Start();
            if (imagensDaAnimacao <= pararNaImagem)
            {
                animacao.Image = Image.FromFile(imagensDaAnimacaoGif[imagensDaAnimacao]);
                imagensDaAnimacao++;
            }
            else
            {
                timerDaAnimacao.Stop();
                if (erros > 6)
                    gameOver(1);
            }
        }

        //Evento click do button Dica, exibe um messageBox e um textBox com a dica, decrementa 10 segundos
        private void btnDica_Click(object sender, EventArgs e)
        {
            txtDica.Visible = true;
            txtDica.Text = dica;
            MessageBox.Show("Dica:\n " + dica + "\n\n -10 segundos");
            tempo -= 10;
        }
    }
}
