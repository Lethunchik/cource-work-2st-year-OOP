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
    public partial class Form_Add_m : Form
    {
        public Form_Add_m()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            UpravlenieM FUpravlenieM = new UpravlenieM();
            FUpravlenieM.Show();
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int max = 1;
            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
            {
                if (Convert.ToInt32(СУМ.cl_magazin_s[i].ID) > max)
                {
                    max = Convert.ToInt32(СУМ.cl_magazin_s[i].ID);
                }
            }
            max++;
            СУМ.cl_magazin_s.Add(new cl_magazin
            {
                ID = max.ToString(),
                Name = textBox1.Text,
                Napravlennost = textBox2.Text,
                Adress = textBox3.Text,
                Vr_rab = textBox4.Text,
                Gorod = СУМ.indexOFg.ToString()
            });
            UpravlenieM FUpravlenieM = new UpravlenieM();
            FUpravlenieM.Show();
            this.Close();
        }
    }
}
