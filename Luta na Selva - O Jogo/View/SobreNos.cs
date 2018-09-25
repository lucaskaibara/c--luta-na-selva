using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class SobreNos : Form
    {
        public SobreNos()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            new TelaInicial().Show();
        }
    }
}
