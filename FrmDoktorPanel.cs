using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(117, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 36);
            comboBox1.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(117, 157);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 36);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(117, 201);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 36);
            maskedTextBox2.TabIndex = 9;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(331, 294);
            dataGridView1.TabIndex = 13;
            // 
            // FrmDoktorPaneli
            // 
            ClientSize = new Size(644, 366);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "FrmDoktorPaneli";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}
