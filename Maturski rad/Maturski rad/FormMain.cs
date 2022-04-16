using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using System.Data.OleDb;
using Microsoft.Office.Interop;

namespace Maturski_rad
{
    public partial class FormMain : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public FormMain()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NormaBaza.accdb; Persist Security Info = False";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUputstvo uputstvo = new FormUputstvo();
            uputstvo.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            // TODO: This line of code loads data into the 'normaBazaDataSet4.Podaci' table. You can move, or remove it, as needed.
            this.podaciTableAdapter3.Fill(this.normaBazaDataSet4.Podaci);
            // TODO: This line of code loads data into the 'normaBazaDataSet2.Podaci' table. You can move, or remove it, as needed.


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodaj dodaj = new FormDodaj();
            dodaj.GetTextBox().Hide();
            dodaj.GetLabel().Hide();
            dodaj.GetButton().Hide();
            dodaj.Show();
        }

        private void osobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodaj dodaj = new FormDodaj();
            dodaj.GetTextBox().Hide();
            dodaj.GetLabel().Hide();
            dodaj.GetButton().Hide();
            dodaj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int br = 1;
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = application.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Podaci";
            for(int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            var save = new SaveFileDialog();
            save.FileName = "Norma";
            save.DefaultExt = ".xlsx";
            ws.Columns.AutoFit();
            if (br > 1 && save.ShowDialog() == DialogResult.OK)
            {
                wb.Save();
            }

              else  if (save.ShowDialog() == DialogResult.OK)
                {
                    ws.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    br++;

                }
            wb.Close();
        }

        private void btnUcitajBazu_Click(object sender, EventArgs e)
        {
            this.podaciTableAdapter3.Fill(this.normaBazaDataSet4.Podaci);
        }

        private void exportUExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int br = 1;
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = application.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;

            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Podaci";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            var save = new SaveFileDialog();
            save.FileName = "Norma";
            save.DefaultExt = ".xlsx";
            ws.Columns.AutoFit();
            if (br > 1 && save.ShowDialog() == DialogResult.OK)
            {
                wb.Save();
            }

            else if (save.ShowDialog() == DialogResult.OK)
            {
                ws.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                br++;

            }
            wb.Close();
        }

        private void učitajBazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodaj dodaj = new FormDodaj();
            dodaj.GetTextBox().Show();
            dodaj.GetLabel().Show();
            dodaj.Show();
        }

        private void obrišiOsobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormObrisi formObrisi = new FormObrisi();
            formObrisi.Show();
        }

        private void btnIzmeniOsobu_Click(object sender, EventArgs e)
        {
            FormDodaj dodaj = new FormDodaj();
            dodaj.GetTextBox().Show();
            dodaj.GetLabel().Show();
            dodaj.Show();
        }

        private void btnObrisiOsobu_Click(object sender, EventArgs e)
        {
            FormObrisi obrisi = new FormObrisi();
            obrisi.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.podaciTableAdapter3.Fill(this.normaBazaDataSet4.Podaci);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
