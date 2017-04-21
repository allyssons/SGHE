using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGHE.Controller;

namespace SGHE.View {
    public partial class CadastroFuncionario : UserControl {
        private readonly Panel _panel1;
        public CadastroFuncionario(Panel panel) {
            _panel1 = panel;
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, e) => {
                funcionarioTB.Select();
                timer.Stop();
            };
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e) {
           
            
        }

        private void funcionarioTB_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char) Keys.Space);
        }


        private void CadastroFuncionario_Load(object sender, EventArgs e) {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                button1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }





        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (funcionarioTB.Text == "" || salarioTB.Text == "") {
                MessageBox.Show("Valores dos campos estão nulos!");
            } else {
                if (saldoTB.Text == "  :" || (Positivo.Checked == false && Negativo.Checked == false)) {
                    MessageBox.Show("Informe o valor do saldo anterior do funcionário");
                } else {
                    int horaSaldo = ControladorHoras.ConverteTextHora(saldoTB.Text);
                    int minutoSaldo = ControladorHoras.ConverteTextMinuto(saldoTB.Text);

                    int saldo = horaSaldo * 60 + minutoSaldo;
                    if (Negativo.Checked) saldo *= -1;

                    string text1 = horaTB.Text;
                    _panel1.Controls.Clear();
                    string horaA = text1.Split(':')[0];
                    string minutoA = text1.Split(':')[1];
                    int hora1 = Int32.Parse(horaA);
                    int minuto1 = 0;
                    if (minutoA == "") minuto1 = 0;
                    else minuto1 = Int32.Parse(minutoA);

                    minuto1 += hora1 * 60;
                    CadastroHoras a = new CadastroHoras(funcionarioTB.Text, Convert.ToDouble(salarioTB.Text),
                                                        Convert.ToDouble(primeiraHETB.Text), Convert.ToDouble(heTB.Text),
                                                        Convert.ToDouble(hnTB.Text), minuto1, Convert.ToInt32(horasMensais.Text),
                                                        Convert.ToDouble(henTB.Text), Convert.ToDouble(fdsTB.Text), saldo, _panel1);
                    _panel1.Controls.Add(a);
                }
            }
        }

        private void salarioTB_KeyPress_1(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }
    }
}
