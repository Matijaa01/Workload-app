using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maturski_rad
{
    public partial class FormUputstvo : Form
    {
        public FormUputstvo()
        {
            InitializeComponent();
        }
        int br = 0;
        private void FormUputstvo_Load(object sender, EventArgs e)
        {
            FormUputstvo uputstvo = new FormUputstvo();
            FormMain mainforma = new FormMain();
            
        }

        private void btnPageBack_Click(object sender, EventArgs e)
        {
            
            if (br % 2 == 0)
            {
                picMainForma.Hide();
                picDodajUputstvo.Show();
                br++;
            }
            else if (br % 2 != 0)
            {
                picDodajUputstvo.Hide();
                picMainForma.Show();
                br++;
            }
        }

        private void btnPageForward_Click(object sender, EventArgs e)
        {
            if (br % 2 == 0)
            {
                picMainForma.Hide();
                picDodajUputstvo.Show();
                br++;
            }
            else if (br % 2 != 0)
            {
                picDodajUputstvo.Hide();
                picMainForma.Show();
                br++;
            }
        }
    }
}
