
namespace Journal
{
    partial class authorization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1authorization = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(177)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PassField);
            this.panel1.Controls.Add(this.LoginField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1authorization);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(142)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(281, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 78);
            this.button1.TabIndex = 9;
            this.button1.Text = "войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.Black;
            this.PassField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassField.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.ForeColor = System.Drawing.Color.White;
            this.PassField.Location = new System.Drawing.Point(267, 227);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(336, 58);
            this.PassField.TabIndex = 8;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.BackColor = System.Drawing.Color.Black;
            this.LoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginField.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.Color.White;
            this.LoginField.Location = new System.Drawing.Point(267, 130);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(336, 58);
            this.LoginField.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Journal.Properties.Resources._7;
            this.pictureBox2.Location = new System.Drawing.Point(177, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(177)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::Journal.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(177, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1authorization
            // 
            this.label1authorization.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1authorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1authorization.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1authorization.Location = new System.Drawing.Point(40, 40);
            this.label1authorization.Name = "label1authorization";
            this.label1authorization.Size = new System.Drawing.Size(720, 47);
            this.label1authorization.TabIndex = 4;
            this.label1authorization.Text = "введите свой логин и пароль";
            this.label1authorization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 370);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(760, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 370);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 40);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(764, -3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 39);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "authorization";
            this.Text = "authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1authorization;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CloseButton;
    }
}

