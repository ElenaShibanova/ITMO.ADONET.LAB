
namespace DataAdapterProgram
{
    partial class DataAdapterProgram
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddStringButton = new System.Windows.Forms.Button();
            this.DeleteStringButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(35, 252);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(115, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddStringButton
            // 
            this.AddStringButton.Location = new System.Drawing.Point(194, 252);
            this.AddStringButton.Name = "AddStringButton";
            this.AddStringButton.Size = new System.Drawing.Size(119, 23);
            this.AddStringButton.TabIndex = 2;
            this.AddStringButton.Text = "Добавить строку";
            this.AddStringButton.UseVisualStyleBackColor = true;
            this.AddStringButton.Click += new System.EventHandler(this.AddStringButton_Click);
            // 
            // DeleteStringButton
            // 
            this.DeleteStringButton.Location = new System.Drawing.Point(355, 252);
            this.DeleteStringButton.Name = "DeleteStringButton";
            this.DeleteStringButton.Size = new System.Drawing.Size(118, 23);
            this.DeleteStringButton.TabIndex = 3;
            this.DeleteStringButton.Text = "Удалить строку";
            this.DeleteStringButton.UseVisualStyleBackColor = true;
            this.DeleteStringButton.Click += new System.EventHandler(this.DeleteStringButton_Click);
            // 
            // DataAdapterProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.DeleteStringButton);
            this.Controls.Add(this.AddStringButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataAdapterProgram";
            this.Text = "Data Adapter Program";
            this.Load += new System.EventHandler(this.DataAdapterProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddStringButton;
        private System.Windows.Forms.Button DeleteStringButton;
    }
}

