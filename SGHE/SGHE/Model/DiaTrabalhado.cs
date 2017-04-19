using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    internal class DiaTrabalhado {
        public DiaTrabalhado(double horasTotaisTrabalhadas, double horasExtras, double horasNormais, double horasNoturnas, double horasExtrasNoturnas) {
            this.HorasTotaisTrabalhadas = horasTotaisTrabalhadas;
            this.HorasExtras = horasExtras;
            this.HorasNormais = horasNormais;
            this.HorasNoturnas = horasNoturnas;
            this.HorasExtrasNoturnas = horasExtrasNoturnas;
        }

        public double HorasTotaisTrabalhadas { get; set; }

        public double HorasExtrasNoturnas { get; set; }

        public double HorasExtras { get; set; }

        public double HorasNormais { get; set; }

        public double HorasNoturnas { get; set; }
    }
}
