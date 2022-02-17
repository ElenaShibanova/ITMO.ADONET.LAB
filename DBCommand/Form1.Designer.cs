
namespace DBCommand
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.queryDataButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.CallProcButton = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.QueryWithParamButton = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.ProcedureWithParButton = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // queryDataButton
            // 
            this.queryDataButton.Location = new System.Drawing.Point(36, 42);
            this.queryDataButton.Name = "queryDataButton";
            this.queryDataButton.Size = new System.Drawing.Size(150, 23);
            this.queryDataButton.TabIndex = 0;
            this.queryDataButton.Text = "Запрос данных";
            this.queryDataButton.UseVisualStyleBackColor = true;
            this.queryDataButton.Click += new System.EventHandler(this.queryDataButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(242, 44);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(250, 300);
            this.ResultTextBox.TabIndex = 1;
            // 
            // CallProcButton
            // 
            this.CallProcButton.Location = new System.Drawing.Point(36, 88);
            this.CallProcButton.Name = "CallProcButton";
            this.CallProcButton.Size = new System.Drawing.Size(150, 23);
            this.CallProcButton.TabIndex = 2;
            this.CallProcButton.Text = "Вызов процедуры";
            this.CallProcButton.UseVisualStyleBackColor = true;
            this.CallProcButton.Click += new System.EventHandler(this.CallProcButton_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(36, 136);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(150, 23);
            this.CreateTableButton.TabIndex = 3;
            this.CreateTableButton.Text = "Создание таблицы";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // QueryWithParamButton
            // 
            this.QueryWithParamButton.Location = new System.Drawing.Point(36, 208);
            this.QueryWithParamButton.Name = "QueryWithParamButton";
            this.QueryWithParamButton.Size = new System.Drawing.Size(150, 23);
            this.QueryWithParamButton.TabIndex = 4;
            this.QueryWithParamButton.Text = "Запрос с параметром";
            this.QueryWithParamButton.UseVisualStyleBackColor = true;
            this.QueryWithParamButton.Click += new System.EventHandler(this.QueryWithParamButton_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(36, 237);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 5;
            this.CityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // ProcedureWithParButton
            // 
            this.ProcedureWithParButton.Location = new System.Drawing.Point(36, 288);
            this.ProcedureWithParButton.Name = "ProcedureWithParButton";
            this.ProcedureWithParButton.Size = new System.Drawing.Size(150, 23);
            this.ProcedureWithParButton.TabIndex = 6;
            this.ProcedureWithParButton.Text = "Процедура с параметром";
            this.ProcedureWithParButton.UseVisualStyleBackColor = true;
            this.ProcedureWithParButton.Click += new System.EventHandler(this.ProcedureWithParButton_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(36, 317);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryNameTextBox.TabIndex = 7;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(36, 343);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrdYearTextBox.TabIndex = 8;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.ProcedureWithParButton);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.QueryWithParamButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.CallProcButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.queryDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button queryDataButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button CallProcButton;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button QueryWithParamButton;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button ProcedureWithParButton;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

