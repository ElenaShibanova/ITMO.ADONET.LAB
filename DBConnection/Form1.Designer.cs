
namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numProdButton = new System.Windows.Forms.Button();
            this.numProdLabel = new System.Windows.Forms.Label();
            this.numProdButton2 = new System.Windows.Forms.Button();
            this.numProdLabel2 = new System.Windows.Forms.Label();
            this.listProdButton = new System.Windows.Forms.Button();
            this.listProdListView = new System.Windows.Forms.ListView();
            this.listProdСolumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Работа с базой данных";
            // 
            // workDBToolStripMenuItem
            // 
            this.workDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem1,
            this.unconnectionToolStripMenuItem,
            this.asyncConnectionToolStripMenuItem,
            this.listConnectionsToolStripMenuItem});
            this.workDBToolStripMenuItem.Name = "workDBToolStripMenuItem";
            this.workDBToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.workDBToolStripMenuItem.Text = "Работа с базой данных";
            // 
            // connectionToolStripMenuItem1
            // 
            this.connectionToolStripMenuItem1.Name = "connectionToolStripMenuItem1";
            this.connectionToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.connectionToolStripMenuItem1.Text = "Подключиться к БД";
            this.connectionToolStripMenuItem1.Click += new System.EventHandler(this.connectionToolStripMenuItem1_Click);
            // 
            // unconnectionToolStripMenuItem
            // 
            this.unconnectionToolStripMenuItem.Name = "unconnectionToolStripMenuItem";
            this.unconnectionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.unconnectionToolStripMenuItem.Text = "Отключиться от БД";
            this.unconnectionToolStripMenuItem.Click += new System.EventHandler(this.unconnectionToolStripMenuItem_Click);
            // 
            // asyncConnectionToolStripMenuItem
            // 
            this.asyncConnectionToolStripMenuItem.Name = "asyncConnectionToolStripMenuItem";
            this.asyncConnectionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.asyncConnectionToolStripMenuItem.Text = "Асинхронное подключение к БД";
            this.asyncConnectionToolStripMenuItem.Click += new System.EventHandler(this.asyncConnectionToolStripMenuItem_Click);
            // 
            // listConnectionsToolStripMenuItem
            // 
            this.listConnectionsToolStripMenuItem.Name = "listConnectionsToolStripMenuItem";
            this.listConnectionsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listConnectionsToolStripMenuItem.Text = "Список подкючений";
            this.listConnectionsToolStripMenuItem.Click += new System.EventHandler(this.listConnectionsToolStripMenuItem_Click);
            // 
            // numProdButton
            // 
            this.numProdButton.Location = new System.Drawing.Point(38, 58);
            this.numProdButton.Name = "numProdButton";
            this.numProdButton.Size = new System.Drawing.Size(190, 23);
            this.numProdButton.TabIndex = 1;
            this.numProdButton.Text = "Cколько продуктов";
            this.numProdButton.UseVisualStyleBackColor = true;
            this.numProdButton.Click += new System.EventHandler(this.numProdButton_Click);
            // 
            // numProdLabel
            // 
            this.numProdLabel.AutoSize = true;
            this.numProdLabel.Location = new System.Drawing.Point(252, 63);
            this.numProdLabel.Name = "numProdLabel";
            this.numProdLabel.Size = new System.Drawing.Size(0, 13);
            this.numProdLabel.TabIndex = 2;
            // 
            // numProdButton2
            // 
            this.numProdButton2.Location = new System.Drawing.Point(38, 103);
            this.numProdButton2.Name = "numProdButton2";
            this.numProdButton2.Size = new System.Drawing.Size(190, 23);
            this.numProdButton2.TabIndex = 3;
            this.numProdButton2.Text = "Сколько продуктов 2 ";
            this.numProdButton2.UseVisualStyleBackColor = true;
            this.numProdButton2.Click += new System.EventHandler(this.numProdButton2_Click);
            // 
            // numProdLabel2
            // 
            this.numProdLabel2.AutoSize = true;
            this.numProdLabel2.Location = new System.Drawing.Point(255, 112);
            this.numProdLabel2.Name = "numProdLabel2";
            this.numProdLabel2.Size = new System.Drawing.Size(0, 13);
            this.numProdLabel2.TabIndex = 4;
            // 
            // listProdButton
            // 
            this.listProdButton.Location = new System.Drawing.Point(38, 181);
            this.listProdButton.Name = "listProdButton";
            this.listProdButton.Size = new System.Drawing.Size(134, 23);
            this.listProdButton.TabIndex = 5;
            this.listProdButton.Text = "Список продуктов";
            this.listProdButton.UseVisualStyleBackColor = true;
            this.listProdButton.Click += new System.EventHandler(this.listProdButton_Click);
            // 
            // listProdListView
            // 
            this.listProdListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listProdСolumnHeader1,
            this.priceColumnHeader,
            this.quantityColumnHeader});
            this.listProdListView.HideSelection = false;
            this.listProdListView.Location = new System.Drawing.Point(190, 181);
            this.listProdListView.Name = "listProdListView";
            this.listProdListView.Size = new System.Drawing.Size(367, 170);
            this.listProdListView.TabIndex = 6;
            this.listProdListView.UseCompatibleStateImageBehavior = false;
            this.listProdListView.View = System.Windows.Forms.View.Details;
            // 
            // listProdСolumnHeader1
            // 
            this.listProdСolumnHeader1.Text = "Название продукта";
            this.listProdСolumnHeader1.Width = 128;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "Цена продукта";
            this.priceColumnHeader.Width = 95;
            // 
            // quantityColumnHeader
            // 
            this.quantityColumnHeader.Text = "Фасовка продукта";
            this.quantityColumnHeader.Width = 139;
            // 
            // transactionsButton
            // 
            this.transactionsButton.Location = new System.Drawing.Point(38, 376);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(92, 23);
            this.transactionsButton.TabIndex = 7;
            this.transactionsButton.Text = "Транзакция";
            this.transactionsButton.UseVisualStyleBackColor = true;
            this.transactionsButton.Click += new System.EventHandler(this.transactionsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactionsButton);
            this.Controls.Add(this.listProdListView);
            this.Controls.Add(this.listProdButton);
            this.Controls.Add(this.numProdLabel2);
            this.Controls.Add(this.numProdButton2);
            this.Controls.Add(this.numProdLabel);
            this.Controls.Add(this.numProdButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работа с базой данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listConnectionsToolStripMenuItem;
        private System.Windows.Forms.Button numProdButton;
        private System.Windows.Forms.Label numProdLabel;
        private System.Windows.Forms.Button numProdButton2;
        private System.Windows.Forms.Label numProdLabel2;
        private System.Windows.Forms.Button listProdButton;
        private System.Windows.Forms.ListView listProdListView;
        private System.Windows.Forms.ColumnHeader listProdСolumnHeader1;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
        private System.Windows.Forms.ColumnHeader quantityColumnHeader;
        private System.Windows.Forms.Button transactionsButton;
    }
}

