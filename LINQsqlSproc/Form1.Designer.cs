
namespace LINQsqlSproc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetailsOrderButton = new System.Windows.Forms.Button();
            this.OrderStoryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите код заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите код клиента";
            // 
            // DetailsOrderButton
            // 
            this.DetailsOrderButton.Location = new System.Drawing.Point(54, 112);
            this.DetailsOrderButton.Name = "DetailsOrderButton";
            this.DetailsOrderButton.Size = new System.Drawing.Size(152, 23);
            this.DetailsOrderButton.TabIndex = 2;
            this.DetailsOrderButton.Text = "Подробности заказа";
            this.DetailsOrderButton.UseVisualStyleBackColor = true;
            this.DetailsOrderButton.Click += new System.EventHandler(this.DetailsOrderButton_Click);
            // 
            // OrderStoryButton
            // 
            this.OrderStoryButton.Location = new System.Drawing.Point(297, 112);
            this.OrderStoryButton.Name = "OrderStoryButton";
            this.OrderStoryButton.Size = new System.Drawing.Size(152, 23);
            this.OrderStoryButton.TabIndex = 3;
            this.OrderStoryButton.Text = "История заказа";
            this.OrderStoryButton.UseVisualStyleBackColor = true;
            this.OrderStoryButton.Click += new System.EventHandler(this.OrderStoryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 192);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OrderStoryButton);
            this.Controls.Add(this.DetailsOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LINQ sql Spoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DetailsOrderButton;
        private System.Windows.Forms.Button OrderStoryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

