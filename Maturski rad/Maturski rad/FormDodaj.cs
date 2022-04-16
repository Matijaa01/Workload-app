using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Maturski_rad
{
    public partial class FormDodaj : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public FormDodaj()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NormaBaza.accdb; Persist Security Info = False";
        }
        internal TextBox GetTextBox()
        {
            return txtID;
        }

        internal Label GetLabel()
        {
            return labID;
        }
        internal Button GetButton()
        {
            return btnIzmeni;
        }
        
            
        
        
        private void radbtnM_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnM.Checked) txtPol.Text = "Muški";
        }

        private void radbtnZ_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnZ.Checked) txtPol.Text = "Ženski";
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                double procenat = Math.Ceiling(Convert.ToDouble(txtBrCasova.Text) / Convert.ToDouble(txtNorma.Text)*100);
                command.CommandText = "insert into Podaci(Ime,Prezime,Pol,Minimalna_strucna_sprema,Broj_casova,Norma_casova,Procenat_angazovanja) values('" + txtIme.Text + "','" + txtPrez.Text + "','" + txtPol.Text + "','" + txtStrsp.Text + "','" + Convert.ToInt32(txtBrCasova.Text) + "','" + Convert.ToInt32(txtNorma.Text) + "','" + Convert.ToInt32(procenat) + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Uspešno ste uneli osobu!");
                connection.Close();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                double procenat = Math.Ceiling(Convert.ToDouble(txtBrCasova.Text) / Convert.ToDouble(txtNorma.Text) * 100);
                 string query= "update Podaci set Ime='" + txtIme.Text + "' ,Prezime='" + txtPrez.Text + "' ,Pol='" + txtPol.Text + "' ,Minimalna_strucna_sprema='" + txtStrsp.Text + "' ,Broj_casova='" + txtBrCasova.Text + "' ,Norma_casova='" + txtNorma.Text + "' ,Procenat_angazovanja='" + procenat + "' where ID=" + txtID.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Uspešno ste izmenili osobu!");
                connection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
