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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clbLanguage = new System.Windows.Forms.CheckedListBox();
            this.clbDegree = new System.Windows.Forms.CheckedListBox();
            this.clbFamily = new System.Windows.Forms.CheckedListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.cmbManagment = new System.Windows.Forms.ComboBox();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.grbImage = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.grbImage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.clbLanguage.Location = new System.Drawing.Point(12, 414);
            this.clbLanguage.Name = "clbLanguage";
            this.clbLanguage.Size = new System.Drawing.Size(202, 64);
            this.clbLanguage.TabIndex = 1;
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
            this.clbDegree.Location = new System.Drawing.Point(12, 298);
            this.clbDegree.Name = "clbDegree";
            this.clbDegree.Size = new System.Drawing.Size(257, 94);
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
            this.clbFamily.Location = new System.Drawing.Point(284, 298);
            this.clbFamily.Name = "clbFamily";
            this.clbFamily.Size = new System.Drawing.Size(277, 94);
            this.clbFamily.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSil.Location = new System.Drawing.Point(700, 412);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Delete";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(632, 320);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(123, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(632, 346);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(123, 20);
            this.txbSurname.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(587, 323);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(581, 346);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 8;
            this.lbSurname.Text = "Surname";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(632, 372);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(123, 20);
            this.txbAddress.TabIndex = 9;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(581, 372);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
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
            this.cmbManagment.Location = new System.Drawing.Point(398, 414);
            this.cmbManagment.Name = "cmbManagment";
            this.cmbManagment.Size = new System.Drawing.Size(121, 21);
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
            this.cmbExperience.Location = new System.Drawing.Point(252, 414);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(121, 21);
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
            this.cmbCity.Location = new System.Drawing.Point(398, 457);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(590, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStaff.GridColor = System.Drawing.Color.Teal;
            this.dgvStaff.Location = new System.Drawing.Point(0, 24);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(968, 267);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvStaff_EditingControlShowing);
            this.dgvStaff.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_RowHeaderMouseDoubleClick);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbFoto.Location = new System.Drawing.Point(3, 16);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(121, 87);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFoto.TabIndex = 15;
            this.pcbFoto.TabStop = false;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnYukle.Location = new System.Drawing.Point(840, 412);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(75, 23);
            this.btnYukle.TabIndex = 16;
            this.btnYukle.Text = "Dowload";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // grbImage
            // 
            this.grbImage.Controls.Add(this.pcbFoto);
            this.grbImage.Location = new System.Drawing.Point(810, 297);
            this.grbImage.Name = "grbImage";
            this.grbImage.Size = new System.Drawing.Size(127, 106);
            this.grbImage.TabIndex = 17;
            this.grbImage.TabStop = false;
            this.grbImage.Text = "Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.sAVEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSVToolStripMenuItem1,
            this.cSVToolStripMenuItem1});
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aÇToolStripMenuItem.Text = "OPEN";
            // 
            // tSVToolStripMenuItem1
            // 
            this.tSVToolStripMenuItem1.Name = "tSVToolStripMenuItem1";
            this.tSVToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.tSVToolStripMenuItem1.Text = "TSV";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            this.cSVToolStripMenuItem1.Click += new System.EventHandler(this.cSVToolStripMenuItem1_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.tSVToolStripMenuItem});
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // tSVToolStripMenuItem
            // 
            this.tSVToolStripMenuItem.Name = "tSVToolStripMenuItem";
            this.tSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tSVToolStripMenuItem.Text = "TSV";
            this.tSVToolStripMenuItem.Click += new System.EventHandler(this.tSVToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(590, 457);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(968, 538);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grbImage);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbExperience);
            this.Controls.Add(this.cmbManagment);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.clbFamily);
            this.Controls.Add(this.clbDegree);
            this.Controls.Add(this.clbLanguage);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.menuStrip1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbLanguage;
        private System.Windows.Forms.CheckedListBox clbDegree;
        private System.Windows.Forms.CheckedListBox clbFamily;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.ComboBox cmbManagment;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.GroupBox grbImage;
        public System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

