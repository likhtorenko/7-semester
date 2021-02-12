namespace WindowsFormsApp1
{
    partial class AppendClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendClients));
            this.Famili = new System.Windows.Forms.TextBox();
            this.NameClients = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.PhoneClients = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.TextBox();
            this.BirthDay = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.DataRegistr = new System.Windows.Forms.TextBox();
            this.Pol = new System.Windows.Forms.ComboBox();
            this.DayFirst = new System.Windows.Forms.DateTimePicker();
            this.Reg = new System.Windows.Forms.DateTimePicker();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Famili
            // 
            this.Famili.Location = new System.Drawing.Point(38, 12);
            this.Famili.Name = "Famili";
            this.Famili.Size = new System.Drawing.Size(159, 21);
            this.Famili.TabIndex = 0;
            this.Famili.Text = "Фамилия";
            this.Famili.Click += new System.EventHandler(this.DellText);
            // 
            // NameClients
            // 
            this.NameClients.Location = new System.Drawing.Point(38, 55);
            this.NameClients.Name = "NameClients";
            this.NameClients.Size = new System.Drawing.Size(159, 21);
            this.NameClients.TabIndex = 1;
            this.NameClients.Text = "Имя";
            this.NameClients.Click += new System.EventHandler(this.DellText);
            // 
            // FatherName
            // 
            this.FatherName.Location = new System.Drawing.Point(38, 96);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(159, 21);
            this.FatherName.TabIndex = 2;
            this.FatherName.Text = "Отчество";
            this.FatherName.Click += new System.EventHandler(this.DellText);
            // 
            // PhoneClients
            // 
            this.PhoneClients.Location = new System.Drawing.Point(38, 178);
            this.PhoneClients.Name = "PhoneClients";
            this.PhoneClients.Size = new System.Drawing.Size(159, 21);
            this.PhoneClients.TabIndex = 3;
            this.PhoneClients.Text = "Телефон";
            this.PhoneClients.Click += new System.EventHandler(this.DellText);
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(38, 217);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(159, 21);
            this.Image.TabIndex = 4;
            this.Image.Text = "Адрес фото";
            this.Image.Click += new System.EventHandler(this.DellText);
            // 
            // BirthDay
            // 
            this.BirthDay.Location = new System.Drawing.Point(38, 253);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            this.BirthDay.Size = new System.Drawing.Size(159, 21);
            this.BirthDay.TabIndex = 5;
            this.BirthDay.Text = "День рождения";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(38, 294);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(159, 21);
            this.Mail.TabIndex = 6;
            this.Mail.Text = "Email";
            this.Mail.Click += new System.EventHandler(this.DellText);
            // 
            // DataRegistr
            // 
            this.DataRegistr.Location = new System.Drawing.Point(38, 329);
            this.DataRegistr.Name = "DataRegistr";
            this.DataRegistr.ReadOnly = true;
            this.DataRegistr.Size = new System.Drawing.Size(159, 21);
            this.DataRegistr.TabIndex = 7;
            this.DataRegistr.Text = "Дата регистрации";
            // 
            // Pol
            // 
            this.Pol.FormattingEnabled = true;
            this.Pol.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.Pol.Location = new System.Drawing.Point(38, 133);
            this.Pol.Name = "Pol";
            this.Pol.Size = new System.Drawing.Size(159, 21);
            this.Pol.TabIndex = 8;
            this.Pol.Text = "Мужской";
            // 
            // DayFirst
            // 
            this.DayFirst.Location = new System.Drawing.Point(228, 253);
            this.DayFirst.Name = "DayFirst";
            this.DayFirst.Size = new System.Drawing.Size(175, 21);
            this.DayFirst.TabIndex = 9;
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(228, 329);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(175, 21);
            this.Reg.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(58, 427);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(305, 31);
            this.Save.TabIndex = 11;
            this.Save.Text = "Сохранение клиента";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AppendClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(447, 488);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.DayFirst);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.DataRegistr);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.PhoneClients);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.NameClients);
            this.Controls.Add(this.Famili);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppendClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Famili;
        private System.Windows.Forms.TextBox NameClients;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.TextBox PhoneClients;
        private System.Windows.Forms.TextBox Image;
        private System.Windows.Forms.TextBox BirthDay;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox DataRegistr;
        private System.Windows.Forms.ComboBox Pol;
        private System.Windows.Forms.DateTimePicker DayFirst;
        private System.Windows.Forms.DateTimePicker Reg;
        private System.Windows.Forms.Button Save;
    }
}