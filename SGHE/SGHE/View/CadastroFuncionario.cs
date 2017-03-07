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
           
            
        }

        private void funcionarioTB_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) && e.KeyChar != ',') {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) && e.KeyChar != ',') {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) && e.KeyChar != ',') {
                e.Handled = true;
            }
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e) {

        }

        private void salarioTB_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) && e.KeyChar != ',') {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
             if(funcionarioTB.Text == "" || salarioTB.Text == "") {
                MessageBox.Show("Valores dos campos estão nulos!");
            } else{
                panel1.Controls.Clear();
                CadastroHoras a = new CadastroHoras(funcionarioTB.Text, Convert.ToDouble(salarioTB.Text),
                                                    Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text),
                                                    Convert.ToDouble(textBox4.Text));                
                panel1.Controls.Add(a);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                button1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
