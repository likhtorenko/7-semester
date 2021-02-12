namespace WindowsFormsApp1
{
    partial class ClientsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsList));
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.FindPol = new System.Windows.Forms.ComboBox();
            this.FindNameClients = new System.Windows.Forms.TextBox();
            this.Research = new System.Windows.Forms.ComboBox();
            this.NextClient = new System.Windows.Forms.Button();
            this.LastClient = new System.Windows.Forms.Button();
            this.DeletedClients = new System.Windows.Forms.Button();
            this.AppendClients = new System.Windows.Forms.Button();
            this.Engeering = new System.Windows.Forms.Button();
            this.Moving = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(1, 0);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(1101, 633);
            this.MainGrid.TabIndex = 0;
            // 
            // FindPol
            // 
            this.FindPol.FormattingEnabled = true;
            this.FindPol.Items.AddRange(new object[] {
            "Все",
            "Мужской",
            "Женский"});
            this.FindPol.Location = new System.Drawing.Point(1175, 61);
            this.FindPol.Name = "FindPol";
            this.FindPol.Size = new System.Drawing.Size(248, 21);
            this.FindPol.TabIndex = 1;
            this.FindPol.Text = "Все";
            this.FindPol.SelectedIndexChanged += new System.EventHandler(this.PolChanged);
            // 
            // FindNameClients
            // 
            this.FindNameClients.Location = new System.Drawing.Point(1175, 109);
            this.FindNameClients.Name = "FindNameClients";
            this.FindNameClients.Size = new System.Drawing.Size(248, 21);
            this.FindNameClients.TabIndex = 2;
            this.FindNameClients.TextChanged += new System.EventHandler(this.FindNameCl);
            // 
            // Research
            // 
            this.Research.FormattingEnabled = true;
            this.Research.Items.AddRange(new object[] {
            "Без сортировки",
            "Фамилия",
            "Дата посещения"});
            this.Research.Location = new System.Drawing.Point(1175, 158);
            this.Research.Name = "Research";
            this.Research.Size = new System.Drawing.Size(248, 21);
            this.Research.TabIndex = 3;
            this.Research.Text = "Все";
            this.Research.SelectedIndexChanged += new System.EventHandler(this.Sorted);
            // 
            // NextClient
            // 
            this.NextClient.Location = new System.Drawing.Point(1175, 208);
            this.NextClient.Name = "NextClient";
            this.NextClient.Size = new System.Drawing.Size(248, 34);
            this.NextClient.TabIndex = 4;
            this.NextClient.Text = "Следующий клиент";
            this.NextClient.UseVisualStyleBackColor = true;
            this.NextClient.Click += new System.EventHandler(this.NextClients);
            // 
            // LastClient
            // 
            this.LastClient.Location = new System.Drawing.Point(1175, 262);
            this.LastClient.Name = "LastClient";
            this.LastClient.Size = new System.Drawing.Size(248, 34);
            this.LastClient.TabIndex = 5;
            this.LastClient.Text = "Предыдущий клиент";
            this.LastClient.UseVisualStyleBackColor = true;
            this.LastClient.Click += new System.EventHandler(this.LastClients);
            // 
            // DeletedClients
            // 
            this.DeletedClients.Location = new System.Drawing.Point(1175, 318);
            this.DeletedClients.Name = "DeletedClients";
            this.DeletedClients.Size = new System.Drawing.Size(248, 34);
            this.DeletedClients.TabIndex = 6;
            this.DeletedClients.Text = "Удаление клиента";
            this.DeletedClients.UseVisualStyleBackColor = true;
            this.DeletedClients.Click += new System.EventHandler(this.DeletedClick);
            // 
            // AppendClients
            // 
            this.AppendClients.Location = new System.Drawing.Point(1175, 370);
            this.AppendClients.Name = "AppendClients";
            this.AppendClients.Size = new System.Drawing.Size(248, 34);
            this.AppendClients.TabIndex = 7;
            this.AppendClients.Text = "Добавление клиента";
            this.AppendClients.UseVisualStyleBackColor = true;
            this.AppendClients.Click += new System.EventHandler(this.Append);
            // 
            // Engeering
            // 
            this.Engeering.Location = new System.Drawing.Point(1175, 423);
            this.Engeering.Name = "Engeering";
            this.Engeering.Size = new System.Drawing.Size(248, 31);
            this.Engeering.TabIndex = 8;
            this.Engeering.Text = "Редактирование клиенат";
            this.Engeering.UseVisualStyleBackColor = true;
            this.Engeering.Click += new System.EventHandler(this.Engeneer);
            // 
            // Moving
            // 
            this.Moving.Location = new System.Drawing.Point(1175, 480);
            this.Moving.Name = "Moving";
            this.Moving.Size = new System.Drawing.Size(248, 31);
            this.Moving.TabIndex = 9;
            this.Moving.Text = "Посещаемость";
            this.Moving.UseVisualStyleBackColor = true;
            this.Moving.Click += new System.EventHandler(this.MovingClick);
            // 
            // ClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1475, 635);
            this.Controls.Add(this.Moving);
            this.Controls.Add(this.Engeering);
            this.Controls.Add(this.AppendClients);
            this.Controls.Add(this.DeletedClients);
            this.Controls.Add(this.LastClient);
            this.Controls.Add(this.NextClient);
            this.Controls.Add(this.Research);
            this.Controls.Add(this.FindNameClients);
            this.Controls.Add(this.FindPol);
            this.Controls.Add(this.MainGrid);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.ComboBox FindPol;
        private System.Windows.Forms.TextBox FindNameClients;
        private System.Windows.Forms.ComboBox Research;
        private System.Windows.Forms.Button NextClient;
        private System.Windows.Forms.Button LastClient;
        private System.Windows.Forms.Button DeletedClients;
        private System.Windows.Forms.Button AppendClients;
        private System.Windows.Forms.Button Engeering;
        private System.Windows.Forms.Button Moving;
    }
}