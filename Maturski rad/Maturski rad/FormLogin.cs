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
using System.Threading;
namespace Maturski_rad
{
    
    public partial class FormLogin : Form
    {
        Thread th;
        OleDbConnection connection = new OleDbConnection();
        public FormLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NormaBaza.accdb; Persist Security Info = False";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opennewform(object obj)
        {
            Application.Run(new FormMain());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Prijava Where Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            OleDbDataReader reader = command.ExecuteReader();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command.CommandText,connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            FormMain mainforma = new FormMain();
            if (table.Rows.Count == 1)
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Proverite username ili password!");
                txtUsername.SelectAll();
                txtUsername.Focus();
            }

            connection.Close();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            { 
                connection.Open();
                labelCon.Text = "Veza sa serverom je uspostavljena";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
        }

        private void uputstvo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginUputstvo uputstvo = new FormLoginUputstvo();
            uputstvo.Show();
        }
    }
    }

