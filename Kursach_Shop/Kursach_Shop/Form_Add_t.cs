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
    public partial class Form_Add_t : Form
    {
        public Form_Add_t()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int max = 1;
            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
            {
                if (Convert.ToInt32(СУМ.cl_tovar_s[i].ID) > max)
                {
                    max = Convert.ToInt32(СУМ.cl_tovar_s[i].ID);
                }
            }
            max++;
            СУМ.cl_tovar_s.Add(new cl_tovar
            {
                ID = max.ToString(),
                Name = textBox1.Text,
                Kol_vo = textBox2.Text,
                Date_izg = textBox3.Text,
                Date_godn = textBox4.Text,
                Price = textBox5.Text,
                Proizvod = textBox6.Text,
                Otdel = СУМ.indexOFo.ToString()
            });
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
