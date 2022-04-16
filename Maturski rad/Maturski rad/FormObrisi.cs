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
    public partial class FormObrisi : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public FormObrisi()
        {
            InitializeComponent();
            
        }

        private void btnObrisi2_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NormaBaza.accdb; Persist Security Info = False";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Podaci where ID=" + txtIDObrisi.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Uspešno ste obrisali osobu sa rednim brojem " + txtIDObrisi.Text + "!");
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
