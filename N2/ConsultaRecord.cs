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
    public partial class ConsultaRecord : Form
    {
        #region Variaveis Globais
        int pipinginicio, pipingFim;

        string[] recordes;
        string[] palavras;
        #endregion

        public ConsultaRecord()
        {
            InitializeComponent();
        }

        //Chama método para atualizar o dataGridView
        private void ConsultaRecord_Load(object sender, EventArgs e)
        {
            carregarTabela();
        }

        /*Verifica se existe recordes salvos e txt das palavras
        Se sim, atualiza o dataGridView com as informações do txt*/
        private void carregarTabela()
        {
            int indexRecorde, indexPalavra, classificacao;
            if (File.Exists("Recordes.txt") && File.Exists("Palavras.txt"))
            {
                palavras = File.ReadAllLines("Palavras.txt");
                recordes = File.ReadAllLines("Recordes.txt");
                for (int i = 0; i < recordes.Length; i++)
                {
                    dtGridRecordes.Rows.Add();
                    pipinginicio = recordes[i].IndexOf("|");
                    classificacao = int.Parse( recordes[i].Substring(0, pipinginicio));
                    dtGridRecordes.Rows[i].Cells[0].Value = classificacao + 1;

                    pipinginicio++;
                    pipingFim = recordes[i].IndexOf("|", pipinginicio);
                    dtGridRecordes.Rows[i].Cells[1].Value = recordes[i].Substring(pipinginicio, pipingFim - pipinginicio);

                    pipinginicio = pipingFim + 1;
                    pipingFim = recordes[i].IndexOf("|", pipinginicio);
                    dtGridRecordes.Rows[i].Cells[2].Value = recordes[i].Substring(pipinginicio, pipingFim - pipinginicio) + " Segundos";

                    pipingFim++;
                    indexRecorde = int.Parse(recordes[i].Substring(pipingFim));

                    for(int j = 0; j < palavras.Length; j++)
                    {
                        pipinginicio = palavras[j].IndexOf("|");
                        indexPalavra = int.Parse(palavras[j].Substring(0, pipinginicio));

                        if (indexRecorde == indexPalavra)
                        {
                            pipinginicio = palavras[j].IndexOf("|") + 1;
                            pipingFim = palavras[j].IndexOf("|", pipinginicio);
                            dtGridRecordes.Rows[i].Cells[3].Value = palavras[j].Substring(pipinginicio, pipingFim - pipinginicio);
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("Nao exitem recordes salvos");
                this.Close();
            }
        }



    }
}
