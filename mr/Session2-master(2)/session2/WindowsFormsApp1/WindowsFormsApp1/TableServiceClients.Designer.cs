namespace WindowsFormsApp1
{
    partial class TableServiceClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableServiceClients));
            this.GriedService = new System.Windows.Forms.DataGridView();
            this.Kol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GriedService)).BeginInit();
            this.SuspendLayout();
            // 
            // GriedService
            // 
            this.GriedService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriedService.Location = new System.Drawing.Point(1, 0);
            this.GriedService.Name = "GriedService";
            this.GriedService.Size = new System.Drawing.Size(441, 127);
            this.GriedService.TabIndex = 0;
            // 
            // Kol
            // 
            this.Kol.Location = new System.Drawing.Point(95, 133);
            this.Kol.Name = "Kol";
            this.Kol.ReadOnly = true;
            this.Kol.Size = new System.Drawing.Size(245, 21);
            this.Kol.TabIndex = 1;
            // 
            // TableServiceClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 164);
            this.Controls.Add(this.Kol);
            this.Controls.Add(this.GriedService);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableServiceClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица посещаемости клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.GriedService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GriedService;
        private System.Windows.Forms.TextBox Kol;
    }
}