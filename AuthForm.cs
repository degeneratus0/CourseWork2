using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railroad_Access_
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Railroad.accdb");
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * From Auth Where Login = @l And Password = @p", con);
            com.Parameters.Add("@l", OleDbType.VarChar).Value = loginTextBox.Text;
            com.Parameters.Add("@p", OleDbType.VarChar).Value = passTextBox.Text;
            try
            {
                if (com.ExecuteScalar().ToString() != "")
                {
                    MainForm mf = new MainForm();
                    mf.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный логин или пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
