using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    class Mes {
        private int tamanho;
        private List<Dia> dias;

        public int Tamanho {
            get {
                return tamanho;
            }

            set {
                tamanho = value;
            }
        }

        internal List<Dia> Dia {
            get {
                return dias;
            }

            set {
                dias = value;
            }
        }

        public Mes(int tamanho) {
            this.tamanho = tamanho;
            dias = new List<Dia>(tamanho);
            for(int i = 0; i < tamanho; i++) {
                dias.Add(new Dia(i + 1));
            }
        }
    }
}
