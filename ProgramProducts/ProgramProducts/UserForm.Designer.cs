namespace ProgramProducts
{
    partial class UserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.programProductsDataSet = new ProgramProducts.ProgramProductsDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new ProgramProducts.ProgramProductsDataSetTableAdapters.ClientsTableAdapter();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationfieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ProgramProducts.ProgramProductsDataSetTableAdapters.ProductsTableAdapter();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensecostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installationsTableAdapter = new ProgramProducts.ProgramProductsDataSetTableAdapters.InstallationsTableAdapter();
            this.installationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uninstallationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensequantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programProductsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationsBindingSource)).BeginInit();
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
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.applicationfieldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продукты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.producttypeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.releasedateDataGridViewTextBoxColumn,
            this.applicationareaDataGridViewTextBoxColumn,
            this.licensecostDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(681, 353);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(693, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Установки лицензий";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.installationidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn1,
            this.clientidDataGridViewTextBoxColumn1,
            this.installationdateDataGridViewTextBoxColumn,
            this.uninstallationdateDataGridViewTextBoxColumn,
            this.installationcostDataGridViewTextBoxColumn,
            this.licensequantityDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.installationsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(684, 353);
            this.dataGridView3.TabIndex = 0;
            // 
            // programProductsDataSet
            // 
            this.programProductsDataSet.DataSetName = "ProgramProductsDataSet";
            this.programProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.programProductsDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "client_name";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // applicationfieldDataGridViewTextBoxColumn
            // 
            this.applicationfieldDataGridViewTextBoxColumn.DataPropertyName = "application_field";
            this.applicationfieldDataGridViewTextBoxColumn.HeaderText = "application_field";
            this.applicationfieldDataGridViewTextBoxColumn.Name = "applicationfieldDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.programProductsDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            // 
            // producttypeDataGridViewTextBoxColumn
            // 
            this.producttypeDataGridViewTextBoxColumn.DataPropertyName = "product_type";
            this.producttypeDataGridViewTextBoxColumn.HeaderText = "product_type";
            this.producttypeDataGridViewTextBoxColumn.Name = "producttypeDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // releasedateDataGridViewTextBoxColumn
            // 
            this.releasedateDataGridViewTextBoxColumn.DataPropertyName = "release_date";
            this.releasedateDataGridViewTextBoxColumn.HeaderText = "release_date";
            this.releasedateDataGridViewTextBoxColumn.Name = "releasedateDataGridViewTextBoxColumn";
            // 
            // applicationareaDataGridViewTextBoxColumn
            // 
            this.applicationareaDataGridViewTextBoxColumn.DataPropertyName = "application_area";
            this.applicationareaDataGridViewTextBoxColumn.HeaderText = "application_area";
            this.applicationareaDataGridViewTextBoxColumn.Name = "applicationareaDataGridViewTextBoxColumn";
            // 
            // licensecostDataGridViewTextBoxColumn
            // 
            this.licensecostDataGridViewTextBoxColumn.DataPropertyName = "license_cost";
            this.licensecostDataGridViewTextBoxColumn.HeaderText = "license_cost";
            this.licensecostDataGridViewTextBoxColumn.Name = "licensecostDataGridViewTextBoxColumn";
            // 
            // installationsBindingSource
            // 
            this.installationsBindingSource.DataMember = "Installations";
            this.installationsBindingSource.DataSource = this.programProductsDataSet;
            // 
            // installationsTableAdapter
            // 
            this.installationsTableAdapter.ClearBeforeFill = true;
            // 
            // installationidDataGridViewTextBoxColumn
            // 
            this.installationidDataGridViewTextBoxColumn.DataPropertyName = "installation_id";
            this.installationidDataGridViewTextBoxColumn.HeaderText = "installation_id";
            this.installationidDataGridViewTextBoxColumn.Name = "installationidDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn1
            // 
            this.productidDataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn1.Name = "productidDataGridViewTextBoxColumn1";
            // 
            // clientidDataGridViewTextBoxColumn1
            // 
            this.clientidDataGridViewTextBoxColumn1.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn1.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn1.Name = "clientidDataGridViewTextBoxColumn1";
            // 
            // installationdateDataGridViewTextBoxColumn
            // 
            this.installationdateDataGridViewTextBoxColumn.DataPropertyName = "installation_date";
            this.installationdateDataGridViewTextBoxColumn.HeaderText = "installation_date";
            this.installationdateDataGridViewTextBoxColumn.Name = "installationdateDataGridViewTextBoxColumn";
            // 
            // uninstallationdateDataGridViewTextBoxColumn
            // 
            this.uninstallationdateDataGridViewTextBoxColumn.DataPropertyName = "uninstallation_date";
            this.uninstallationdateDataGridViewTextBoxColumn.HeaderText = "uninstallation_date";
            this.uninstallationdateDataGridViewTextBoxColumn.Name = "uninstallationdateDataGridViewTextBoxColumn";
            // 
            // installationcostDataGridViewTextBoxColumn
            // 
            this.installationcostDataGridViewTextBoxColumn.DataPropertyName = "installation_cost";
            this.installationcostDataGridViewTextBoxColumn.HeaderText = "installation_cost";
            this.installationcostDataGridViewTextBoxColumn.Name = "installationcostDataGridViewTextBoxColumn";
            // 
            // licensequantityDataGridViewTextBoxColumn
            // 
            this.licensequantityDataGridViewTextBoxColumn.DataPropertyName = "license_quantity";
            this.licensequantityDataGridViewTextBoxColumn.HeaderText = "license_quantity";
            this.licensequantityDataGridViewTextBoxColumn.Name = "licensequantityDataGridViewTextBoxColumn";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programProductsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private ProgramProductsDataSet programProductsDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ProgramProductsDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationfieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProgramProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource installationsBindingSource;
        private ProgramProductsDataSetTableAdapters.InstallationsTableAdapter installationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uninstallationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensequantityDataGridViewTextBoxColumn;
    }
}