using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    class Feriado {
        private string nome;
        private int dia;
        private int mes;


        public Feriado(string nome, int dia, int mes) {
            this.nome = nome;
            this.Dia = dia;
            this.Mes = mes;
        }

        public string Nome {
            get {
                return nome;
            }

            set {
                nome = value;
            }
        }

        public int Dia {
            get {
                return dia;
            }

            set {
                dia = value;
            }
        }

        public int Mes {
            get {
                return mes;
            }

            set {
                mes = value;
            }
        }

        public override bool Equals(object obj) {
            Feriado e = obj as Feriado;
            return e.nome == nome;
        }
    }
}
