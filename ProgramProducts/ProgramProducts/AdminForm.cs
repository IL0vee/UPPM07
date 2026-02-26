using System;
using System.Windows.Forms;

namespace ProgramProducts
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.programProductsDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Installations". При необходимости она может быть перемещена или удалена.
            this.installationsTableAdapter.Fill(this.programProductsDataSet.Installations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.programProductsDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.programProductsDataSet.Clients);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Update(this.programProductsDataSet.Clients);
            this.productsTableAdapter.Update(this.programProductsDataSet.Products);
            this.installationsTableAdapter.Update(this.programProductsDataSet.Installations);
            this.usersTableAdapter.Update(this.programProductsDataSet.Users);
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            RequestsForm RequestsForm = new RequestsForm();
            RequestsForm.Show();
            Hide();
        }
    }
}
