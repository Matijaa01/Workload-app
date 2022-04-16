namespace Maturski_rad
{
    partial class FormSignUp
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
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.labimesignup = new System.Windows.Forms.Label();
            this.txtKljuc = new System.Windows.Forms.TextBox();
            this.labkljuc = new System.Windows.Forms.Label();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.labPass = new System.Windows.Forms.Label();
            this.btnKreirajNalog = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.labIDacc = new System.Windows.Forms.Label();
            this.txtIDacc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.Location = new System.Drawing.Point(115, 58);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(197, 29);
            this.txtUsernameSignUp.TabIndex = 2;
            // 
            // labimesignup
            // 
            this.labimesignup.AutoSize = true;
            this.labimesignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labimesignup.Location = new System.Drawing.Point(12, 61);
            this.labimesignup.Name = "labimesignup";
            this.labimesignup.Size = new System.Drawing.Size(97, 24);
            this.labimesignup.TabIndex = 3;
            this.labimesignup.Text = "Username";
            // 
            // txtKljuc
            // 
            this.txtKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKljuc.Location = new System.Drawing.Point(115, 97);
            this.txtKljuc.Name = "txtKljuc";
            this.txtKljuc.Size = new System.Drawing.Size(197, 29);
            this.txtKljuc.TabIndex = 4;
            this.txtKljuc.UseSystemPasswordChar = true;
            // 
            // labkljuc
            // 
            this.labkljuc.AutoSize = true;
            this.labkljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labkljuc.Location = new System.Drawing.Point(12, 100);
            this.labkljuc.Name = "labkljuc";
            this.labkljuc.Size = new System.Drawing.Size(51, 24);
            this.labkljuc.TabIndex = 5;
            this.labkljuc.Text = "Ključ";
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(115, 136);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(197, 29);
            this.txtPasswordSignUp.TabIndex = 6;
            this.txtPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPass.Location = new System.Drawing.Point(12, 139);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(92, 24);
            this.labPass.TabIndex = 7;
            this.labPass.Text = "Password";
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKreirajNalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKreirajNalog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajNalog.Location = new System.Drawing.Point(12, 175);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(110, 38);
            this.btnKreirajNalog.TabIndex = 8;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseVisualStyleBackColor = false;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAcc.Location = new System.Drawing.Point(199, 175);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteAcc.TabIndex = 9;
            this.btnDeleteAcc.Text = "Obriši nalog";
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // labIDacc
            // 
            this.labIDacc.AutoSize = true;
            this.labIDacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIDacc.Location = new System.Drawing.Point(8, 22);
            this.labIDacc.Name = "labIDacc";
            this.labIDacc.Size = new System.Drawing.Size(27, 24);
            this.labIDacc.TabIndex = 10;
            this.labIDacc.Text = "ID";
            // 
            // txtIDacc
            // 
            this.txtIDacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDacc.Location = new System.Drawing.Point(115, 19);
            this.txtIDacc.Name = "txtIDacc";
            this.txtIDacc.Size = new System.Drawing.Size(197, 29);
            this.txtIDacc.TabIndex = 11;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 225);
            this.Controls.Add(this.txtIDacc);
            this.Controls.Add(this.labIDacc);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.btnKreirajNalog);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.labkljuc);
            this.Controls.Add(this.txtKljuc);
            this.Controls.Add(this.labimesignup);
            this.Controls.Add(this.txtUsernameSignUp);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje naloga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label labimesignup;
        private System.Windows.Forms.TextBox txtKljuc;
        private System.Windows.Forms.Label labkljuc;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Button btnKreirajNalog;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Label labIDacc;
        private System.Windows.Forms.TextBox txtIDacc;
    }
}