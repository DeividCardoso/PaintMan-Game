using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N2
{
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        #region Variaveis Globais

        string adicionarPalavras;
        public string[] temas;
        public string[] palavras;
        int posicao;
        int pipingInicio, pipingFim;

        #endregion

        private void Cadastros_Load(object sender, EventArgs e)
        {
            CarregarTemas();
        }


        //Método que salva novo tema
        private void SalvarNovoTema()
        {
            int localizacao;

            localizacao = lstTemas.SelectedIndex;
            File.AppendAllText("Temas.txt", localizacao.ToString() + "|" + txtAdicionarTema.Text + Environment.NewLine);
        }

        //Metodo que limpa todos os controles do form
        private void LimparRegistros()
        {
            cmbEscolhaTemaAlterarPalavra.Items.Clear();
            cmbEscolhaTemaPalavra.Items.Clear();
            cmbEscolhaTemaTemas.Items.Clear();
            lstTemas.Items.Clear();
            txtAlterarTema.Clear();
            txtAdicionarTema.Clear();
            txtAlterarPalavra.Clear();
            txtAlterarDica.Clear();

            cmbEscolhaTemaAlterarPalavra.Items.Clear();
            cmbEscolhaPalavraAlterar.Items.Clear();

            lstPalavras.Items.Clear();

            txtAlterarTema.Enabled = false;
            txtAdicionarPalavra.Enabled = false;
            txtAdicionarDica.Enabled = false;
            txtAlterarPalavra.Enabled = false;
            txtAlterarDica.Enabled = false;
        }

        //Método que busca arquivo de texto Temas.txt e atualiza os controles do form
        private void CarregarTemas()
        {
            LimparRegistros();

            if (File.Exists("Temas.txt"))
            {
                temas = File.ReadAllLines("Temas.txt");
                for (int i = 0; i < temas.Length; i++)
                {
                    posicao = temas[i].LastIndexOf("|");
                    lstTemas.Items.Add(temas[i].Substring(posicao + 1));
                    cmbEscolhaTemaTemas.Items.Add(temas[i].Substring(posicao + 1));
                    cmbEscolhaTemaAlterarPalavra.Items.Add(temas[i].Substring(posicao + 1));
                    cmbEscolhaTemaPalavra.Items.Add(temas[i].Substring(posicao + 1));
                }
            }
            else if (File.Exists("Palavras.txt"))
                File.Delete("Palavras.txt");
        }

        /*Evento do button Add.
        Valida a textBox do tema
        Verifica se o tema ja existe no cadastro
        Caso não, adiciona ao listBox e seleciona a palavra para gerar evento SelectedIndexChanged  */
        private void btnAdicionarTema_Click(object sender, EventArgs e)
        {
            if (!ValidaTexto(txtAdicionarTema.Text))
            {
                MessageBox.Show("Preencha o campo para adicionar novo tema!");
                return;
            }
            else
            {
                if (lstTemas.FindString(txtAdicionarTema.Text) == -1)
                {
                    lstTemas.Items.Add(txtAdicionarTema.Text);
                    lstTemas.SetSelected(lstTemas.FindString(txtAdicionarTema.Text), true);
                }
                else
                    MessageBox.Show("Tema já exite no cadastro");
            }
        }

        //Evento gerado ao mudar a seleção do listBox
        private void lstTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalvarNovoTema();
            CarregarTemas();
        }


        //Método para validar as textBox
        private bool ValidaTexto(string caixaDeTexto)
        {
            caixaDeTexto = caixaDeTexto.Trim();
            if (caixaDeTexto.Length <= 0)
                return false;
            else
                return true;
        }


        //Evento de mudança de seleção no comboBox
        private void cmbEscolhaTemaTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAlterarTema.Enabled = true;
            txtAlterarTema.Text = cmbEscolhaTemaTemas.Text;
        }

        //Evento de click do buttonAlterar Tema
        private void btnAlterarTema_Click(object sender, EventArgs e)
        {
            if (!ValidaTexto(txtAlterarTema.Text))
            {
                MessageBox.Show("Este campo não pode estar vazio!");
                return;
            }

            else
            {
                posicao = lstTemas.FindString(cmbEscolhaTemaTemas.Text);
                if (File.Exists("Temas.txt"))
                {
                    temas = File.ReadAllLines("Temas.txt");
                    if (lstTemas.FindString(txtAlterarTema.Text) == -1)
                        temas[posicao] = posicao.ToString() + "|" + txtAlterarTema.Text;
                    else
                        MessageBox.Show("Tema já existe no cadastro!");
                    File.WriteAllLines("Temas.txt", temas);
                    CarregarTemas();
                }

            }
        }

        //Evento do button Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            CarregarTemas();
            return;
        }

        //Habilita os controles dependentes da seleção do comboBox
        private void cmbEscolhaTemaPalavra_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPalavras.Items.Clear();
            txtAdicionarPalavra.Enabled = true;
            txtAdicionarDica.Enabled = true;
            txtAdicionarPalavra.Clear();
            txtAdicionarDica.Clear();

            CarregarPalavras();
        }

        /*Evento click do buttonAdicionarNovaPalavra
        Valida as textBox
        Adiciona nova palavra e dica ao listBox e seleciona para gerar evento de seleção*/
        private void btnAdicionarNovaPalavra_Click(object sender, EventArgs e)
        {
            if (!ValidaTexto(txtAdicionarPalavra.Text) || !ValidaTexto(txtAdicionarDica.Text))
            {
                MessageBox.Show("Preenha os campos Palavra e Dica para adicionar!");
            }
            else
            {
                adicionarPalavras = txtAdicionarPalavra.Text + "|" + txtAdicionarDica.Text;
                if (lstPalavras.FindString(adicionarPalavras) == -1)
                {
                    lstPalavras.Items.Add(adicionarPalavras);
                    lstPalavras.SetSelected(lstPalavras.FindString(adicionarPalavras), true);
                    txtAdicionarPalavra.Clear();
                    txtAdicionarDica.Clear();
                }
                else
                    MessageBox.Show("Esta palavra já existe no tema escolhido!");
            }
        }

        //Salva nova palavra e atualiza o form
        private void lstPalavras_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalvarNovaPalavra();
            CarregarPalavras();
        }

        //Método para salvar nova palavra
        private void SalvarNovaPalavra()
        {
            if (File.Exists("Temas.txt"))
            {
                if (File.Exists("Palavras.txt"))
                {
                    posicao = palavras.Length;
                    File.AppendAllText("Palavras.txt", Environment.NewLine + posicao.ToString() + "|" + adicionarPalavras +
                    "|" + cmbEscolhaTemaPalavra.SelectedIndex);
                }
                else
                {
                    posicao = 0;
                    File.AppendAllText("Palavras.txt", posicao.ToString() + "|" + adicionarPalavras +
                   "|" + cmbEscolhaTemaPalavra.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Dados foram perdidos!");
                lstPalavras.Items.Clear();
                File.Delete("Palavras.txt");
                CarregarTemas();
            }
        }

        //Atualiza o vetor palavras com as linhas do txt
        private void CarregarPalavras()
        {
            lstPalavras.Items.Clear();
            if (File.Exists("Palavras.txt"))
            {              
                palavras = File.ReadAllLines("Palavras.txt");
                posicao = cmbEscolhaTemaPalavra.SelectedIndex;
                for (int i = 0; i < palavras.Length; i++)
                {
                    pipingInicio = palavras[i].LastIndexOf("|");
                    if (posicao == int.Parse(palavras[i].Substring(pipingInicio + 1)))
                    {
                        pipingInicio = palavras[i].IndexOf("|");
                        pipingFim = palavras[i].LastIndexOf("|");
                        lstPalavras.Items.Add(palavras[i].Substring(pipingInicio + 1, pipingFim - 1 - pipingInicio));                        
                    }
                }
            }
        }

        //Atualiza os controles de acordo com a seleção do comboBox
        private void cmbEscolhaTemaAlterarPalavra_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEscolhaPalavraAlterar.Items.Clear();
            txtAlterarPalavra.Clear();
            txtAlterarDica.Clear();

            if (File.Exists("Palavras.txt"))
            {
                int pipingInicio, pipingFim;
                palavras = File.ReadAllLines("Palavras.txt");
                posicao = cmbEscolhaTemaAlterarPalavra.SelectedIndex;
                for (int i = 0; i < palavras.Length; i++)
                {
                    pipingFim = palavras[i].LastIndexOf("|");
                    if (posicao == int.Parse(palavras[i].Substring(pipingFim + 1)))
                    {
                        pipingInicio = palavras[i].IndexOf("|");                        
                        pipingFim = palavras[i].IndexOf("|", pipingInicio + 1);
                        cmbEscolhaPalavraAlterar.Items.Add(palavras[i].Substring(pipingInicio + 1, pipingFim - 1 - pipingInicio));
                    }
                }
            }
        }

        /*Evento do button de alterar palavra
        Valida os textBox
        Verifica se documento existe
        Deleta o documento e cria um novo com as informações do array*/
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(!ValidaTexto(txtAlterarDica.Text) || !ValidaTexto(txtAlterarPalavra.Text))
            {
                MessageBox.Show("Preencha corretamente o campo Palavra e Dica!");
                return;
            }
            else
            {
                palavras[posicao] = posicao.ToString() + "|" + txtAlterarPalavra.Text +
                    "|" + txtAlterarDica.Text + "|" + cmbEscolhaTemaAlterarPalavra.SelectedIndex;


                if(File.Exists("Palavras.txt"))
                {
                    File.Delete("Palavras.txt");
                    for (int i = 0; i < palavras.Length; i++)
                    {
                        if (i != palavras.Length - 1)
                            File.AppendAllText("Palavras.txt", palavras[i] + Environment.NewLine);
                        else
                            File.AppendAllText("Palavras.txt", palavras[i]);
                    }
                }
                
                CarregarTemas();
            }
        }

        //Tecla para atualizar o form
        private void Cadastros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                CarregarTemas();
            }
        }

        //Atualiza os controles de acordo com a seleção do comboBox
        private void cmbEscolhaPalavraAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAlterarPalavra.Enabled = true;
            txtAlterarDica.Enabled = true;
            txtAlterarPalavra.Text = cmbEscolhaPalavraAlterar.Text;
            string dica;

            if(File.Exists("Palavras.txt"))
            {
                palavras = File.ReadAllLines("Palavras.txt");
                for(int i = 0; i < palavras.Length; i ++)
                {
                    pipingInicio = palavras[i].IndexOf("|") + 1;
                    pipingFim = palavras[i].IndexOf("|", pipingInicio);
                    dica = palavras[i].Substring(pipingInicio, pipingFim - pipingInicio);
                    if (dica == cmbEscolhaPalavraAlterar.Text)
                    {
                        pipingInicio = pipingFim + 1;
                        pipingFim = palavras[i].IndexOf("|", pipingInicio);
                        dica = palavras[i].Substring(pipingInicio, pipingFim - pipingInicio);
                        txtAlterarDica.Text = dica;
                        posicao = i;
                    }
                }
            }
            else
            {
                MessageBox.Show("Dados foram deletados!");
                File.Delete("Palavras.txt");
                File.Delete("Temas.txt");
                CarregarTemas();                
            }
        }
    }
}
