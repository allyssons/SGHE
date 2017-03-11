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
    public partial class CadastroHoras : UserControl {
        int minutosTrabalhados;
        private int minutoExtra;
        public CadastroHoras(string nomeFuncionario, double salario, double p1, double p2, double pN,  int minutoExtra) {
            InitializeComponent();
            labelNome.Text = nomeFuncionario;            
            labelSalario.Text = salario.ToString("0.00");
            this.minutoExtra = minutoExtra;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (maskedTextBox1.Text == "  :" || maskedTextBox2.Text == "  :" ||
                maskedTextBox3.Text == "  :" || maskedTextBox4.Text == "  :") {
                MessageBox.Show("Digite uma entrada para a hora");
            }else {
                int a = ControladorHoras.calculaHoras(maskedTextBox1.Text, maskedTextBox2.Text, 
                    maskedTextBox3.Text, maskedTextBox4.Text);
                MessageBox.Show("Horas totais trabalhadas"+a);
                int b = ControladorHoras.calculaHorasExtras(a, minutoExtra);
                MessageBox.Show("Horas extras trabalhas"+b);
                int c = ControladorHoras.identificaHorasNoturnas(maskedTextBox1.Text, maskedTextBox2.Text,
                    maskedTextBox3.Text, maskedTextBox4.Text);
                MessageBox.Show("Horas noturnas trabalhadas"+c);
                int d = ControladorHoras.calculaHorasNoturnas(c);
                MessageBox.Show("Horas noturnas após transformação" + c);
            }
        }
    }
}
