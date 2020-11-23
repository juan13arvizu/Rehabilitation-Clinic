namespace Rehabilitation_Clinic_JIZ
{
    partial class Admin
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
            this.LogoLabel = new System.Windows.Forms.Label();
            this.PswBoxtxt1 = new System.Windows.Forms.TextBox();
            this.LoginBotton1 = new System.Windows.Forms.Button();
            this.PswBoxlabel = new System.Windows.Forms.Label();
            this.UserBoxtxt1 = new System.Windows.Forms.TextBox();
            this.UserBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LogoLabel.Location = new System.Drawing.Point(172, 17);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(378, 30);
            this.LogoLabel.TabIndex = 33;
            this.LogoLabel.Text = "Clínica de Rehabilitación JIZ";
            // 
            // PswBoxtxt1
            // 
            this.PswBoxtxt1.Location = new System.Drawing.Point(62, 106);
            this.PswBoxtxt1.Name = "PswBoxtxt1";
            this.PswBoxtxt1.Size = new System.Drawing.Size(167, 34);
            this.PswBoxtxt1.TabIndex = 34;
            this.PswBoxtxt1.TextChanged += new System.EventHandler(this.PswBoxtxt1_TextChanged);
            // 
            // LoginBotton1
            // 
            this.LoginBotton1.BackColor = System.Drawing.Color.Magenta;
            this.LoginBotton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBotton1.Location = new System.Drawing.Point(577, 206);
            this.LoginBotton1.Name = "LoginBotton1";
            this.LoginBotton1.Size = new System.Drawing.Size(132, 35);
            this.LoginBotton1.TabIndex = 35;
            this.LoginBotton1.Text = "Log in";
            this.LoginBotton1.UseVisualStyleBackColor = false;
            this.LoginBotton1.Click += new System.EventHandler(this.LoginBotton1_Click);
            // 
            // PswBoxlabel
            // 
            this.PswBoxlabel.AutoSize = true;
            this.PswBoxlabel.BackColor = System.Drawing.Color.BlueViolet;
            this.PswBoxlabel.ForeColor = System.Drawing.Color.Lime;
            this.PswBoxlabel.Location = new System.Drawing.Point(73, 165);
            this.PswBoxlabel.Name = "PswBoxlabel";
            this.PswBoxlabel.Size = new System.Drawing.Size(139, 30);
            this.PswBoxlabel.TabIndex = 32;
            this.PswBoxlabel.Text = "Password";
            // 
            // UserBoxtxt1
            // 
            this.UserBoxtxt1.Location = new System.Drawing.Point(63, 198);
            this.UserBoxtxt1.Name = "UserBoxtxt1";
            this.UserBoxtxt1.Size = new System.Drawing.Size(166, 34);
            this.UserBoxtxt1.TabIndex = 36;
            this.UserBoxtxt1.TextChanged += new System.EventHandler(this.UserBoxtxt1_TextChanged);
            // 
            // UserBoxLabel
            // 
            this.UserBoxLabel.AutoSize = true;
            this.UserBoxLabel.BackColor = System.Drawing.Color.BlueViolet;
            this.UserBoxLabel.ForeColor = System.Drawing.Color.Lime;
            this.UserBoxLabel.Location = new System.Drawing.Point(73, 73);
            this.UserBoxLabel.Name = "UserBoxLabel";
            this.UserBoxLabel.Size = new System.Drawing.Size(145, 30);
            this.UserBoxLabel.TabIndex = 31;
            this.UserBoxLabel.Text = "Username";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 265);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.PswBoxtxt1);
            this.Controls.Add(this.LoginBotton1);
            this.Controls.Add(this.PswBoxlabel);
            this.Controls.Add(this.UserBoxtxt1);
            this.Controls.Add(this.UserBoxLabel);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.TextBox PswBoxtxt1;
        private System.Windows.Forms.Button LoginBotton1;
        private System.Windows.Forms.Label PswBoxlabel;
        private System.Windows.Forms.TextBox UserBoxtxt1;
        private System.Windows.Forms.Label UserBoxLabel;
    }
}