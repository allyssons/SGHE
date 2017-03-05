using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGHE.Model;
using System.IO;

namespace SGHE.Controller {
    static class ControladorFeriados {

        public static bool VerificaFeriado(int dia, string mes, int ano) {
            Console.Write(dia);
            Console.Write(mes);
            Console.Write(ano);
            if (ano % 4 == 0 && mes == "Fevereiro" && dia > 29) {
                return false;
            }else if ((ano % 4 != 0) && (mes == "Fevereiro") && (dia > 28)) {
                return false;
            }else if ((mes == "Abril" || mes == "Junho" || mes == "Setembro" || mes == "Novembro")
                      && dia > 30)  {
                return false;
            }else if(dia > 31) {
                return false;
            }else {
                return true;
            }
        }

        public static Calendario AdicionaFeriado(int dia, string mes, string nomeFeriado, Calendario c) {

            if(mes == "Janeiro") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 0));
            }else if(mes == "Fevereiro") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 1));
            } else if (mes == "Março") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 2));
            } else if (mes == "Abril") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 3));
            } else if (mes == "Maio") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 4));
            } else if (mes == "Junho") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 5));
            } else if (mes == "Julho") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 6));
            } else if (mes == "Agosto") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 7));
            } else if (mes == "Setembro") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 8));
            } else if (mes == "Outubro") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 9));
            } else if (mes == "Novembro") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 10));
            } else if (mes == "Dezembro") {
                c.Feriados.Add(new Feriado(nomeFeriado, dia - 1, 11));
            }
            return c;
        }

        public static Calendario RemoveFeriado(Calendario c, Feriado f) {
            c.Feriados.Remove(f);
            return c;
        }

        public static bool SalvaFeriados(Calendario c) {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter wr = new StreamWriter(mydocpath + @"\arquivoFeriados.txt");
            string a = "";
            string b = "";
            int i;
            for(i = 0; i < c.Feriados.Count-1; i++) {
                a = c.Feriados[i].Dia.ToString();
                b = c.Feriados[i].Mes.ToString();
                wr.WriteLine(c.Feriados[i].Nome);
                wr.WriteLine(a);
                wr.WriteLine(b);
            }
            a = c.Feriados[i].Dia.ToString();
            b = c.Feriados[i].Mes.ToString();
            wr.WriteLine(c.Feriados[i].Nome);
            wr.WriteLine(a);
            wr.Write(b);
            wr.Close();
            return true;
        }

        public static Calendario CarregaFeriados(Calendario c) {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamReader r = new StreamReader(mydocpath + @"\arquivoFeriados.txt", true);
            string a = "";
            string b = "";
            string d = "";
            while(!r.EndOfStream) {
                a = r.ReadLine();
                b = r.ReadLine();
                d = r.ReadLine();
                c.Feriados.Add(new Feriado(a, Int32.Parse(b), Int32.Parse(d)));
            }
            r.Close();
            return c;
        }
    }
}
