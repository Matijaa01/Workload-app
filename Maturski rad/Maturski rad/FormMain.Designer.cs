namespace Maturski_rad
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiOsobuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportUExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učitajBazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.normaBazaDataSet = new Maturski_rad.NormaBazaDataSet();
            this.podaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.podaciTableAdapter = new Maturski_rad.NormaBazaDataSetTableAdapters.PodaciTableAdapter();
            this.normaBazaDataSet1 = new Maturski_rad.NormaBazaDataSet1();
            this.podaciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.podaciTableAdapter1 = new Maturski_rad.NormaBazaDataSet1TableAdapters.PodaciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimalnastrucnaspremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojcasovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normacasovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatangazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podaciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.normaBazaDataSet4 = new Maturski_rad.NormaBazaDataSet4();
            this.podaciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.normaBazaDataSet2 = new Maturski_rad.NormaBazaDataSet2();
            this.podaciTableAdapter2 = new Maturski_rad.NormaBazaDataSet2TableAdapters.PodaciTableAdapter();
            this.podaciTableAdapter3 = new Maturski_rad.NormaBazaDataSet4TableAdapters.PodaciTableAdapter();
            this.btnObrisiOsobu = new System.Windows.Forms.Button();
            this.btnIzmeniOsobu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXPORT U EXCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobuToolStripMenuItem,
            this.učitajBazuToolStripMenuItem,
            this.obrišiOsobuToolStripMenuItem,
            this.exportUExcelToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // osobuToolStripMenuItem
            // 
            this.osobuToolStripMenuItem.Name = "osobuToolStripMenuItem";
            this.osobuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobuToolStripMenuItem.Text = "Dodaj Osobu";
            this.osobuToolStripMenuItem.Click += new System.EventHandler(this.osobuToolStripMenuItem_Click);
            // 
            // obrišiOsobuToolStripMenuItem
            // 
            this.obrišiOsobuToolStripMenuItem.Name = "obrišiOsobuToolStripMenuItem";
            this.obrišiOsobuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrišiOsobuToolStripMenuItem.Text = "Obriši osobu";
            this.obrišiOsobuToolStripMenuItem.Click += new System.EventHandler(this.obrišiOsobuToolStripMenuItem_Click);
            // 
            // exportUExcelToolStripMenuItem
            // 
            this.exportUExcelToolStripMenuItem.Name = "exportUExcelToolStripMenuItem";
            this.exportUExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportUExcelToolStripMenuItem.Text = "Export u Excel";
            this.exportUExcelToolStripMenuItem.Click += new System.EventHandler(this.exportUExcelToolStripMenuItem_Click);
            // 
            // učitajBazuToolStripMenuItem
            // 
            this.učitajBazuToolStripMenuItem.Name = "učitajBazuToolStripMenuItem";
            this.učitajBazuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.učitajBazuToolStripMenuItem.Text = "Izmeni Osobu";
            this.učitajBazuToolStripMenuItem.Click += new System.EventHandler(this.učitajBazuToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputstvoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // uputstvoToolStripMenuItem
            // 
            this.uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo";
            this.uputstvoToolStripMenuItem.Click += new System.EventHandler(this.uputstvoToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 86);
            this.button2.TabIndex = 2;
            this.button2.Text = "IZLAZ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(13, 27);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(132, 86);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj Osobu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // normaBazaDataSet
            // 
            this.normaBazaDataSet.DataSetName = "NormaBazaDataSet";
            this.normaBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // podaciBindingSource
            // 
            this.podaciBindingSource.DataMember = "Podaci";
            this.podaciBindingSource.DataSource = this.normaBazaDataSet;
            // 
            // podaciTableAdapter
            // 
            this.podaciTableAdapter.ClearBeforeFill = true;
            // 
            // normaBazaDataSet1
            // 
            this.normaBazaDataSet1.DataSetName = "NormaBazaDataSet1";
            this.normaBazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // podaciBindingSource1
            // 
            this.podaciBindingSource1.DataMember = "Podaci";
            this.podaciBindingSource1.DataSource = this.normaBazaDataSet1;
            // 
            // podaciTableAdapter1
            // 
            this.podaciTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.minimalnastrucnaspremaDataGridViewTextBoxColumn,
            this.brojcasovaDataGridViewTextBoxColumn,
            this.normacasovaDataGridViewTextBoxColumn,
            this.procenatangazovanjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.podaciBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(151, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 468);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 49;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "Pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Pol";
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 47;
            // 
            // minimalnastrucnaspremaDataGridViewTextBoxColumn
            // 
            this.minimalnastrucnaspremaDataGridViewTextBoxColumn.DataPropertyName = "Minimalna_strucna_sprema";
            this.minimalnastrucnaspremaDataGridViewTextBoxColumn.HeaderText = "Minimalna_strucna_sprema";
            this.minimalnastrucnaspremaDataGridViewTextBoxColumn.Name = "minimalnastrucnaspremaDataGridViewTextBoxColumn";
            this.minimalnastrucnaspremaDataGridViewTextBoxColumn.Width = 160;
            // 
            // brojcasovaDataGridViewTextBoxColumn
            // 
            this.brojcasovaDataGridViewTextBoxColumn.DataPropertyName = "Broj_casova";
            this.brojcasovaDataGridViewTextBoxColumn.HeaderText = "Broj_casova";
            this.brojcasovaDataGridViewTextBoxColumn.Name = "brojcasovaDataGridViewTextBoxColumn";
            this.brojcasovaDataGridViewTextBoxColumn.Width = 91;
            // 
            // normacasovaDataGridViewTextBoxColumn
            // 
            this.normacasovaDataGridViewTextBoxColumn.DataPropertyName = "Norma_casova";
            this.normacasovaDataGridViewTextBoxColumn.HeaderText = "Norma_casova";
            this.normacasovaDataGridViewTextBoxColumn.Name = "normacasovaDataGridViewTextBoxColumn";
            this.normacasovaDataGridViewTextBoxColumn.Width = 104;
            // 
            // procenatangazovanjaDataGridViewTextBoxColumn
            // 
            this.procenatangazovanjaDataGridViewTextBoxColumn.DataPropertyName = "Procenat_angazovanja";
            this.procenatangazovanjaDataGridViewTextBoxColumn.HeaderText = "Procenat_angazovanja";
            this.procenatangazovanjaDataGridViewTextBoxColumn.Name = "procenatangazovanjaDataGridViewTextBoxColumn";
            this.procenatangazovanjaDataGridViewTextBoxColumn.Width = 142;
            // 
            // podaciBindingSource3
            // 
            this.podaciBindingSource3.DataMember = "Podaci";
            this.podaciBindingSource3.DataSource = this.normaBazaDataSet4;
            // 
            // normaBazaDataSet4
            // 
            this.normaBazaDataSet4.DataSetName = "NormaBazaDataSet4";
            this.normaBazaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // podaciBindingSource2
            // 
            this.podaciBindingSource2.DataMember = "Podaci";
            this.podaciBindingSource2.DataSource = this.normaBazaDataSet2;
            // 
            // normaBazaDataSet2
            // 
            this.normaBazaDataSet2.DataSetName = "NormaBazaDataSet2";
            this.normaBazaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // podaciTableAdapter2
            // 
            this.podaciTableAdapter2.ClearBeforeFill = true;
            // 
            // podaciTableAdapter3
            // 
            this.podaciTableAdapter3.ClearBeforeFill = true;
            // 
            // btnObrisiOsobu
            // 
            this.btnObrisiOsobu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiOsobu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObrisiOsobu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnObrisiOsobu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnObrisiOsobu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiOsobu.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOsobu.Location = new System.Drawing.Point(13, 211);
            this.btnObrisiOsobu.Name = "btnObrisiOsobu";
            this.btnObrisiOsobu.Size = new System.Drawing.Size(132, 86);
            this.btnObrisiOsobu.TabIndex = 4;
            this.btnObrisiOsobu.Text = "Obriši osobu";
            this.btnObrisiOsobu.UseVisualStyleBackColor = false;
            this.btnObrisiOsobu.Click += new System.EventHandler(this.btnObrisiOsobu_Click);
            // 
            // btnIzmeniOsobu
            // 
            this.btnIzmeniOsobu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmeniOsobu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeniOsobu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzmeniOsobu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIzmeniOsobu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeniOsobu.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniOsobu.Location = new System.Drawing.Point(13, 119);
            this.btnIzmeniOsobu.Name = "btnIzmeniOsobu";
            this.btnIzmeniOsobu.Size = new System.Drawing.Size(132, 86);
            this.btnIzmeniOsobu.TabIndex = 7;
            this.btnIzmeniOsobu.Text = "Izmeni osobu";
            this.btnIzmeniOsobu.UseVisualStyleBackColor = false;
            this.btnIzmeniOsobu.Click += new System.EventHandler(this.btnIzmeniOsobu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(568, 505);
            this.Controls.Add(this.btnIzmeniOsobu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnObrisiOsobu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(584, 425);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izračunavanje norme časova";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBazaDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputstvoToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDodaj;
        private NormaBazaDataSet normaBazaDataSet;
        private System.Windows.Forms.BindingSource podaciBindingSource;
        private NormaBazaDataSetTableAdapters.PodaciTableAdapter podaciTableAdapter;
        private NormaBazaDataSet1 normaBazaDataSet1;
        private System.Windows.Forms.BindingSource podaciBindingSource1;
        private NormaBazaDataSet1TableAdapters.PodaciTableAdapter podaciTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NormaBazaDataSet2 normaBazaDataSet2;
        private System.Windows.Forms.BindingSource podaciBindingSource2;
        private NormaBazaDataSet2TableAdapters.PodaciTableAdapter podaciTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimalnastrucnaspremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojcasovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normacasovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatangazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem exportUExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem učitajBazuToolStripMenuItem;
        private NormaBazaDataSet4 normaBazaDataSet4;
        private System.Windows.Forms.BindingSource podaciBindingSource3;
        private NormaBazaDataSet4TableAdapters.PodaciTableAdapter podaciTableAdapter3;
        private System.Windows.Forms.ToolStripMenuItem obrišiOsobuToolStripMenuItem;
        private System.Windows.Forms.Button btnObrisiOsobu;
        private System.Windows.Forms.Button btnIzmeniOsobu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}