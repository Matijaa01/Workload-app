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
    public partial class FormSignUp : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public FormSignUp()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NormaBaza.accdb; Persist Security Info = False";
        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string kljuc = "abrakadabra";
                if (txtKljuc.Text != kljuc)
                {
                    MessageBox.Show("Uneli ste pogrešan ključ!");
                }
               else
               {
                    command.CommandText = "INSERT INTO Prijava([Username],[Password])  VALUES('" + txtUsernameSignUp.Text + "','" + txtPasswordSignUp.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste Kreirali nalog!");
                    connection.Close();
                    this.Close();
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Prijava where ID=" + txtIDacc.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Uspešno ste obrisali nalog sa rednim brojem " + txtIDacc.Text + "!");
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
