using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SGHE.View {
    public partial class Relatorio : UserControl {


        public Relatorio(string nome, int saldoAnterior, double horasMensais, int diasUteis, double horasTotais, double horasExtras, double horasNoturnas,
                         double salario, double salarioExtra, double salarioNoturno, DateTime iniPeriod, DateTime endPeriod) {
            InitializeComponent();
            var hora = 0;
            var minuto = 0;

            //Seta o nome
            nomeLabel.Text = nome;

            //Seta saldo anterior
            hora = converteHora(saldoAnterior);
            minuto = converteMinuto(saldoAnterior);
            saldoAnteriorLabel.Text = hora.ToString("00") +":"+minuto.ToString("00");

            //Seta saldo atual
            double horasDeviamTrabalhadas = ((horasMensais*60)/30) * diasUteis;            
            double saldoAtual = horasTotais - horasDeviamTrabalhadas + saldoAnterior;
            hora = converteHora(saldoAtual);
            minuto = converteMinuto(saldoAtual);
            if (minuto < 0) minuto *= -1;
            saldoAtualLabel.Text = hora.ToString("00") + ":" + minuto.ToString("00");

            //Seta horas totais
            hora = converteHora(horasTotais);
            minuto = converteMinuto(horasTotais);
            horasTotaisLabel.Text = hora.ToString("00") + ":" + minuto.ToString("00");

            //Seta horas extras
            hora = converteHora(horasExtras);
            minuto = converteMinuto(horasExtras);
            horasExtrasLabel.Text = hora.ToString("00") + ":" + minuto.ToString("00");

            //Seta horas noturnas
            hora = converteHora(horasNoturnas);
            minuto = converteMinuto(horasNoturnas);
            horasNoturnasLabel.Text = hora.ToString("00") + ":" + minuto.ToString("00");


            //Seta salario total
            salarioLabel.Text =  "R$ "+salario.ToString("0.00");

            //Seta salario extra
            valorExtraLabel.Text = "R$ " + salarioExtra.ToString("0.00");

            //Seta salario noturno
            valorNoturnoLabel.Text = "R$ " + salarioNoturno.ToString("0.00");

            //Seta Periodo
            string dataInicial = iniPeriod.Day.ToString() + "/" + iniPeriod.Month.ToString() + "/" + iniPeriod.Year.ToString();
            string dataFinal = endPeriod.Day.ToString() + "/" + endPeriod.Month.ToString() + "/" + endPeriod.Year.ToString();
            periodoLabel.Text = dataInicial + " a " + dataFinal;
        }

        public int converteHora(double horasA) {
            return (int)(horasA / 60);
        }
       
        public int converteMinuto(double horasA) {

            int horas = (int)(horasA / 60);
            
            double a = (horasA / 60);

            a = a - horas;

            return (int)Math.Ceiling(a / 0.016667);
        }
        private void button1_Click(object sender, EventArgs e) {
            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf

            
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                MessageBox.Show(saveFileDialog1.FileName);
            }

            string caminho = saveFileDialog1.FileName + ".pdf";
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes
            
            //criando o arquivo pdf em branco, passando como parametro a variavel                
            //doc criada acima e a variavel caminho 
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            //criando uma string vazia
            string dados = "";

            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14));
            //etipulando o alinhamneto
            paragrafo.Alignment = Element.ALIGN_LEFT;

            
            //AQUI ONDE VAMOS ADICIONAR A VARIAVEL DO TIPO "Font"
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold);

             //Adicionando Titulo
            Char[] text = label11.Text.ToCharArray();

            for(int i = 0; i < text.Length; i++) {
                if(text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            String texto = new String(text);

            paragrafo.Add(texto+ "\n\n\n");

            ////////////////////BLOCO///////////////////////

            //Adicionando nome do empregado
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label1.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");
            
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(nomeLabel.Text + "\n\n");

            //Adicionando Periodo

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label3.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(periodoLabel.Text + "\n\n\n");

            ////////////////////BLOCO///////////////////////

            //Adicionando Horas totais

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label2.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(horasTotaisLabel.Text + "\n\n");

            //Adicionando Horas Extras

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label4.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(horasExtrasLabel.Text + "\n\n");

            //Adicionando Horas Noturnas

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label5.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(horasNoturnasLabel.Text + "\n\n\n");

            ////////////////////BLOCO///////////////////////

            //Adicionando Saldo anterior

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label6.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(saldoAnteriorLabel.Text + "\n\n");

            //Adicionando Saldo atual

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label7.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(saldoAtualLabel.Text + "\n\n\n");

            ////////////////////BLOCO///////////////////////

            //Adicionando Salario

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label7.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(salarioLabel.Text + "\n\n");

            //Adicionando valor noturno

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label8.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(valorNoturnoLabel.Text + "\n\n");

            //Adicionando valor extra

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);

            text = label9.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '\n' || text[i] == '\r' || text[i] == '\t') {
                    text[i] = ' ';
                }
            }

            texto = new String(text);

            paragrafo.Add(texto + " ");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

            paragrafo.Add(valorExtraLabel.Text + "\n\n");

            doc.Add(paragrafo);

            //fechando documento para que seja salva as alteraçoes
            doc.Close();

            MessageBox.Show("ARQUIVO EXCPORTAdaed");
        }

    }
}
