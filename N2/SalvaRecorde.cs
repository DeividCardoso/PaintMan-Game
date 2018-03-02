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
    public partial class SalvaRecorde : Form
    {
        public SalvaRecorde()
        {
            InitializeComponent();
        }

        #region Variaveis Globais
        //Variaveis passadas ao form
        public string tempo;
        public string palavra;

        //Variavel global para uso dos métodos deste form
        string palavraModificada;
        int idPalavra;
        int pipingInicio, pipingFim;
        int rec;
        string textoAuxiliar;
        int auxiliar;
        int j;

        //Arrays para trabalhar com arquivos
        string[] recordes;
        string[] palavras;
        string[] novasPosicoes;

        #endregion

        //Evento load do form, inicializa as variaveis e chama métodos para atualizar os controles do form
        private void SalvaRecorde_Load(object sender, EventArgs e)
        {
            txtPalavra.Text = palavra;
            txtTempo.Text = tempo;
            pegaId();
            pegaPosicao();
            txtPosicao.Text = (pegaPosicao() + 1).ToString() + "º";
        }

        /*Método que pega o id da palavra que foi sorteada
        verifica se os arquivos existem 
        se sim, salva as palavras em um array e muda cada letra que possua acentuação
        verifica se a palavra passada ao form pelo form pai é corresnpondente a do arquivo
        se sim, pega o index dessa palavra e salva na variavel idPalavra*/
        private void pegaId()
        {
            if (File.Exists("Palavras.txt") && File.Exists("Temas.txt"))
            {
                palavras = File.ReadAllLines("Palavras.txt");
                for (int i = 0; i < palavras.Length; i++)
                {
                    pipingInicio = palavras[i].IndexOf("|") + 1;
                    pipingFim = palavras[i].IndexOf("|", pipingInicio);
                    palavraModificada = palavras[i].Substring(pipingInicio, pipingFim - pipingInicio);
                    palavraModificada = palavraModificada.Replace('ó', 'o');
                    palavraModificada = palavraModificada.Replace('ô', 'o');
                    palavraModificada = palavraModificada.Replace('á', 'a');
                    palavraModificada = palavraModificada.Replace('ã', 'a');
                    palavraModificada = palavraModificada.Replace('é', 'e');
                    palavraModificada = palavraModificada.Replace('ê', 'e');
                    palavraModificada = palavraModificada.Replace('í', 'i');
                    palavraModificada = palavraModificada.Replace('ç', 'c');
                    if (palavraModificada == palavra)
                    {
                        pipingInicio = palavras[i].IndexOf("|");
                        idPalavra = int.Parse(palavras[i].Substring(0, pipingInicio));
                    }
                }
            }
            else
            {
                MessageBox.Show("Os dados foram apagados!");
                this.Close();
            }
        }

        /*Método para pegar a colocação do usuário nos recordes
        verifica se o arquivo de recorde existe
        se sim, salva todos em um array, cria um novo array para salvar as novas colocações
        verifica se o tempo do usuario é menor do que cada elemento do salvo no array de recordes
        se não, copia o valor do elemento do recordes no elemento do array de novas colocações
        caso seja menor, salvo o resultado do usuário no array de novas posições e incrementa um elemento, 
            salvando os outros resultados depois deste*/
        private int pegaPosicao()
        {
            int posicaoDoRecorde = 0;
            bool eMaior = false;
            j = 0;
            if (File.Exists("Recordes.txt"))
            {
                recordes = File.ReadAllLines("Recordes.txt");
                novasPosicoes = new string[recordes.Length + 1];
                for (int i = 0; i < recordes.Length; i++)
                {
                    pipingFim = recordes[i].IndexOf("|") + 1;
                    pipingInicio = recordes[i].IndexOf("|", pipingFim) + 1;
                    pipingFim = recordes[i].IndexOf("|", pipingInicio);
                    rec = int.Parse(recordes[i].Substring(pipingInicio, pipingFim - pipingInicio));

                    if (int.Parse(tempo) >= rec && eMaior == false)
                    {
                        novasPosicoes[j] = recordes[i];
                        j++;
                        eMaior = false;
                    }
                    else if (eMaior == false)
                    {
                        novasPosicoes[j] = i.ToString() + "|" + txtJogador.Text + "|" + tempo + "|" + idPalavra;
                        eMaior = true;
                        posicaoDoRecorde = i;
                        j++;
                    }

                    if (eMaior)
                    {
                        pipingFim = recordes[i].IndexOf("|");
                        auxiliar = int.Parse(recordes[i].Substring(0, pipingFim));
                        auxiliar++;
                        textoAuxiliar = recordes[i].Substring(pipingFim);
                        recordes[i] = auxiliar.ToString() + textoAuxiliar;
                        novasPosicoes[j] = recordes[i];
                        j++;
                    }

                }
                bool verificaSalvo = false;
                for (int i = 0; i < novasPosicoes.Length; i++)
                {
                    if (novasPosicoes[i] == i.ToString() + "|" + txtJogador.Text + "|" + tempo + "|" + idPalavra)
                    {
                        verificaSalvo = true;
                    }

                }
                if (!verificaSalvo)
                {
                    novasPosicoes[novasPosicoes.Length - 1] = (novasPosicoes.Length - 1).ToString() + "|" + txtJogador.Text + "|" + tempo + "|" + idPalavra;
                    return novasPosicoes.Length - 1;
                }
                return posicaoDoRecorde;
            }
            else
                return 0;

        }

        //Evento do button Cancelar, apenas fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Evento click do button salvar
        Valida o campo textBox
        verifica se o arquivo recordes existe, 
        se sim, chama método pegaPosicao(), que salva as informações dos recordes em um array
            apaga o arquivo de recordes salvo, e cria um novo, com as informações deste array
            
        se não, cria um novo arquivo recordes, com as informações do usuário*/
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            txtJogador.Text = txtJogador.Text.Trim();
            if (txtJogador.Text == "")
            {
                MessageBox.Show("Preencha o campo Jogador para salvar seu resultado");
                return;
            }
            else
            {
                pegaPosicao();
                if(File.Exists("Recordes.txt"))
                {
                    File.Delete("Recordes.txt");
                    File.AppendAllLines("Recordes.txt", novasPosicoes);
                }
                else
                {
                    novasPosicoes = new string[1];
                    novasPosicoes[0] = (novasPosicoes.Length - 1).ToString() + "|" + txtJogador.Text + "|" + tempo + "|" + idPalavra;
                    File.AppendAllLines("Recordes.txt", novasPosicoes);
                }

            }
            this.Close();
        }

    }
}
