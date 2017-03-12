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
using SGHE.Model;

namespace SGHE.View {
    public partial class CadastroHoras : UserControl {
        public int MinutosTrabalhados;
        private readonly int _minutoExtra;
        readonly List<DiaTrabalhado> _diasRegistrados = new List<DiaTrabalhado>();
        private readonly double _p1;
        private readonly double _p2;
        private readonly double _pN;
        private readonly double _salario;


        public CadastroHoras(string nomeFuncionario, double salario, double p1, double p2, double pN,  int minutoExtra) {
            InitializeComponent();
            MinutosTrabalhados = 0;
            labelNome.Text = nomeFuncionario;            
            labelSalario.Text = salario.ToString("0.00");
            _minutoExtra = minutoExtra;
            _p1 = p1;
            _p2 = p2;
            _pN = pN;
            _salario = salario;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (maskedTextBox1.Text == "  :" || maskedTextBox2.Text == "  :" ||
                maskedTextBox3.Text == "  :" || maskedTextBox4.Text == "  :") {
                MessageBox.Show("Digite uma entrada para a hora");
            }else {
                var horasTrabalhadasInicial = ControladorHoras.CalculaHoras(maskedTextBox1.Text, maskedTextBox2.Text, 
                    maskedTextBox3.Text, maskedTextBox4.Text);
                MessageBox.Show("Horas totais trabalhadas"+horasTrabalhadasInicial);

                var horasExtras = ControladorHoras.CalculaHorasExtras(horasTrabalhadasInicial, _minutoExtra);
                MessageBox.Show("Horas extras trabalhas"+horasExtras);

                var horasTrabalhadasNoite = ControladorHoras.IdentificaHorasNoturnas(maskedTextBox1.Text, maskedTextBox2.Text,
                    maskedTextBox3.Text, maskedTextBox4.Text);
                MessageBox.Show("Horas noturnas trabalhadas"+horasTrabalhadasNoite);

                var horasNoturnas = ControladorHoras.CalculaHorasNoturnas(horasTrabalhadasNoite);
                MessageBox.Show("Horas noturnas após transformação" + horasNoturnas);

                var horasTrabalhadasNormais = horasTrabalhadasInicial - horasTrabalhadasNoite;

                _diasRegistrados.Add(new DiaTrabalhado(horasExtras, horasTrabalhadasNormais, horasNoturnas));

            }
        }

        private void button2_Click(object sender, EventArgs e) {
            double valorSalario = 0;
            double valorSalarioExtra = 0;
            double valorSalarioNoturno = 0;

            foreach (var t in _diasRegistrados) {
                var valorHoraExtra = ControladorHoras.CalculaValorHoraExtra(t.HorasExtras, _p1, _p2, 
                    _minutoExtra, _salario);

                valorSalarioExtra += valorHoraExtra;

                var valorHoraNoturna = ControladorHoras.CalculaValorHoraNoturna(t.HorasNoturnas, 
                    _pN, _salario);

                valorSalarioNoturno += valorHoraNoturna;

                valorSalario += ControladorHoras.CalculaValorSalario(_salario, valorHoraExtra, valorHoraNoturna,
                    t.HorasNormais);
            }

            MessageBox.Show(@"Valor total do salario: " + valorSalario);

            MessageBox.Show(@"Valor total para horas extras: " + valorSalarioExtra);

            MessageBox.Show(@"Valor total para horas noturnas: " + valorSalarioNoturno);
        }
    }
}
