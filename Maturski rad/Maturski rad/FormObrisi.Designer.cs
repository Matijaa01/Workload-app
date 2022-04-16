namespace Maturski_rad
{
    partial class FormObrisi
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
            this.btnObrisi2 = new System.Windows.Forms.Button();
            this.txtIDObrisi = new System.Windows.Forms.TextBox();
            this.labime2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObrisi2
            // 
            this.btnObrisi2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObrisi2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisi2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi2.Location = new System.Drawing.Point(36, 57);
            this.btnObrisi2.Name = "btnObrisi2";
            this.btnObrisi2.Size = new System.Drawing.Size(242, 72);
            this.btnObrisi2.TabIndex = 17;
            this.btnObrisi2.Text = "OBRIŠI";
            this.btnObrisi2.UseVisualStyleBackColor = false;
            this.btnObrisi2.Click += new System.EventHandler(this.btnObrisi2_Click);
            // 
            // txtIDObrisi
            // 
            this.txtIDObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDObrisi.Location = new System.Drawing.Point(36, 12);
            this.txtIDObrisi.Multiline = true;
            this.txtIDObrisi.Name = "txtIDObrisi";
            this.txtIDObrisi.Size = new System.Drawing.Size(242, 39);
            this.txtIDObrisi.TabIndex = 18;
            // 
            // labime2
            // 
            this.labime2.AutoSize = true;
            this.labime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labime2.Location = new System.Drawing.Point(3, 15);
            this.labime2.Name = "labime2";
            this.labime2.Size = new System.Drawing.Size(27, 24);
            this.labime2.TabIndex = 19;
            this.labime2.Text = "ID";
            // 
            // FormObrisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 135);
            this.Controls.Add(this.labime2);
            this.Controls.Add(this.txtIDObrisi);
            this.Controls.Add(this.btnObrisi2);
            this.Name = "FormObrisi";
            this.Text = "FormObrisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi2;
        private System.Windows.Forms.TextBox txtIDObrisi;
        private System.Windows.Forms.Label labime2;
    }
}