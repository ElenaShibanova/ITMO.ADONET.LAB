
namespace LINQsql_1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadingDataButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.DelObjectButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssociationDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(183, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 225);
            this.listBox1.TabIndex = 0;
            // 
            // LoadingDataButton
            // 
            this.LoadingDataButton.Location = new System.Drawing.Point(41, 47);
            this.LoadingDataButton.Name = "LoadingDataButton";
            this.LoadingDataButton.Size = new System.Drawing.Size(106, 23);
            this.LoadingDataButton.TabIndex = 1;
            this.LoadingDataButton.Text = "Загрузка данных";
            this.LoadingDataButton.UseVisualStyleBackColor = true;
            this.LoadingDataButton.Click += new System.EventHandler(this.LoadingDataButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(41, 103);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(106, 23);
            this.ClearListButton.TabIndex = 2;
            this.ClearListButton.Text = "Очистить список";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.Location = new System.Drawing.Point(41, 160);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(106, 23);
            this.AddObjectButton.TabIndex = 3;
            this.AddObjectButton.Text = "Добавить объект";
            this.AddObjectButton.UseVisualStyleBackColor = true;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // DelObjectButton
            // 
            this.DelObjectButton.Location = new System.Drawing.Point(41, 221);
            this.DelObjectButton.Name = "DelObjectButton";
            this.DelObjectButton.Size = new System.Drawing.Size(106, 23);
            this.DelObjectButton.TabIndex = 4;
            this.DelObjectButton.Text = "Удалить объект";
            this.DelObjectButton.UseVisualStyleBackColor = true;
            this.DelObjectButton.Click += new System.EventHandler(this.DelObjectButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(183, 267);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 225);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OrdersCount";
            this.columnHeader3.Width = 92;
            // 
            // AssociationDataButton
            // 
            this.AssociationDataButton.Location = new System.Drawing.Point(23, 282);
            this.AssociationDataButton.Name = "AssociationDataButton";
            this.AssociationDataButton.Size = new System.Drawing.Size(133, 45);
            this.AssociationDataButton.TabIndex = 6;
            this.AssociationDataButton.Text = "Получение связанных\r\nданных";
            this.AssociationDataButton.UseVisualStyleBackColor = true;
            this.AssociationDataButton.Click += new System.EventHandler(this.AssociationDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 522);
            this.Controls.Add(this.AssociationDataButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DelObjectButton);
            this.Controls.Add(this.AddObjectButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.LoadingDataButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "LINQsql 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadingDataButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.Button DelObjectButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button AssociationDataButton;
    }
}

