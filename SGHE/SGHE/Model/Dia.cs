using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Model {
    class Dia {
        private int id;

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public Dia(int id) {
            this.id = id;
        }
    }
}
