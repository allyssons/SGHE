using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGHE.View {
    public partial class CadastroFuncionario : UserControl {
        Panel panel1;
        public CadastroFuncionario(Panel panel) {
            panel1 = panel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            CadastroHoras a = new CadastroHoras();
            panel1.Controls.Add(a);
        }
    }
}
