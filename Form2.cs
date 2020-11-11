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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Label[] lbldizi = new Label[14];
            for (int i = 0; i < lbldizi.Length; i++)
            {
                lbldizi[i] = new Label(); //dizinin her i. elemanında yeni bir label aç.
                lbldizi[i].Text = "Label" +  i.ToString(); //adlandırma.
                this.Controls.Add(lbldizi[i]);
                lbldizi[i].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lbldizi[i].Top = i * 30;
                lbldizi[i].Left = 100;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
