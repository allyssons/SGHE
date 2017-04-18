﻿using System;
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
        private readonly double _pEn;
        private readonly double _salario;
        private double _horasExtrasNoturnas;


        public CadastroHoras(string nomeFuncionario, double salario, 
                            double p1, double p2, double pN,  int minutoExtra, 
                            int horasMensais, double pEn) {
            InitializeComponent();
            MinutosTrabalhados = 0;
            labelNome.Text = nomeFuncionario;            
            labelSalario.Text = salario.ToString("0.00");
            _minutoExtra = minutoExtra;
            _p1 = p1;
            _p2 = p2;
            _pN = pN;
            _pEn = pEn;
            _salario = salario/horasMensais;
            _horasExtrasNoturnas = 0;
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

            foreach (var t in _diasRegistrados) {
                var valorHoraExtra = ControladorHoras.CalculaValorHoraExtra(t.HorasExtras, _p1, _p2, 
                    _minutoExtra, _salario);

                valorSalarioExtra += valorHoraExtra;

                var valorHoraNoturna = ControladorHoras.CalculaValorHoraNoturna(t.HorasNoturnas, 
                    _pN, _salario, _pEn, t.HorasExtrasNoturnas);

                valorSalarioNoturno += valorHoraNoturna;

                valorSalario += ControladorHoras.CalculaValorSalario(_salario, valorHoraExtra, valorHoraNoturna,
                    t.HorasNormais);
            }

            MessageBox.Show(@"Valor total do salario: " + valorSalario);

            MessageBox.Show(@"Valor total para horas extras: " + valorSalarioExtra);

            MessageBox.Show(@"Valor total para horas noturnas: " + valorSalarioNoturno);
        }

        private void labelNome_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (EntradaTB.Text == "  :" || SaidaTB.Text == "  :") {
                MessageBox.Show("Digite uma entrada para a hora");
            } else {
                _horasExtrasNoturnas = 0;
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

                    horasExtras = ControladorHoras.CalculaHorasExtras(horasTrabalhadasInicial, _minutoExtra,
                                                                      EntradaTB.Text, EntradaIntervalo.Text,
                                                                      SaidaIntervalo.Text, SaidaTB.Text);
                    MessageBox.Show("Horas extras trabalhas" + horasExtras);

                    if (horasExtras > 0)
                        _horasExtrasNoturnas = ControladorHoras.CalculaHorasExtrasNoturnas(EntradaTB.Text,
                                                                                           EntradaIntervalo.Text,
                                                                                           SaidaIntervalo.Text, SaidaTB.Text);
                    if (_horasExtrasNoturnas != 0) {
                        horasExtras += _horasExtrasNoturnas - horasExtras;
                    }
                    MessageBox.Show("Horas extras noturnas" + _horasExtrasNoturnas);

                    horasTrabalhadasNormais = (horasTrabalhadasInicial - horasTrabalhadasNoite) - horasExtras;
                } else { //NAO HOUVE INTERVALO
                    horasTrabalhadasInicial = ControladorHoras.CalculaHoras(EntradaTB.Text, SaidaTB.Text);
                     MessageBox.Show("Horas totais trabalhadas"+horasTrabalhadasInicial);

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
                    MessageBox.Show("Horas extras noturnas" + _horasExtrasNoturnas);

                    horasTrabalhadasNormais = (horasTrabalhadasInicial - horasTrabalhadasNoite) - horasExtras;
                }


                _diasRegistrados.Add(new DiaTrabalhado(horasExtras, horasTrabalhadasNormais, horasNoturnas, _horasExtrasNoturnas));

                int day = monthCalendar1.SelectionRange.Start.Day;
                int month = monthCalendar1.SelectionRange.Start.Month;
                int year = monthCalendar1.SelectionRange.Start.Year;

                string data = day + "/" + month + "/" + year;

                //Horas totais trabalhadas

                int horas = (int)(((horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas) / 60);

                double a = ((horasTrabalhadasInicial - horasTrabalhadasNoite) + horasNoturnas) / 60;

                a = a - horas;

                int minutos = (int)Math.Ceiling(a / 0.016667);

                Console.WriteLine("DEU MERDA" + minutos);

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

                DateTime d = new DateTime(year, month, day);


                monthCalendar1.SetDate(d);

                SetCaixa();
            }
        }
    }
}
