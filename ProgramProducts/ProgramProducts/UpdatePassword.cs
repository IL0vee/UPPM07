using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProgramProducts
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProgramProducts.accdb";
            OleDbConnection conn = new OleDbConnection(connection);
            conn.Open();

            string query = "UPDATE [Users] SET [Password] = ? WHERE [Login] = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text);
            cmd.Parameters.AddWithValue("Login", LoginTextBox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Вы сменили пароль");
            Close();
        }
    }
}
