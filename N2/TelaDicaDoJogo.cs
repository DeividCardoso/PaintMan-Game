using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2
{
    public partial class TelaDicaDoJogo : Form
    {
        public TelaDicaDoJogo()
        {
            InitializeComponent();
        }
        

        private void TelaDicaDoJogo_Load(object sender, EventArgs e)
        {
        }

        //Evento click do button OK, apenas fecha o form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
