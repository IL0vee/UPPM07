namespace ProgramProducts
{
    partial class RequestsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.programProductsDataSet = new ProgramProducts.ProgramProductsDataSet();
            this.запрос1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос1TableAdapter = new ProgramProducts.ProgramProductsDataSetTableAdapters.Запрос1TableAdapter();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumlicensequantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.запрос2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос2TableAdapter = new ProgramProducts.ProgramProductsDataSetTableAdapters.Запрос2TableAdapter();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suminstallationcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.запрос3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос3TableAdapter = new ProgramProducts.ProgramProductsDataSetTableAdapters.Запрос3TableAdapter();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programProductsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(719, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(69, 41);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 406);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 32);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "<-----";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 388);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запрос1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запрос2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(693, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запрос3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.sumlicensequantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.запрос1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // programProductsDataSet
            // 
            this.programProductsDataSet.DataSetName = "ProgramProductsDataSet";
            this.programProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запрос1BindingSource
            // 
            this.запрос1BindingSource.DataMember = "Запрос1";
            this.запрос1BindingSource.DataSource = this.programProductsDataSet;
            // 
            // запрос1TableAdapter
            // 
            this.запрос1TableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // sumlicensequantityDataGridViewTextBoxColumn
            // 
            this.sumlicensequantityDataGridViewTextBoxColumn.DataPropertyName = "Sum-license_quantity";
            this.sumlicensequantityDataGridViewTextBoxColumn.HeaderText = "Sum-license_quantity";
            this.sumlicensequantityDataGridViewTextBoxColumn.Name = "sumlicensequantityDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientnameDataGridViewTextBoxColumn,
            this.installationdateDataGridViewTextBoxColumn,
            this.suminstallationcostDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.запрос2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(681, 350);
            this.dataGridView2.TabIndex = 0;
            // 
            // запрос2BindingSource
            // 
            this.запрос2BindingSource.DataMember = "Запрос2";
            this.запрос2BindingSource.DataSource = this.programProductsDataSet;
            // 
            // запрос2TableAdapter
            // 
            this.запрос2TableAdapter.ClearBeforeFill = true;
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "client_name";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            // 
            // installationdateDataGridViewTextBoxColumn
            // 
            this.installationdateDataGridViewTextBoxColumn.DataPropertyName = "installation_date";
            this.installationdateDataGridViewTextBoxColumn.HeaderText = "installation_date";
            this.installationdateDataGridViewTextBoxColumn.Name = "installationdateDataGridViewTextBoxColumn";
            // 
            // suminstallationcostDataGridViewTextBoxColumn
            // 
            this.suminstallationcostDataGridViewTextBoxColumn.DataPropertyName = "Sum-installation_cost";
            this.suminstallationcostDataGridViewTextBoxColumn.HeaderText = "Sum-installation_cost";
            this.suminstallationcostDataGridViewTextBoxColumn.Name = "suminstallationcostDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnameDataGridViewTextBoxColumn,
            this.applicationareaDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.запрос3BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(681, 350);
            this.dataGridView3.TabIndex = 0;
            // 
            // запрос3BindingSource
            // 
            this.запрос3BindingSource.DataMember = "Запрос3";
            this.запрос3BindingSource.DataSource = this.programProductsDataSet;
            // 
            // запрос3TableAdapter
            // 
            this.запрос3TableAdapter.ClearBeforeFill = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // applicationareaDataGridViewTextBoxColumn
            // 
            this.applicationareaDataGridViewTextBoxColumn.DataPropertyName = "application_area";
            this.applicationareaDataGridViewTextBoxColumn.HeaderText = "application_area";
            this.applicationareaDataGridViewTextBoxColumn.Name = "applicationareaDataGridViewTextBoxColumn";
            // 
            // clientnameDataGridViewTextBoxColumn1
            // 
            this.clientnameDataGridViewTextBoxColumn1.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn1.HeaderText = "client_name";
            this.clientnameDataGridViewTextBoxColumn1.Name = "clientnameDataGridViewTextBoxColumn1";
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestsForm";
            this.Text = "RequestsForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programProductsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ProgramProductsDataSet programProductsDataSet;
        private System.Windows.Forms.BindingSource запрос1BindingSource;
        private ProgramProductsDataSetTableAdapters.Запрос1TableAdapter запрос1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumlicensequantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource запрос2BindingSource;
        private ProgramProductsDataSetTableAdapters.Запрос2TableAdapter запрос2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suminstallationcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource запрос3BindingSource;
        private ProgramProductsDataSetTableAdapters.Запрос3TableAdapter запрос3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn1;
    }
}