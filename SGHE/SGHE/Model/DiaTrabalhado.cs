using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    internal class DiaTrabalhado {
        public DiaTrabalhado(int horasExtras, int horasNormais, double horasNoturnas) {
            this.HorasExtras = horasExtras;
            this.HorasNormais = horasNormais;
            this.HorasNoturnas = horasNoturnas;
        }

        public int HorasExtras { get; set; }

        public int HorasNormais { get; set; }

        public double HorasNoturnas { get; set; }
    }
}
