namespace Maturski_rad
{
    partial class FormUputstvo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPageBack = new System.Windows.Forms.Button();
            this.btnPageForward = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picDodajUputstvo = new System.Windows.Forms.PictureBox();
            this.picMainForma = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajUputstvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainForma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kako koristiti ovu aplikaciju?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPageBack
            // 
            this.btnPageBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPageBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPageBack.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageBack.Location = new System.Drawing.Point(145, 554);
            this.btnPageBack.Name = "btnPageBack";
            this.btnPageBack.Size = new System.Drawing.Size(197, 59);
            this.btnPageBack.TabIndex = 2;
            this.btnPageBack.Text = "<<<";
            this.btnPageBack.UseVisualStyleBackColor = false;
            this.btnPageBack.Click += new System.EventHandler(this.btnPageBack_Click);
            // 
            // btnPageForward
            // 
            this.btnPageForward.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPageForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPageForward.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageForward.Location = new System.Drawing.Point(750, 554);
            this.btnPageForward.Name = "btnPageForward";
            this.btnPageForward.Size = new System.Drawing.Size(197, 59);
            this.btnPageForward.TabIndex = 3;
            this.btnPageForward.Text = ">>>";
            this.btnPageForward.UseVisualStyleBackColor = false;
            this.btnPageForward.Click += new System.EventHandler(this.btnPageForward_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.picDodajUputstvo);
            this.panel1.Controls.Add(this.picMainForma);
            this.panel1.Controls.Add(this.btnPageForward);
            this.panel1.Controls.Add(this.btnPageBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 638);
            this.panel1.TabIndex = 1;
            // 
            // picDodajUputstvo
            // 
            this.picDodajUputstvo.Image = global::Maturski_rad.Properties.Resources.IzmeniUputstvo;
            this.picDodajUputstvo.Location = new System.Drawing.Point(145, 54);
            this.picDodajUputstvo.Name = "picDodajUputstvo";
            this.picDodajUputstvo.Size = new System.Drawing.Size(802, 494);
            this.picDodajUputstvo.TabIndex = 4;
            this.picDodajUputstvo.TabStop = false;
            // 
            // picMainForma
            // 
            this.picMainForma.Image = global::Maturski_rad.Properties.Resources.Glavno_uputstvo;
            this.picMainForma.Location = new System.Drawing.Point(145, 54);
            this.picMainForma.Name = "picMainForma";
            this.picMainForma.Size = new System.Drawing.Size(802, 494);
            this.picMainForma.TabIndex = 1;
            this.picMainForma.TabStop = false;
            // 
            // FormUputstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 638);
            this.Controls.Add(this.panel1);
            this.Name = "FormUputstvo";
            this.Text = "Uputstvo";
            this.Load += new System.EventHandler(this.FormUputstvo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajUputstvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainForma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainForma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPageBack;
        private System.Windows.Forms.Button btnPageForward;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picDodajUputstvo;
    }
}