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
    public partial class CadastroHoras : UserControl {
        int minutosTrabalhados;
        public CadastroHoras(string nomeFuncionario, double salario, double p1, double p2, double pN) {
            InitializeComponent();
            labelNome.Text = nomeFuncionario;            
            labelSalario.Text = salario.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (maskedTextBox1.Text == "  :" || maskedTextBox2.Text == "  :" ||
                maskedTextBox3.Text == "  :" || maskedTextBox4.Text == "  :") {
                MessageBox.Show("Digite uma entrada para a hora");
            }else {
                
            }
        }

        public int converteHorasParaMinutos(string text1, string text2, string text3, string text4) {
            string horaA = text1.Split(':')[0];
            string minutoA = text1.Split(':')[1];
            int hora1 = Int32.Parse(horaA);
            int minuto1 = Int32.Parse(minutoA);

            string horaB = text2.Split(':')[0];
            string minutoB = text2.Split(':')[1];
            int hora2 = Int32.Parse(horaB);
            int minuto2 = Int32.Parse(minutoB);

            string horaC = text3.Split(':')[0];
            string minutoC = text3.Split(':')[1];
            int hora3 = Int32.Parse(horaC);
            int minuto3 = Int32.Parse(minutoC);

            string horaD = text4.Split(':')[0];
            string minutoD = text4.Split(':')[1];
            int hora4 = Int32.Parse(horaD);
            int minuto4 = Int32.Parse(minutoD);

            if(hora2 < hora1) {
                
            }

            return (hora1 * 60 + minuto1);
        }
    }
}
