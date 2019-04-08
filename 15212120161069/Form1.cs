using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using CsvHelper;
using System.Drawing.Imaging;
using Newtonsoft.Json;

namespace _15212120161069
{
    public partial class Form1 : Form
    {
        private string mstrClsTitle = "frmRexcel";
        public Form1()
        {
            InitializeComponent();
           
        }

        
        int id = 1;
        DataTable dt = new DataTable();
        
        private void Form1_Load(object sender, EventArgs e)
        {

          
            dt.Columns.AddRange(new DataColumn[13] { new DataColumn("Image", typeof(Image)), new DataColumn("ID", typeof(Int32)), new DataColumn("Name", typeof(String)), new DataColumn("Surname", typeof(String)), new DataColumn("Address", typeof(String)), new DataColumn("BMO", typeof(double)), new DataColumn("Salary", typeof(double)), new DataColumn("City", typeof(String)), new DataColumn("Experience", typeof(String)), new DataColumn("Management Position", typeof(String)) , new DataColumn("Academic Degree", typeof(String)) , new DataColumn("Family Status", typeof(String)), new DataColumn("Foreign Language", typeof(String)) });

            dgvStaff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Directory.CreateDirectory(@"C:\Users\İrem Güler\Desktop\oopLab\15212120161069\bin\Debug\ImageStaff");

            cSVToolStripMenuItem1_Click( sender,  e);

            if (dgvStaff.RowCount!= 0)
            {
                id = (int)dgvStaff.Rows[dgvStaff.RowCount - 1].Cells[1].Value + 1;
            }



        }


        private void btnSil_Click(object sender, EventArgs e)
        {

            foreach(DataGridViewRow row in dgvStaff.Rows)
            {

                if (row.Selected)
                {
                    string filename = Application.StartupPath + @"\ImageStaff\" + row.Cells[1].Value + ".jpg";

                    File.Delete(filename);
                    dgvStaff.Rows.Remove(row);
                }


            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
          
           
            dt.Rows.Add(pcbFoto.Image,id, txbName.Text, txbSurname.Text, txbAddress.Text, 4500,4500, cmbCity.Text, cmbExperience.Text, cmbManagment.Text);


            string filename = Application.StartupPath + @"\ImageStaff\" + id + ".jpg";

            using (FileStream fstream = new FileStream(filename, FileMode.Create))
            {
                pcbFoto.Image.Save(fstream, ImageFormat.Jpeg);
                fstream.Close();
            }
            id++;
            dgvStaff.DataSource = dt;

            dgvStaff.Rows[dgvStaff.RowCount-1].Cells[6].Value = bmo_calculate();
            checklist_checeked_find(clbDegree.Items.Count, 10, clbDegree,false);
            checklist_checeked_find(clbFamily.Items.Count, 11, clbFamily,false);
            checklist_checeked_find(clbLanguage.Items.Count, 12, clbLanguage,false);

            
           
        }
       
   
        private void dgvStaff_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox TB = (TextBox)e.Control;
            TB.Multiline = true;
        }

       
        private void btnYukle_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = System.Drawing.Image.FromFile(f.FileName);
                pcbFoto.Image = File;
                pcbFoto.Image = resizeImage(pcbFoto.Image, new Size(120, 120));
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void dgvStaff_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 staffdetail = new Form2();

