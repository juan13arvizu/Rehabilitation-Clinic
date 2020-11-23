namespace Rehabilitation_Clinic_JIZ
{
    partial class Specialist
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
            this.PswBoxtxt3 = new System.Windows.Forms.TextBox();
            this.LoginBotton3 = new System.Windows.Forms.Button();
            this.PswBoxlabel = new System.Windows.Forms.Label();
            this.UserBoxtxt3 = new System.Windows.Forms.TextBox();
            this.UserBoxLabel = new System.Windows.Forms.Label();
            this.SignBotton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LogoLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.Location = new System.Drawing.Point(195, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(378, 30);
            this.LogoLabel.TabIndex = 27;
            this.LogoLabel.Text = "Clínica de Rehabilitación JIZ";
            // 
            // PswBoxtxt3
            // 
            this.PswBoxtxt3.Location = new System.Drawing.Point(36, 175);
            this.PswBoxtxt3.Name = "PswBoxtxt3";
            this.PswBoxtxt3.Size = new System.Drawing.Size(201, 20);
            this.PswBoxtxt3.TabIndex = 26;
            this.PswBoxtxt3.TextChanged += new System.EventHandler(this.PswBoxtxt3_TextChanged);
            // 
            // LoginBotton3
            // 
            this.LoginBotton3.BackColor = System.Drawing.Color.Crimson;
            this.LoginBotton3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBotton3.ForeColor = System.Drawing.Color.Transparent;
            this.LoginBotton3.Location = new System.Drawing.Point(67, 218);
            this.LoginBotton3.Name = "LoginBotton3";
            this.LoginBotton3.Size = new System.Drawing.Size(137, 37);
            this.LoginBotton3.TabIndex = 25;
            this.LoginBotton3.Tag = "";
            this.LoginBotton3.Text = "Log in";
            this.LoginBotton3.UseVisualStyleBackColor = false;
            this.LoginBotton3.Click += new System.EventHandler(this.LoginBotton3_Click);
            // 
            // PswBoxlabel
            // 
            this.PswBoxlabel.AutoSize = true;
            this.PswBoxlabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PswBoxlabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PswBoxlabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PswBoxlabel.Location = new System.Drawing.Point(61, 139);
            this.PswBoxlabel.Name = "PswBoxlabel";
            this.PswBoxlabel.Size = new System.Drawing.Size(124, 26);
            this.PswBoxlabel.TabIndex = 23;
            this.PswBoxlabel.Text = "Password";
            // 
            // UserBoxtxt3
            // 
            this.UserBoxtxt3.Location = new System.Drawing.Point(36, 99);
            this.UserBoxtxt3.Name = "UserBoxtxt3";
            this.UserBoxtxt3.Size = new System.Drawing.Size(201, 20);
            this.UserBoxtxt3.TabIndex = 22;
            this.UserBoxtxt3.TextChanged += new System.EventHandler(this.UserBoxtxt3_TextChanged);
            // 
            // UserBoxLabel
            // 
            this.UserBoxLabel.AutoSize = true;
            this.UserBoxLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UserBoxLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBoxLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserBoxLabel.Location = new System.Drawing.Point(61, 63);
            this.UserBoxLabel.Name = "UserBoxLabel";
            this.UserBoxLabel.Size = new System.Drawing.Size(129, 26);
            this.UserBoxLabel.TabIndex = 21;
            this.UserBoxLabel.Text = "Username";
            // 
            // SignBotton3
            // 
            this.SignBotton3.BackColor = System.Drawing.Color.Crimson;
            this.SignBotton3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignBotton3.ForeColor = System.Drawing.Color.Transparent;
            this.SignBotton3.Location = new System.Drawing.Point(561, 218);
            this.SignBotton3.Name = "SignBotton3";
            this.SignBotton3.Size = new System.Drawing.Size(137, 37);
            this.SignBotton3.TabIndex = 28;
            this.SignBotton3.Tag = "";
            this.SignBotton3.Text = "Sign in";
            this.SignBotton3.UseVisualStyleBackColor = false;
            this.SignBotton3.Click += new System.EventHandler(this.SignBotton3_Click);
            // 
            // Specialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 290);
            this.Controls.Add(this.SignBotton3);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.PswBoxtxt3);
            this.Controls.Add(this.LoginBotton3);
            this.Controls.Add(this.PswBoxlabel);
            this.Controls.Add(this.UserBoxtxt3);
            this.Controls.Add(this.UserBoxLabel);
            this.Name = "Specialist";
            this.Text = "Specialist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.TextBox PswBoxtxt3;
        private System.Windows.Forms.Button LoginBotton3;
        private System.Windows.Forms.Label PswBoxlabel;
        private System.Windows.Forms.TextBox UserBoxtxt3;
        private System.Windows.Forms.Label UserBoxLabel;
        private System.Windows.Forms.Button SignBotton3;
    }
}