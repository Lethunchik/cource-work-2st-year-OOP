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
    public partial class Form_Red_t : Form
    {
        public Form_Red_t()
        {
            InitializeComponent();
            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
            {
                if (СУМ.indexOFt == Convert.ToInt32(СУМ.cl_tovar_s[i].ID))
                {
                    textBox1.AppendText(СУМ.cl_tovar_s[i].Name);
                    textBox2.AppendText(СУМ.cl_tovar_s[i].Kol_vo);
                    textBox3.AppendText(СУМ.cl_tovar_s[i].Date_izg);
                    textBox4.AppendText(СУМ.cl_tovar_s[i].Date_godn);
                    textBox4.AppendText(СУМ.cl_tovar_s[i].Price);
                    textBox4.AppendText(СУМ.cl_tovar_s[i].Proizvod);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
            {
                if (СУМ.indexOFt == Convert.ToInt32(СУМ.cl_tovar_s[i].ID))
                {
                    СУМ.cl_tovar_s[i].Name = textBox1.Text;
                    СУМ.cl_tovar_s[i].Kol_vo = textBox2.Text;
                    СУМ.cl_tovar_s[i].Date_izg = textBox3.Text;
                    СУМ.cl_tovar_s[i].Date_godn = textBox4.Text;
                    СУМ.cl_tovar_s[i].Price = textBox5.Text;
                    СУМ.cl_tovar_s[i].Proizvod = textBox6.Text;
                }
            }
            UpravlenieT FUpravlenieT = new UpravlenieT();
            FUpravlenieT.Show();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            UpravlenieT FUpravlenieT = new UpravlenieT();
            FUpravlenieT.Show();
            this.Close();
        }
    }
}
