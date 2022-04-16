namespace Maturski_rad
{
    partial class FormDodaj
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
            this.labime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.labPrez = new System.Windows.Forms.Label();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.labPol = new System.Windows.Forms.Label();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.radbtnM = new System.Windows.Forms.RadioButton();
            this.radbtnZ = new System.Windows.Forms.RadioButton();
            this.txtStrsp = new System.Windows.Forms.TextBox();
            this.labStrsp = new System.Windows.Forms.Label();
            this.txtBrCasova = new System.Windows.Forms.TextBox();
            this.labBrCasova = new System.Windows.Forms.Label();
            this.txtNorma = new System.Windows.Forms.TextBox();
            this.labNorma = new System.Windows.Forms.Label();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labime
            // 
            this.labime.AutoSize = true;
            this.labime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labime.Location = new System.Drawing.Point(12, 27);
            this.labime.Name = "labime";
            this.labime.Size = new System.Drawing.Size(41, 24);
            this.labime.TabIndex = 0;
            this.labime.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(126, 27);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 33);
            this.txtIme.TabIndex = 1;
            // 
            // labPrez
            // 
            this.labPrez.AutoSize = true;
            this.labPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrez.Location = new System.Drawing.Point(12, 66);
            this.labPrez.Name = "labPrez";
            this.labPrez.Size = new System.Drawing.Size(79, 24);
            this.labPrez.TabIndex = 2;
            this.labPrez.Text = "Prezime";
            // 
            // txtPrez
            // 
            this.txtPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrez.Location = new System.Drawing.Point(126, 66);
            this.txtPrez.Multiline = true;
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(197, 33);
            this.txtPrez.TabIndex = 3;
            // 
            // labPol
            // 
            this.labPol.AutoSize = true;
            this.labPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPol.Location = new System.Drawing.Point(12, 108);
            this.labPol.Name = "labPol";
            this.labPol.Size = new System.Drawing.Size(37, 24);
            this.labPol.TabIndex = 4;
            this.labPol.Text = "Pol";
            // 
            // txtPol
            // 
            this.txtPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPol.Location = new System.Drawing.Point(126, 105);
            this.txtPol.Multiline = true;
            this.txtPol.Name = "txtPol";
            this.txtPol.Size = new System.Drawing.Size(197, 33);
            this.txtPol.TabIndex = 5;
            // 
            // radbtnM
            // 
            this.radbtnM.AutoSize = true;
            this.radbtnM.Location = new System.Drawing.Point(326, 105);
            this.radbtnM.Name = "radbtnM";
            this.radbtnM.Size = new System.Drawing.Size(53, 17);
            this.radbtnM.TabIndex = 6;
            this.radbtnM.TabStop = true;
            this.radbtnM.Text = "Muški";
            this.radbtnM.UseVisualStyleBackColor = true;
            this.radbtnM.CheckedChanged += new System.EventHandler(this.radbtnM_CheckedChanged);
            // 
            // radbtnZ
            // 
            this.radbtnZ.AutoSize = true;
            this.radbtnZ.Location = new System.Drawing.Point(326, 121);
            this.radbtnZ.Name = "radbtnZ";
            this.radbtnZ.Size = new System.Drawing.Size(57, 17);
            this.radbtnZ.TabIndex = 7;
            this.radbtnZ.TabStop = true;
            this.radbtnZ.Text = "Ženski";
            this.radbtnZ.UseVisualStyleBackColor = true;
            this.radbtnZ.CheckedChanged += new System.EventHandler(this.radbtnZ_CheckedChanged);
            // 
            // txtStrsp
            // 
            this.txtStrsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrsp.Location = new System.Drawing.Point(126, 147);
            this.txtStrsp.Multiline = true;
            this.txtStrsp.Name = "txtStrsp";
            this.txtStrsp.Size = new System.Drawing.Size(197, 33);
            this.txtStrsp.TabIndex = 8;
            // 
            // labStrsp
            // 
            this.labStrsp.AutoSize = true;
            this.labStrsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStrsp.Location = new System.Drawing.Point(12, 147);
            this.labStrsp.Name = "labStrsp";
            this.labStrsp.Size = new System.Drawing.Size(105, 24);
            this.labStrsp.TabIndex = 9;
            this.labStrsp.Text = "Str. sprema";
            // 
            // txtBrCasova
            // 
            this.txtBrCasova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrCasova.Location = new System.Drawing.Point(126, 186);
            this.txtBrCasova.Multiline = true;
            this.txtBrCasova.Name = "txtBrCasova";
            this.txtBrCasova.Size = new System.Drawing.Size(197, 33);
            this.txtBrCasova.TabIndex = 10;
            // 
            // labBrCasova
            // 
            this.labBrCasova.AutoSize = true;
            this.labBrCasova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBrCasova.Location = new System.Drawing.Point(12, 186);
            this.labBrCasova.Name = "labBrCasova";
            this.labBrCasova.Size = new System.Drawing.Size(97, 24);
            this.labBrCasova.TabIndex = 11;
            this.labBrCasova.Text = "Br. časova";
            // 
            // txtNorma
            // 
            this.txtNorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNorma.Location = new System.Drawing.Point(126, 225);
            this.txtNorma.Multiline = true;
            this.txtNorma.Name = "txtNorma";
            this.txtNorma.Size = new System.Drawing.Size(197, 33);
            this.txtNorma.TabIndex = 12;
            // 
            // labNorma
            // 
            this.labNorma.AutoSize = true;
            this.labNorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNorma.Location = new System.Drawing.Point(12, 225);
            this.labNorma.Name = "labNorma";
            this.labNorma.Size = new System.Drawing.Size(67, 24);
            this.labNorma.TabIndex = 13;
            this.labNorma.Text = "Norma";
            // 
            // btnUbaci
            // 
            this.btnUbaci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUbaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUbaci.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaci.Location = new System.Drawing.Point(126, 303);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(197, 72);
            this.btnUbaci.TabIndex = 14;
            this.btnUbaci.Text = "DODAJ";
            this.btnUbaci.UseVisualStyleBackColor = false;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeni.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(126, 303);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(197, 72);
            this.btnIzmeni.TabIndex = 15;
            this.btnIzmeni.Text = "IZMENI";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(126, 264);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(197, 33);
            this.txtID.TabIndex = 17;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(12, 264);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(27, 24);
            this.labID.TabIndex = 18;
            this.labID.Text = "ID";
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 380);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnUbaci);
            this.Controls.Add(this.labNorma);
            this.Controls.Add(this.txtNorma);
            this.Controls.Add(this.labBrCasova);
            this.Controls.Add(this.txtBrCasova);
            this.Controls.Add(this.labStrsp);
            this.Controls.Add(this.txtStrsp);
            this.Controls.Add(this.radbtnZ);
            this.Controls.Add(this.radbtnM);
            this.Controls.Add(this.txtPol);
            this.Controls.Add(this.labPol);
            this.Controls.Add(this.txtPrez);
            this.Controls.Add(this.labPrez);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.labime);
            this.Name = "FormDodaj";
            this.Text = "Osoba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labPrez;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.Label labPol;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.RadioButton radbtnM;
        private System.Windows.Forms.RadioButton radbtnZ;
        private System.Windows.Forms.TextBox txtStrsp;
        private System.Windows.Forms.Label labStrsp;
        private System.Windows.Forms.TextBox txtBrCasova;
        private System.Windows.Forms.Label labBrCasova;
        private System.Windows.Forms.TextBox txtNorma;
        private System.Windows.Forms.Label labNorma;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
    }
}