using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    internal class DiaTrabalhado {
        public DiaTrabalhado(double horasExtras, double horasNormais, double horasNoturnas) {
            this.HorasExtras = horasExtras;
            this.HorasNormais = horasNormais;
            this.HorasNoturnas = horasNoturnas;
        }

        public double HorasExtras { get; set; }

        public double HorasNormais { get; set; }

        public double HorasNoturnas { get; set; }
    }
}
