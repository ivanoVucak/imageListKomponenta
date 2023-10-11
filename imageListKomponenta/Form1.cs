using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageListKomponenta
{

    public partial class Form1 : Form
    {

        int brojac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void promijeniBtn_Click(object sender, EventArgs e)
        {
            brojac++;
            if (brojac % 2 == 0)
            {
                slika1Pb.Image = imageList1.Images[0];
            }
            else {
                slika1Pb.Image = imageList1.Images[1];
            }
        }
    }
}
