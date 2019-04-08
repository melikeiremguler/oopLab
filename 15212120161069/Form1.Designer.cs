namespace _15212120161069
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clbLanguage = new System.Windows.Forms.CheckedListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.grbImage = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.timerprogres = new System.Windows.Forms.Timer(this.components);
            this.progressBarexport = new System.Windows.Forms.ProgressBar();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxparttime = new System.Windows.Forms.ComboBox();
            this.clbDegree = new System.Windows.Forms.CheckedListBox();
            this.clbFamily = new System.Windows.Forms.CheckedListBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.cmbManagment = new System.Windows.Forms.ComboBox();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.grbImage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbLanguage
            // 
            this.clbLanguage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clbLanguage.CheckOnClick = true;
            this.clbLanguage.FormattingEnabled = true;
            this.clbLanguage.Items.AddRange(new object[] {
            "Belgelendirilmiş İngilizce bilgisi",
            "İngilizce eğitim veren okul mezuniyeti",
            "Belgelendirilmiş diğer yabancı dil bilgisi (her dil için)"});
            this.clbLanguage.Location = new System.Drawing.Point(12, 166);
            this.clbLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbLanguage.Name = "clbLanguage";
            this.clbLanguage.Size = new System.Drawing.Size(237, 123);
            this.clbLanguage.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSil.Location = new System.Drawing.Point(27, 46);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Delete";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(27, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToOrderColumns = true;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStaff.GridColor = System.Drawing.Color.Teal;
            this.dgvStaff.Location = new System.Drawing.Point(0, 28);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(1291, 329);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvStaff_EditingControlShowing);
            this.dgvStaff.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_RowHeaderMouseDoubleClick);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbFoto.Location = new System.Drawing.Point(4, 19);
            this.pcbFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(161, 107);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFoto.TabIndex = 15;
            this.pcbFoto.TabStop = false;
            // 
            // grbImage
            // 
            this.grbImage.Controls.Add(this.pcbFoto);
            this.grbImage.Location = new System.Drawing.Point(655, 2);
            this.grbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbImage.Name = "grbImage";
            this.grbImage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbImage.Size = new System.Drawing.Size(169, 130);
            this.grbImage.TabIndex = 17;
            this.grbImage.TabStop = false;
            this.grbImage.Text = "Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.sAVEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1291, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1});
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.aÇToolStripMenuItem.Text = "OPEN";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(110, 26);
            this.cSVToolStripMenuItem1.Text = "CSV";
            this.cSVToolStripMenuItem1.Click += new System.EventHandler(this.cSVToolStripMenuItem1_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.tSVToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // tSVToolStripMenuItem
            // 
            this.tSVToolStripMenuItem.Name = "tSVToolStripMenuItem";
            this.tSVToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tSVToolStripMenuItem.Text = "TSV";
            this.tSVToolStripMenuItem.Click += new System.EventHandler(this.tSVToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Location = new System.Drawing.Point(27, 92);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // timerprogres
            // 
            this.timerprogres.Tick += new System.EventHandler(this.timerprogres_Tick);
            // 
            // progressBarexport
            // 
            this.progressBarexport.Location = new System.Drawing.Point(129, 5);
            this.progressBarexport.Name = "progressBarexport";
            this.progressBarexport.Size = new System.Drawing.Size(408, 23);
            this.progressBarexport.TabIndex = 24;
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // cbxparttime
            // 
            this.cbxparttime.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbxparttime.FormattingEnabled = true;
            this.cbxparttime.Items.AddRange(new object[] {
            "Part Time",
            "Full Time"});
            this.cbxparttime.Location = new System.Drawing.Point(655, 265);
            this.cbxparttime.Name = "cbxparttime";
            this.cbxparttime.Size = new System.Drawing.Size(160, 24);
            this.cbxparttime.TabIndex = 25;
            // 
            // clbDegree
            // 
            this.clbDegree.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clbDegree.CheckOnClick = true;
            this.clbDegree.FormattingEnabled = true;
            this.clbDegree.Items.AddRange(new object[] {
            "Meslek alanı ile ilgili yüksek lisans",
            "Meslek alanı ile ilgili doktora",
            "Meslek alanı ile ilgili doçentlik",
            "Meslek alanı ile ilgili olmayan yüksek lisans",
            "Meslek alanı ile ilgili olmayan doktora/doçentlik"});
            this.clbDegree.Location = new System.Drawing.Point(281, 163);
            this.clbDegree.Margin = new System.Windows.Forms.Padding(4);
            this.clbDegree.Name = "clbDegree";
            this.clbDegree.Size = new System.Drawing.Size(353, 123);
            this.clbDegree.TabIndex = 2;
            // 
            // clbFamily
            // 
            this.clbFamily.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clbFamily.CheckOnClick = true;
            this.clbFamily.FormattingEnabled = true;
            this.clbFamily.Items.AddRange(new object[] {
            "Evli ve eşi çalışmıyor",
            "0-6 yaş arası çocuk",
            "7-18 yaş arası çocuk",
            "18 yaş üstü çocuk(Üniversite lisans / ön lisans öğrencisi olmak koşuluyla)"});
            this.clbFamily.Location = new System.Drawing.Point(281, 18);
            this.clbFamily.Margin = new System.Windows.Forms.Padding(4);
            this.clbFamily.Name = "clbFamily";
            this.clbFamily.Size = new System.Drawing.Size(353, 106);
            this.clbFamily.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(86, 18);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(163, 22);
            this.txbName.TabIndex = 5;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(86, 50);
            this.txbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(163, 22);
            this.txbSurname.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(18, 22);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(18, 50);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(65, 17);
            this.lbSurname.TabIndex = 8;
            this.lbSurname.Text = "Surname";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(86, 82);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(163, 22);
            this.txbAddress.TabIndex = 9;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(18, 82);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 17);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Address";
            // 
            // cmbManagment
            // 
            this.cmbManagment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbManagment.FormattingEnabled = true;
            this.cmbManagment.Items.AddRange(new object[] {
            "Takım Lideri / Grup Yöneticisi / Teknik Yönetici / Yazılım Mimarı",
            "Proje Yöneticisi ",
            "Direktör / Projeler Yöneticisi",
            "CTO / Genel Müdür",
            "Bilgi İşlem Sorumlusu / Müdürü(Bilgi İşlem biriminde en çok 5 bilişim personeli v" +
                "arsa)",
            "Bilgi İşlem Sorumlusu / Müdürü(Bilgi İşlem biriminde 5\'ten çok bilişim personeli " +
                "varsa)"});
            this.cmbManagment.Location = new System.Drawing.Point(655, 170);
            this.cmbManagment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbManagment.Name = "cmbManagment";
            this.cmbManagment.Size = new System.Drawing.Size(160, 24);
            this.cmbManagment.TabIndex = 11;
            // 
            // cmbExperience
            // 
            this.cmbExperience.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Items.AddRange(new object[] {
            "0-2",
            "2-4",
            "5-9",
            "10-14",
            "15-20",
            "20 yıl üstü "});
            this.cmbExperience.Location = new System.Drawing.Point(655, 234);
            this.cmbExperience.Margin = new System.Windows.Forms.Padding(4);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(160, 24);
            this.cmbExperience.TabIndex = 12;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "TR10: İstanbul ",
            "TR51: Ankara ",
            "TR31: İzmir",
            "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova",
            "TR21: Edirne, Kırklareli, Tekirdağ",
            "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
            "TR41: Bursa, Eskişehir, Bilecik ",
            "TR32: Aydın, Denizli, Muğla",
            "TR62: Adana, Mersin",
            "TR22: Balıkesir, Çanakkale",
            "TR61: Antalya, Isparta, Burdur",
            "Diğer İller"});
            this.cmbCity.Location = new System.Drawing.Point(655, 202);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(160, 24);
            this.cmbCity.TabIndex = 13;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnYukle.Location = new System.Drawing.Point(832, 100);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(4);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(100, 28);
            this.btnYukle.TabIndex = 16;
            this.btnYukle.Text = "Dowload";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.cbxparttime);
            this.groupBox1.Controls.Add(this.grbImage);
            this.groupBox1.Controls.Add(this.btnYukle);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.cmbExperience);
            this.groupBox1.Controls.Add(this.cmbManagment);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.txbAddress);
            this.groupBox1.Controls.Add(this.lbSurname);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.txbSurname);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.clbFamily);
            this.groupBox1.Controls.Add(this.clbDegree);
            this.groupBox1.Controls.Add(this.clbLanguage);
            this.groupBox1.Location = new System.Drawing.Point(4, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 310);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Location = new System.Drawing.Point(1028, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 128);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1291, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarexport);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.grbImage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbLanguage;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.GroupBox grbImage;
        public System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Timer timerprogres;
        private System.Windows.Forms.ProgressBar progressBarexport;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxparttime;
        private System.Windows.Forms.CheckedListBox clbDegree;
        private System.Windows.Forms.CheckedListBox clbFamily;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.ComboBox cmbManagment;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