            staffdetail.pcbImage.Image = (Image)dgvStaff.CurrentRow.Cells[0].Value;
            staffdetail.txbid.Text = this.dgvStaff.CurrentRow.Cells[1].Value.ToString();
            staffdetail.txbname.Text = this.dgvStaff.CurrentRow.Cells[2].Value.ToString();
            staffdetail.txbsurname.Text = this.dgvStaff.CurrentRow.Cells[3].Value.ToString();
            staffdetail.txbaddress.Text = this.dgvStaff.CurrentRow.Cells[4].Value.ToString();
            staffdetail.txbbmo.Text = this.dgvStaff.CurrentRow.Cells[5].Value.ToString();
            staffdetail.txbsalary.Text = this.dgvStaff.CurrentRow.Cells[6].Value.ToString();
            staffdetail.txbcity.Text = this.dgvStaff.CurrentRow.Cells[7].Value.ToString();
            staffdetail.txbexperince.Text = this.dgvStaff.CurrentRow.Cells[8].Value.ToString();
            staffdetail.txbmanagment.Text = this.dgvStaff.CurrentRow.Cells[9].Value.ToString();
            staffdetail.txbdegree.Text = this.dgvStaff.CurrentRow.Cells[10].Value.ToString();
            staffdetail.txbfamily.Text = this.dgvStaff.CurrentRow.Cells[11].Value.ToString();
            staffdetail.txblanguage.Text = this.dgvStaff.CurrentRow.Cells[12].Value.ToString();
            staffdetail.Show();
        }
        private void checklist_checeked_find(int count, int cell, CheckedListBox listBox, bool update)
        {
            if (update)
            {
                dgvStaff.CurrentRow.Cells[cell].Value = "";
                for (int i = 0; i < count; i++)
                {
                    if (listBox.GetItemChecked(i) == true)
                    {
                        dgvStaff.CurrentRow.Cells[cell].Value += listBox.Items[i] + Environment.NewLine;

                    }
                }
            }
            else
            {

                for (int i = 0; i < count; i++)
                {
                    if (listBox.GetItemChecked(i) == true)
                    {
                        dgvStaff.Rows[dgvStaff.RowCount - 1].Cells[cell].Value += listBox.Items[i] + Environment.NewLine;

                    }
                }
            }
        }
        public double bmo_calculate()
        {
            double sum=0;
            for(int i=0;i<clbDegree.Items.Count;i++)
            {
                if (clbDegree.GetItemChecked(i) == true)
                {
                    if(clbDegree.Items[i].ToString()== "Meslek alanı ile ilgili yüksek lisans")
                    {
                        sum+=0.10;
                    }
                    else if (clbDegree.Items[i].ToString() == "Meslek alanı ile ilgili doktora")
                    {
                        sum += 0.30;
                    }
                    else if (clbDegree.Items[i].ToString() == "Meslek alanı ile ilgili doçentlik")
                    {
                        sum += 0.35;
                    }
                    else if (clbDegree.Items[i].ToString() == "Meslek alanı ile ilgili olmayan yüksek lisans")
                    {
                        sum += 0.05;
                    }
                    else if (clbDegree.Items[i].ToString() == "Meslek alanı ile ilgili olmayan doktora/doçentlik")
                    {
                        sum += 0.15;
                    }
                    else { sum += 0; }

                }

            }
            for (int i = 0; i < clbLanguage.Items.Count; i++)
            {
                if (clbLanguage.GetItemChecked(i) == true)
                {
                    if (clbLanguage.Items[i].ToString() == "Belgelendirilmiş İngilizce bilgisi")
                    {
                        sum += 0.20;
                    }
                    else if (clbLanguage.Items[i].ToString() == "İngilizce eğitim veren okul mezuniyeti")
                    {
                        sum += 0.20;
                    }
                    else if (clbLanguage.Items[i].ToString() == "Belgelendirilmiş diğer yabancı dil bilgisi (her dil için)")
                    {
                        sum += 0.05;
                    }
                    else { sum += 0; }

                }

            }
            for (int i = 0; i < clbFamily.Items.Count; i++)
            {
                if (clbFamily.GetItemChecked(i) == true)
                {
                    if (clbFamily.Items[i].ToString() == "Evli ve eşi çalışmıyor")
                    {
                        sum += 0.20;
                    }
                    else if (clbFamily.Items[i].ToString() == "0-6 yaş arası çocuk")
                    {
                        sum += 0.20;
                    }
                    else if (clbFamily.Items[i].ToString() == "7-18 yaş arası çocuk")
                    {
                        sum += 0.30;
                    }
                    else if (clbFamily.Items[i].ToString() == "18 yaş üstü çocuk(Üniversite lisans / ön lisans öğrencisi olmak koşuluyla)")
                    {
                        sum += 0.40;
                    }
                    else { sum += 0; }
                }

            }
            if (cmbCity.SelectedIndex == 0) { sum += 0.15; }
            else if (cmbCity.SelectedIndex == 1) { sum += 0.10; }
            else if (cmbCity.SelectedIndex == 2) { sum += 0.10; }
            else if (cmbCity.SelectedIndex == 3) { sum += 0.05; }
            else if (cmbCity.SelectedIndex == 4) { sum += 0.05; }
            else if (cmbCity.SelectedIndex > 4&&cmbCity.SelectedIndex<=10) { sum += 0.05; }
            else { sum += 0; }

            if (cmbExperience.SelectedIndex == 0) { sum += 0; }
            else if (cmbExperience.SelectedIndex == 1) { sum += 0.60; }
            else if (cmbExperience.SelectedIndex == 2) { sum += 1.00; }
            else if (cmbExperience.SelectedIndex == 3) { sum += 1.20; }
            else if (cmbExperience.SelectedIndex == 4) { sum += 1.35; }
            else if (cmbExperience.SelectedIndex == 5) { sum += 1.50; }
            else { sum += 0; }

            if (cmbManagment.SelectedIndex == 0) { sum += 0.20; }
            else if (cmbManagment.SelectedIndex == 1) { sum += 0.20; }
            else if (cmbManagment.SelectedIndex == 2) { sum += 0.30; }
            else if (cmbManagment.SelectedIndex == 0) { sum += 0.40; }
            else { sum += 0; }

            if (cbxparttime.SelectedIndex == 0) { return ((sum + 1) * 4500) / 2; }
            else { return ((sum + 1) * 4500); }
           
        }

       

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarexport.Value = 0;
            timerprogres.Enabled = true;

