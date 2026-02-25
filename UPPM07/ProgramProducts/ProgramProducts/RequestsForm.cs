using System;
using System.Windows.Forms;

namespace ProgramProducts
{
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            Hide();
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Запрос3". При необходимости она может быть перемещена или удалена.
            this.запрос3TableAdapter.Fill(this.programProductsDataSet.Запрос3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Запрос2". При необходимости она может быть перемещена или удалена.
            this.запрос2TableAdapter.Fill(this.programProductsDataSet.Запрос2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programProductsDataSet.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this.programProductsDataSet.Запрос1);

        }
    }
}
