using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_Shop
{
    public partial class Form_Red_m : Form
    {
        public Form_Red_m()
        {
            InitializeComponent();
            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
            {
                if (СУМ.indexOFm == Convert.ToInt32(СУМ.cl_magazin_s[i].ID))
                {
                    textBox1.AppendText(СУМ.cl_magazin_s[i].Name);
                    textBox2.AppendText(СУМ.cl_magazin_s[i].Napravlennost);
                    textBox3.AppendText(СУМ.cl_magazin_s[i].Adress);
                    textBox4.AppendText(СУМ.cl_magazin_s[i].Vr_rab);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
            {
                if (СУМ.indexOFm == Convert.ToInt32(СУМ.cl_magazin_s[i].ID))
                {
                    СУМ.cl_magazin_s[i].Name = textBox1.Text;
                    СУМ.cl_magazin_s[i].Napravlennost = textBox2.Text;
                    СУМ.cl_magazin_s[i].Adress = textBox3.Text;
                    СУМ.cl_magazin_s[i].Vr_rab = textBox4.Text;
                }
            }
            UpravlenieM FUpravlenieM = new UpravlenieM();
            FUpravlenieM.Show();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            UpravlenieM FUpravlenieM = new UpravlenieM();
            FUpravlenieM.Show();
            this.Close();
        }
    }
}
