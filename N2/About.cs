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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //Unico button do form, fecha o form
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
