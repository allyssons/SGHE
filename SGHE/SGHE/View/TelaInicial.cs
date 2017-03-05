using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SGHE.Model;
using SGHE.View;


namespace SGHE {
    public partial class SGHE : Form {
        public SGHE() {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {

        }

        private void manipularFeriadosToolStripMenuItem2_Click(object sender, EventArgs e) {
            ManipularFeriados a = new ManipularFeriados();
            a.Show();
        }
    }

}



/*Calendario c = new Calendario(1997);
String s = "";
for(int i = 0; i<c.Meses[1].Tamanho; i++) {
    s += c.Meses[0].Dia[i].Id.ToString();
}
MessageBox.Show(s);
*/
