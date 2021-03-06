﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGHE.Model;
using SGHE.Controller;

namespace SGHE.View {
    public partial class ManipularFeriados : Form {
        static string anoString = Convert.ToDateTime(DateTime.Now.ToString()).Year.ToString();
        static int ano = Int32.Parse(anoString);
        Calendario c = new Calendario(ano);
        int flagAlteracao = 0;
        public ManipularFeriados() {
            InitializeComponent();
            //c.setFeriados(); //Primeiro set de feriados
            c = ControladorFeriados.CarregaFeriados(c);
            ChecaFeriadosMoveis();
            LimpaTabela();
            SetaTabelaFeriados();
        }

        private void ChecaFeriadosMoveis() {
            Feriado f = c.SetPascoa();
            int a = c.Feriados.IndexOf(new Model.Feriado("Pascoa", 0, 0));
            Feriado fA = c.Feriados[a];
            if(f != fA) {
                c.Feriados.Remove(fA);
                c.Feriados.Add(f);
            }

            Feriado f2 = c.SetCarnaval(f.Dia, f.Mes, ano);
            a = c.Feriados.IndexOf(new Model.Feriado("Carnaval", 0, 0));
            fA = c.Feriados[a];
            if(f2 != fA) {
                c.Feriados.Remove(fA);
                c.Feriados.Add(f2);
            }

            Feriado f3 = c.SetCorpusChrist(f.Dia, f.Mes);
            a = c.Feriados.IndexOf(new Model.Feriado("Corpus Christ", 0, 0));
            fA = c.Feriados[a];
            if (f3 != fA) {
                c.Feriados.Remove(fA);
                c.Feriados.Add(f3);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }

        private void LimpaTabela() {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void SetaTabelaFeriados() {
             for (int i = 0; i < c.Feriados.Count; i++) {
                dataGridView1.Rows.Add(c.Feriados[i].Nome, c.Feriados[i].Dia + 1, c.Feriados[i].Mes + 1);
            }
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e) {
            if (diaTB.Text == "") {
                MessageBox.Show("Digite um valor para o dia!");
            } else if (comboBox1.Text == "") {
                MessageBox.Show("Selecione um valor para o mês!");
            } else if (feriadoTB.Text == "") {
                MessageBox.Show("Digite um valor para o nome do feriado!");
            } else {
                bool x = ControladorFeriados.VerificaFeriado(Int32.Parse(diaTB.Text), comboBox1.Text, ano);

                if (x) {
                    c = ControladorFeriados.AdicionaFeriado(Int32.Parse(diaTB.Text), comboBox1.Text,
                                        feriadoTB.Text, c);
                    LimpaTabela();
                    SetaTabelaFeriados();
                    flagAlteracao = 1;
                } else {
                    MessageBox.Show("Data inválida, tente com outros valores");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count != 0) {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                string a = row.Cells[0].Value.ToString();
                int b = (Int32.Parse(row.Cells[1].Value.ToString())) - 1;
                int d = (Int32.Parse(row.Cells[2].Value.ToString())) - 1;
                Feriado f = new Feriado(a, b, d);
                c = ControladorFeriados.RemoveFeriado(c, f);
                LimpaTabela();
                SetaTabelaFeriados();
                flagAlteracao = 1;
            } else {
                MessageBox.Show("Selecione um feriado a ser deletado!");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (ControladorFeriados.SalvaFeriados(c)) {
                MessageBox.Show("Lista de feriados salva com sucesso!");
                flagAlteracao = 0;
            }
        }


        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void feriadoTB_TextChanged(object sender, EventArgs e) {

        }

        private void ManipularFeriados_FormClosing_1(object sender, FormClosingEventArgs e) {
            if (flagAlteracao == 1) {
                DialogResult dlg = MessageBox.Show("Deseja salvar as alterações?", "Question", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes) {
                    if (ControladorFeriados.SalvaFeriados(c)) {
                        MessageBox.Show("Lista de feriados salva com sucesso!");
                    }
                    e.Cancel = false;
                    if (dlg == DialogResult.No) {
                        e.Cancel = false;
                    }
                }
            }
        }
    }
}
