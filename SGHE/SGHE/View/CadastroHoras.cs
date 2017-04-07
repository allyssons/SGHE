using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                button1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (EntradaTB.Text == "  :" || SaidaTB.Text == "  :") {
                MessageBox.Show("Digite uma entrada para a hora");
            }else {
                var horasTrabalhadasInicial = 0;
                var horasTrabalhadasNoite = 0;
                var horasNoturnas = 0.0;
                var horasExtras = 0.0;
                var horasTrabalhadasNormais = 0.0;

                if (EntradaIntervalo.Text != "  :") { //HOUVE INTERVALO
                    horasTrabalhadasInicial = ControladorHoras.CalculaHoras(EntradaTB.Text, EntradaIntervalo.Text,
                        SaidaIntervalo.Text, SaidaTB.Text);
                    //MessageBox.Show("Horas totais trabalhadas"+horasTrabalhadasInicial);

                    horasTrabalhadasNoite = ControladorHoras.IdentificaHorasNoturnas(EntradaTB.Text,
                        EntradaIntervalo.Text,
                        SaidaIntervalo.Text, SaidaTB.Text);
                   // MessageBox.Show("Horas noturnas trabalhadas"+horasTrabalhadasNoite);

                    horasNoturnas = ControladorHoras.CalculaHorasNoturnas(horasTrabalhadasNoite);
                   // MessageBox.Show("Horas noturnas após transformação" + horasNoturnas);

                    horasExtras = ControladorHoras.CalculaHorasExtras((horasTrabalhadasInicial - horasTrabalhadasNoite) 
                                                                      + horasNoturnas, _minutoExtra, 
                                                                      EntradaTB.Text, EntradaIntervalo.Text,
                                                                      SaidaIntervalo.Text, SaidaTB.Text);

                   // MessageBox.Show("Horas extras trabalhas"+horasExtras);

                    horasTrabalhadasNormais = (horasTrabalhadasInicial - horasTrabalhadasNoite) - horasExtras;
                }
                else { //NAO HOUVE INTERVALO
                    horasTrabalhadasInicial = ControladorHoras.CalculaHoras(EntradaTB.Text, SaidaTB.Text); 
                   // MessageBox.Show("Horas totais trabalhadas"+horasTrabalhadasInicial);

                   horasTrabalhadasNoite = ControladorHoras.IdentificaHorasNoturnas(EntradaTB.Text, SaidaTB.Text);
                    //MessageBox.Show("Horas noturnas trabalhadas"+horasTrabalhadasNoite);

                    horasNoturnas = ControladorHoras.CalculaHorasNoturnas(horasTrabalhadasNoite);
                    //MessageBox.Show("Horas noturnas após transformação" + horasNoturnas);

                    horasExtras = ControladorHoras.CalculaHorasExtras((horasTrabalhadasInicial - horasTrabalhadasNoite) 
                                                                        + horasNoturnas, _minutoExtra);

                    //MessageBox.Show("Horas extras trabalhas"+horasExtras);
                
                    horasTrabalhadasNormais = (horasTrabalhadasInicial - horasTrabalhadasNoite) - horasExtras;
                }
                

                _diasRegistrados.Add(new DiaTrabalhado(horasExtras, horasTrabalhadasNormais, horasNoturnas));

                int day = monthCalendar1.SelectionRange.Start.Day;
                int month = monthCalendar1.SelectionRange.Start.Month;
                int year = monthCalendar1.SelectionRange.Start.Year;

                string data = day + "/" + month + "/" + year;

                int horas = (int)(((horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas) / 60);

                double a = ((horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas) / 60;

                a = a - horas;

                int minutos = (int)(a / 0.016667);

                DateTime date1 = new DateTime(year, month, day, horas, minutos, 0);
                var horaNormal = date1.ToString("t",
                                  CultureInfo.CreateSpecificCulture("pt-br"));

                /////////////////////////

                horas = (int)(horasExtras / 60);

                a = (horasExtras / 60);

                a = a - horas;

                minutos = (int)(a / 0.016667);

                DateTime date2 = new DateTime(year, month, day, horas, minutos, 0);
                var horaExtra = date2.ToString("t",
                                  CultureInfo.CreateSpecificCulture("pt-br"));
                /////////////////////////

                horas = (int)(horasNoturnas / 60);

                a = (horasNoturnas / 60);

                a = a - horas;

                minutos = (int)(a / 0.016667);

                DateTime date3 = new DateTime(year, month, day, horas, minutos, 0);
                var horaNoite = date3.ToString("t",
                                  CultureInfo.CreateSpecificCulture("pt-br"));


                dataGridView1.Rows.Add(data, horaNormal, horaExtra, horaNoite);

                if (month == 2 && year % 4 == 0) {
                    if (day == 29) {
                        day = 1;
                        month++;
                    }
                    else day++;
                }else if (month == 2 && year % 4 != 0) {
                    if (day == 28) {
                        day = 1;
                        month++;
                    }
                    else day++;
                } else if (month == 4 || month == 6 || month == 9 || month == 11) {
                    if (day == 30) {
                        day = 1;
                        month++;
                    }
                    else day++;
                }
                else {
                    if (day == 31) {
                        day = 1;
                        if (month == 12) {
                            month = 1;
                            year++;
                        }
                        else month++;
                    }
                    else day++;
                }

                DateTime d = new DateTime(year, month, day);


                monthCalendar1.SetDate(d);
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
