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
    public partial class Form_Add_o : Form
    {
        public Form_Add_o()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int max = 1;
            for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)
            {
                if (Convert.ToInt32(СУМ.cl_otdel_s[i].ID) > max)
                {
                    max = Convert.ToInt32(СУМ.cl_otdel_s[i].ID);
                }
            }
            max++;
            СУМ.cl_otdel_s.Add(new cl_otdel
            {
                ID = max.ToString(),
                Number = textBox1.Text,
                Tip_tovarov = textBox2.Text,
                Otv_sotr = textBox3.Text,
                Magazin = СУМ.indexOFm.ToString()
            });
            UpravlenieO FUpravlenieO = new UpravlenieO();
            FUpravlenieO.Show();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            UpravlenieO FUpravlenieO = new UpravlenieO();
            FUpravlenieO.Show();
            this.Close();
        }
    }
}
