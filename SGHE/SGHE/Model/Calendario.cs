using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    class Calendario {
        private List<Mes> meses;
        private List<Feriado> feriados;
        private int ano;

        internal List<Mes> Meses {
            get {
                return meses;
            }

            set {
                meses = value;
            }
        }

        public int Ano {
            get {
                return ano;
            }

            set {
                ano = value;
            }
        }

        internal List<Feriado> Feriados {
            get {
                return feriados;
            }

            set {
                feriados = value;
            }
        }

        public Calendario(int ano) {
            this.ano = ano;
            this.Feriados = new List<Feriado>();
            this.meses = new List<Mes>(12);
            Mes a = new Model.Mes(31);
            meses.Add(new Mes(31));
            if (ano % 4 == 0) {
                meses.Add(new Mes(29));
            } else {
                meses.Add(new Mes(28));
            }
            meses.Add(new Mes(31));
            meses.Add(new Mes(30));
            meses.Add(new Mes(31));
            meses.Add(new Mes(30));
            meses.Add(new Mes(31));
            meses.Add(new Mes(31));
            meses.Add(new Mes(30));
            meses.Add(new Mes(31));
            meses.Add(new Mes(30));
            meses.Add(new Mes(31));
            //setFeriados();
        }

        public Feriado SetPascoa() {
            //FERIADOS MOVEIS
            int dia;
            int mes;
            int a = ano % 19;
            int b = ano % 4;
            int c = ano % 7;
            int d = ((19 * a) + 24) % 30;
            int e = ((2 * b) + (4 * c) + (6 * d) + (5)) % 7;
            if (d + e < 10) {
                dia = d + e + 22;
                mes = 2;
            } else {
                dia = d + e - 9;
                mes = 3;
            }

            if (dia == 26 && mes == 3) {
                dia = 19;
            } else if (dia == 25 && mes == 3 && d == 28 && a > 10) {
                dia = 18;
            }
            return new Feriado("Pascoa", dia - 1, mes);
        }

        public void setFeriados() {
            //FERIADOS FIXOS
            Feriados.Add(new Feriado("Ano Novo", 0, 0));
            Feriados.Add(new Feriado("Tiradentes", 20, 3));
            Feriados.Add(new Feriado("Dia do Trabalhador", 0, 4));
            Feriados.Add(new Feriado("Independencia", 6, 8));
            Feriados.Add(new Feriado("Nossa Senhora", 11, 10));
            Feriados.Add(new Feriado("Finados", 1, 10));
            Feriados.Add(new Feriado("Proclamacao da Republica", 14, 10));
            Feriados.Add(new Feriado("Natal", 24, 11));
            
            Feriados.Add(SetPascoa());

        }
    }
}
