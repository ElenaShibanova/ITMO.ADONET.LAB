
namespace CreatingDataTable
{
    partial class CreatingDataTable
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
            this.WriteSecondTableButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.WriteFirstTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // WriteSecondTableButton
            // 
            this.WriteSecondTableButton.Location = new System.Drawing.Point(44, 22);
            this.WriteSecondTableButton.Name = "WriteSecondTableButton";
            this.WriteSecondTableButton.Size = new System.Drawing.Size(179, 23);
            this.WriteSecondTableButton.TabIndex = 0;
            this.WriteSecondTableButton.Text = "Заполнить дочернюю таблицу";
            this.WriteSecondTableButton.UseVisualStyleBackColor = true;
            this.WriteSecondTableButton.Click += new System.EventHandler(this.WriteSecondTableButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(380, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // WriteFirstTableButton
            // 
            this.WriteFirstTableButton.Location = new System.Drawing.Point(380, 22);
            this.WriteFirstTableButton.Name = "WriteFirstTableButton";
            this.WriteFirstTableButton.Size = new System.Drawing.Size(212, 23);
            this.WriteFirstTableButton.TabIndex = 3;
            this.WriteFirstTableButton.Text = "Заполнить основную таблицу";
            this.WriteFirstTableButton.UseVisualStyleBackColor = true;
            this.WriteFirstTableButton.Click += new System.EventHandler(this.WriteFirstTableButton_Click);
            // 
            // CreatingDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WriteFirstTableButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.WriteSecondTableButton);
            this.Name = "CreatingDataTable";
            this.Text = "Creating Data Table";
            this.Load += new System.EventHandler(this.CreatingDataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WriteSecondTableButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button WriteFirstTableButton;
    }
}

