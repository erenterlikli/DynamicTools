using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikAraclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kodlarla label oluşturma.
            Label lbl = new Label();
            Point lblkonum = new Point(320, 50); //labelın konum değerleri.
            lbl.Location = lblkonum; //label, konumu buradan alacak.
            lbl.Name = "label1";
            lbl.Text = "Hoşgeldiniz";
            lbl.ForeColor = Color.Green;
            lbl.Size = new System.Drawing.Size(300, 300);
            lbl.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            this.Controls.Add(lbl); //Kodlanan labelı ekranda göstermek.


            //Kodlarla textBox oluşturma.
            TextBox txt = new TextBox();
            Point txtkonum = new Point(50, 100);
            txt.Location = txtkonum;
            txt.Name = "txtBox1";
            txt.BackColor = Color.Gray;
            txt.ForeColor = Color.Blue;
            txt.Size = new System.Drawing.Size(300, 300);
            groupBox1.Controls.Add(txt);


            //Kodlarla buton oluşturma.
            Button btn = new Button();
            Point btnkonum = new Point(30, 180);
            btn.Location = btnkonum;
            btn.Name = "Btn1";
            btn.Text = "Kaydet";
            btn.BackColor = Color.HotPink;
            btn.Size = new System.Drawing.Size(150, 30);
            groupBox1.Controls.Add(btn);


            //Kodlarla richTextBox oluşturma
            RichTextBox rtb = new RichTextBox();
            Point rtbkonum = new Point(100, 100);
            rtb.Location = rtbkonum;
            rtb.Size = new System.Drawing.Size(100, 100);
            this.Controls.Add(rtb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            
        }
    }
}
