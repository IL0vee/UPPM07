using System;
using System.Windows.Forms;

namespace ProgramProducts
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Installations". При необходимости она может быть перемещена или удалена.
            this.installationsTableAdapter.Fill(this.programProductsDataSet.Installations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.programProductsDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.programProductsDataSet.Clients);

        }
    }
}
