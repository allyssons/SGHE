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
        private bool flagPeriod;
        private List<DateTime> feriados;
        private int diasUteis;
        private readonly int _minutoExtra;
        readonly List<DiaTrabalhado> _diasRegistrados = new List<DiaTrabalhado>();
        private readonly double _p1;
        private readonly double _p2;
        private readonly double _pN;
        private readonly double _pEn;
        private readonly double _salario;
        private double _horasExtrasNoturnas;
        private readonly Panel _panel1;
        private readonly int _horasMensais;
        private int dayPeriod;
        private int monthPeriod;
        private int yearPeriod;

        public CadastroHoras(string nomeFuncionario, double salario, 
                            double p1, double p2, double pN,  int minutoExtra, 
                            int horasMensais, double pEn, Panel panel1) {
            InitializeComponent();
            MinutosTrabalhados = 0;
            dayPeriod = 0;
            monthPeriod = 0;
            yearPeriod = 0;
            flagPeriod = true;
            diasUteis = 0;
            _panel1 = panel1;
            labelNome.Text = nomeFuncionario;            
            labelSalario.Text = "R$" + salario.ToString("0.00");
            _minutoExtra = minutoExtra;
            _p1 = p1;
            _p2 = p2;
            _pN = pN;
            _pEn = pEn;
            _salario = salario/horasMensais;
            _horasExtrasNoturnas = 0;
            _horasMensais = horasMensais;
            feriados = new List<DateTime>();
            listFeriados(Convert.ToDateTime(DateTime.Now.ToString()).Year.ToString());
            SetCaixa();
        }

        private void SetCaixa() {

            Timer timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, e) => {
                EntradaTB.Select();
                timer.Stop();
            };
            timer.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                button1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void button2_Click(object sender, EventArgs e) {
            double valorSalario = 0;
            double valorSalarioExtra = 0;
            double valorSalarioNoturno = 0;

            if(saldoTB.Text == "  :" || (Positivo.Checked == false && Negativo.Checked == false)){
                MessageBox.Show("Informe o valor do saldo anterior do funcionário");
            }else {
                int horaSaldo = ControladorHoras.ConverteTextHora(saldoTB.Text);
                int minutoSaldo = ControladorHoras.ConverteTextMinuto(saldoTB.Text);

                int saldo = horaSaldo * 60 + minutoSaldo;
                if (Negativo.Checked) saldo *= -1;

                double horasExtrasTotais = 0;
                double horasNoturnasTotais = 0;
                double horasTrabalhadasTotais = 0;

                foreach (var t in _diasRegistrados) {
                    var valorHoraExtra = ControladorHoras.CalculaValorHoraExtra(t.HorasExtras, _p1, _p2,
                        _minutoExtra, _salario);

                    horasExtrasTotais += t.HorasExtras;

                    valorSalarioExtra += valorHoraExtra;

                    var valorHoraNoturna = ControladorHoras.CalculaValorHoraNoturna(t.HorasNoturnas,
                        _pN, _salario, _pEn, t.HorasExtrasNoturnas);

                    horasNoturnasTotais += t.HorasNoturnas;

                    valorSalarioNoturno += valorHoraNoturna;

                    valorSalario += ControladorHoras.CalculaValorSalario(_salario, valorHoraExtra, valorHoraNoturna,
                        t.HorasNormais);

                    horasTrabalhadasTotais += t.HorasTotaisTrabalhadas;
                }

                int day = monthCalendar1.SelectionRange.Start.Day;
                int month = monthCalendar1.SelectionRange.Start.Month;
                int year = monthCalendar1.SelectionRange.Start.Year; ;

                DateTime dateIni = new DateTime(yearPeriod, monthPeriod, dayPeriod, 0, 0, 0);

                DateTime dateFin = new DateTime(year, month, day, 0, 0, 0);

                _panel1.Controls.Clear();
                Relatorio a = new Relatorio(labelNome.Text, saldo, _horasMensais, diasUteis, horasTrabalhadasTotais, horasExtrasTotais, horasNoturnasTotais,
                                            valorSalario, valorSalarioExtra, valorSalarioNoturno, dateIni, dateFin);
                _panel1.Controls.Add(a);

            }

            
        }

        private void labelNome_Click(object sender, EventArgs e) {

        }

        private void listFeriados(string anoS) {
            int ano = Int32.Parse(anoS);
            Calendario c = new Calendario(ano);
            c = ControladorFeriados.CarregaFeriados(c);
            for(int i = 0; i < c.Feriados.Count; i++) {
                feriados.Add(new DateTime(ano, c.Feriados.ElementAt(i).Mes+1, c.Feriados.ElementAt(i).Dia+1, 0, 0, 0));
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            var horasTrabalhadasInicial = 0;
            var horasTrabalhadasNoite = 0;
            var horasNoturnas = 0.0;
            var horasExtras = 0.0;
            var horasTrabalhadasNormais = 0.0;
            if (EntradaTB.Text == "  :" || SaidaTB.Text == "  :") {
                _horasExtrasNoturnas = 0;
                
            } else {
                _horasExtrasNoturnas = 0;

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

                    horasExtras = ControladorHoras.CalculaHorasExtras(horasTrabalhadasInicial, _minutoExtra,
                                                                      EntradaTB.Text, EntradaIntervalo.Text,
                                                                      SaidaIntervalo.Text, SaidaTB.Text);
                    // MessageBox.Show("Horas extras trabalhas" + horasExtras);

                    if (horasExtras > 0)
                        _horasExtrasNoturnas = ControladorHoras.CalculaHorasExtrasNoturnas(EntradaTB.Text,
                                                                                           EntradaIntervalo.Text,
                                                                                           SaidaIntervalo.Text, SaidaTB.Text);
                    if (_horasExtrasNoturnas != 0) {
                        horasExtras += _horasExtrasNoturnas - horasExtras;
                    }
                    // MessageBox.Show("Horas extras noturnas" + _horasExtrasNoturnas);

                    horasTrabalhadasNormais = (horasTrabalhadasInicial - horasTrabalhadasNoite) - horasExtras;

                    if (horasTrabalhadasNormais < 0) horasTrabalhadasNormais = 0;

                } else { //NAO HOUVE INTERVALO
                    horasTrabalhadasInicial = ControladorHoras.CalculaHoras(EntradaTB.Text, SaidaTB.Text);
                    //MessageBox.Show("Horas totais trabalhadas"+horasTrabalhadasInicial);

                    horasTrabalhadasNoite = ControladorHoras.IdentificaHorasNoturnas(EntradaTB.Text, SaidaTB.Text);
                    //MessageBox.Show("Horas noturnas trabalhadas"+horasTrabalhadasNoite);

                    horasNoturnas = ControladorHoras.CalculaHorasNoturnas(horasTrabalhadasNoite);
                    //MessageBox.Show("Horas noturnas após transformação" + horasNoturnas);

                    horasExtras = ControladorHoras.CalculaHorasExtras(horasTrabalhadasInicial, _minutoExtra);

                    //MessageBox.Show("Horas extras trabalhas"+horasExtras);

                    if (horasExtras > 0)
                        _horasExtrasNoturnas = ControladorHoras.CalculaHorasExtrasNoturnas(EntradaTB.Text,
                                                                                           SaidaTB.Text);
                    if (_horasExtrasNoturnas != 0) {
                        horasExtras += _horasExtrasNoturnas - horasExtras;
                    }
                    //MessageBox.Show("Horas extras noturnas" + _horasExtrasNoturnas);

                    horasTrabalhadasNormais = (horasTrabalhadasInicial - horasTrabalhadasNoite) - horasExtras;

                    if (horasTrabalhadasNormais < 0) horasTrabalhadasNormais = 0;
                }
            }
            var horasTotais = (horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas;

            _diasRegistrados.Add(new DiaTrabalhado(horasTotais, horasExtras, horasTrabalhadasNormais,
                                                    horasNoturnas, _horasExtrasNoturnas));

            int day = monthCalendar1.SelectionRange.Start.Day;
            int month = monthCalendar1.SelectionRange.Start.Month;
            int year = monthCalendar1.SelectionRange.Start.Year;

            if(flagPeriod == true) {
                flagPeriod = false;
                monthPeriod = month;
                dayPeriod = day;
                yearPeriod = year;
            }

            string data = day + "/" + month + "/" + year;

            //Horas totais trabalhadas

            int horas = (int)(((horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas) / 60);

            double a = ((horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas) / 60;

            a = a - horas;

            int minutos = (int)Math.Ceiling(a / 0.016667);

            DateTime date1 = new DateTime(year, month, day, horas, minutos, 0);

            var horaNormal = date1.ToString("t",
                                CultureInfo.CreateSpecificCulture("pt-br"));

            //Horas extras trabalhadas

            horas = (int)(horasExtras / 60);

            a = (horasExtras / 60);

            a = a - horas;

            minutos = (int)Math.Ceiling(a / 0.016667);

            DateTime date2 = new DateTime(year, month, day, horas, minutos, 0);
            var horaExtra = date2.ToString("t",
                                CultureInfo.CreateSpecificCulture("pt-br"));
                
            //Horas noturnas trabalhadas

            horas = (int)(horasNoturnas / 60);

            a = (horasNoturnas / 60);

            a = a - horas;

            minutos = (int)Math.Ceiling(a / 0.016667);

            DateTime date3 = new DateTime(year, month, day, horas, minutos, 0);
            var horaNoite = date3.ToString("t",
                                CultureInfo.CreateSpecificCulture("pt-br"));

            //Adiciona ao calendario

            dataGridView1.Rows.Add(data, horaNormal, horaExtra, horaNoite);

            if (month == 2 && year % 4 == 0) {
                if (day == 29) {
                    day = 1;
                    month++;
                } else day++;
            } else if (month == 2 && year % 4 != 0) {
                if (day == 28) {
                    day = 1;
                    month++;
                } else day++;
            } else if (month == 4 || month == 6 || month == 9 || month == 11) {
                if (day == 30) {
                    day = 1;
                    month++;
                } else day++;
            } else {
                if (day == 31) {
                    day = 1;
                    if (month == 12) {
                        month = 1;
                        year++;
                    } else month++;
                } else day++;
            }

            DateTime date4 = new DateTime(date1.Year, date1.Month, date1.Day, 0, 0, 0);

            /* if (date4.DayOfWeek != DayOfWeek.Saturday && date4.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(date4)) {
                 diasUteis++;
             } */
            diasUteis++;

            DateTime d = new DateTime(year, month, day);
                
            monthCalendar1.SetDate(d);

            SetCaixa();
        }
    }
}