            string temp;
         
        
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "staff.csv";
            saveFileDialog.Filter = "CSV File | *.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());

                writer.Write("image,id,name,surname,address,bmo,salary,city,experience,managmentPosition,academicDegree,familyStatus,foreignLanguage\n");

                
                for (int i = 0; i < dgvStaff.RowCount; i++)
                {
                    for (int j = 0; j < dgvStaff.ColumnCount; j++)
                    {
                        temp = dgvStaff.Rows[i].Cells[j].Value.ToString();

                        temp = temp.Replace("\r\n", ";");


                        writer.Write(temp);
                        if (j < dgvStaff.ColumnCount - 1)
                        {
                            writer.Write(",");
                            timerprogres_Tick(sender, e);
                        }
                        else
                        {
                            writer.Write("\n");
                            timerprogres_Tick(sender, e);
                        }

                    }
                   
                }
                writer.Dispose();
                writer.Close();

            }
            progressBarexport.Value = 100;
        }

        private void tSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarexport.Value = 0;
            timerprogres.Enabled = true;

            string temp;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "staff.csv";
            saveFileDialog.Filter = "CSV File | *.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());

                writer.Write("image,id,name,surname,address,bmo,salary,city,experience,managment position,academic degree,family status,foreign language\n");

                for (int i = 0; i < dgvStaff.RowCount; i++)
                {
                    for (int j = 0; j < dgvStaff.ColumnCount; j++)
                    {
                        temp = dgvStaff.Rows[i].Cells[j].Value.ToString();

                        temp = temp.Replace("\r\n", ";");


                        writer.Write(temp);
                        if (j < dgvStaff.ColumnCount - 1)
                        {
                            writer.Write("\t");
                            timerprogres_Tick(sender, e);
                        }
                        else
                        {
                            writer.Write("\n");
                            timerprogres_Tick(sender, e);
                        }

                    }
                }
                writer.Dispose();   
                writer.Close();
            }
            progressBarexport.Value = 100;
        }

        private void cSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            progressBarexport.Value = 0;
            timerprogres.Enabled = true;

            string filename;
            General general = new General();
            dt = general.Loadcsvfile(Application.StartupPath + "/staff.csv");

           dgvStaff.Rows.Clear();
            dgvStaff.DataSource = dt;


            string temp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                filename = Application.StartupPath + @"\ImageStaff\" + (int)dgvStaff.Rows[i].Cells[1].Value + ".jpg";


                Image image;
                using (var bmpTemp = new Bitmap(filename))
                {
                    image = new Bitmap(bmpTemp);
                }

                dgvStaff.Rows[i].Cells[0].Value = image;


                temp = dgvStaff.Rows[i].Cells[10].Value.ToString();
                temp = temp.Replace(";", "\r\n");
                dgvStaff.Rows[i].Cells[10].Value = temp;

                temp = dgvStaff.Rows[i].Cells[11].Value.ToString();
                temp = temp.Replace(";", "\r\n");
                dgvStaff.Rows[i].Cells[11].Value = temp;

                temp = dgvStaff.Rows[i].Cells[12].Value.ToString();
                temp = temp.Replace(";", "\r\n");
                dgvStaff.Rows[i].Cells[12].Value = temp;
                timerprogres_Tick(sender, e);
            }


            progressBarexport.Value = 100;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int geciciid = (int)dgvStaff.CurrentRow.Cells[1].Value;
            Image gecici = (Image)dgvStaff.CurrentRow.Cells[0].Value;
            checklist_checeked_find(clbDegree.Items.Count, 10, clbDegree, true);
            checklist_checeked_find(clbFamily.Items.Count, 11, clbFamily, true);
            checklist_checeked_find(clbLanguage.Items.Count, 12, clbLanguage, true);
            double salary = bmo_calculate();
            dgvStaff.CurrentRow.SetValues(gecici, geciciid, txbName.Text, txbSurname.Text, txbAddress.Text, 4500, salary, cmbCity.Text, cmbExperience.Text, cmbManagment.Text);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            {


                switch (MessageBox.Show(this,
                                    "Are you sure you want to close the Application?",
                                    mstrClsTitle + ".frmRexcel_FormClosing",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void timerprogres_Tick(object sender, EventArgs e)
        {
            progressBarexport.Minimum = 0;
            progressBarexport.Maximum = 100;
            progressBarexport.Step = 1;
            timerprogres.Interval = 1000;

            if (progressBarexport.Value == progressBarexport.Maximum)
            {
                timerprogres.Enabled = false;



                return;
            }

            progressBarexport.Value += 10;
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarexport.Value = 0;
            timerprogres.Enabled = true;
            string output = JsonConvert.SerializeObject(dt);
            timerprogres_Tick(sender, e);
            System.IO.File.WriteAllText("jsonklasor.json", output);
            progressBarexport.Value = 100;
        }

        private void tSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}


