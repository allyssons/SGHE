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
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes

            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf
            string caminho = @"C:\" + "CONTRATO.pdf";

            //criando o arquivo pdf embranco, passando como parametro a variavel                
            //doc criada acima e a variavel caminho 
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            //criando uma string vazia
            string dados = "";

            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14));
            //etipulando o alinhamneto
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            //Alinhamento Justificado
            //adicioando texto
            paragrafo.Add("TESTE TESTE TESTE");
            //acidionado paragrafo ao documento
            doc.Add(paragrafo);
            //fechando documento para que seja salva as alteraçoes.
            doc.Close();
        }
       
    }
}
