using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDoktorPanel : Form
    {
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            cmbBrans = new ComboBox();
            mskTC = new MaskedTextBox();
            mskSifre = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 76);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 2;
            label3.Text = "Branş:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 165);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 3;
            label4.Text = "TC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 209);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(117, 26);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 36);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(117, 68);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 36);
            txtSoyad.TabIndex = 6;
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(117, 115);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(125, 36);
            cmbBrans.TabIndex = 7;

            // 
            // mskTC
            // 
            mskTC.Location = new Point(117, 157);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(125, 36);
            mskTC.TabIndex = 8;
            mskTC.ValidatingType = typeof(int);
            // 
            // mskSifre
            // 
            mskSifre.Location = new Point(117, 201);
            mskSifre.Name = "mskSifre";
            mskSifre.Size = new Size(125, 36);
            mskSifre.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(117, 243);
            button1.Name = "button1";
            button1.Size = new Size(64, 34);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(187, 243);
            button2.Name = "button2";
            button2.Size = new Size(55, 34);
            button2.TabIndex = 11;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(117, 283);
            button3.Name = "button3";
            button3.Size = new Size(125, 37);
            button3.TabIndex = 12;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 294);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmDoktorPanel
            // 
            ClientSize = new Size(1068, 366);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mskSifre);
            Controls.Add(mskTC);
            Controls.Add(cmbBrans);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "FrmDoktorPanel";
            Text = "FrmDoktorPaneli";
            Load += FrmDoktorPaneli_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private ComboBox cmbBrans;
        private MaskedTextBox mskTC;
        private MaskedTextBox mskSifre;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;


        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //Doktorları listeye aktarma 
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Branşı combobox'a aktarma 
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Table_Doktorlar SET DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3, DoktorSifre=@d5 WHERE DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", mskSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", mskSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Table_Doktorlar where DoktorTC=@d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }



    }
}