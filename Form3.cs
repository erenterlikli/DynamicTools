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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int butonsayisi = 20;
            int baslaX = 1;
            int baslaY = 1;
            int boyutbol;

            //buton sayısına göre ekrana sığmayanları aşağı satırlara ekletmeye çalışıyoruz.
            boyutbol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(butonsayisi))); 

            for(int i=0;i<=butonsayisi;i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = "Buton" + "-"+ i.ToString();
                btn.Size = new Size(this.Width / boyutbol, this.Height / (boyutbol * 2));
                btn.Location = new Point(baslaX, baslaY);
                btn.Font = new Font(btn.Font.FontFamily.Name, 20);
                this.Controls.Add(btn);
                baslaX = baslaX + btn.Width + 10;

                //alt satıra geçme.
                if(baslaX+this.Width/boyutbol>this.Width) //butonların forma sığmıyorsa?
                {
                    baslaX = 1;
                    baslaY = baslaY + this.Height / (boyutbol * 2) + 10;
                }
                btn.Click+= new EventHandler(dinamikmethod); //butonlara tıklandığı zaman yazılacak olaylar.
            }
        }
        private void dinamikmethod(Object sender,EventArgs e)
        {
            Button dinamikbuton = (sender as Button);
            MessageBox.Show(dinamikbuton.Text + ".İsimli Buton");
        }

       
    }
}
