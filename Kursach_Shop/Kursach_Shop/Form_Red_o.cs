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
    public partial class Form_Red_o : Form
    {
        public Form_Red_o()
        {
            InitializeComponent();
            for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)
            {
                if (СУМ.indexOFo == Convert.ToInt32(СУМ.cl_otdel_s[i].ID))
                {
                    textBox1.AppendText(СУМ.cl_otdel_s[i].Number);
                    textBox2.AppendText(СУМ.cl_otdel_s[i].Tip_tovarov);
                    textBox3.AppendText(СУМ.cl_otdel_s[i].Otv_sotr);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)
            {
                if (СУМ.indexOFo == Convert.ToInt32(СУМ.cl_otdel_s[i].ID))
                {
                    СУМ.cl_otdel_s[i].Number = textBox1.Text;
                    СУМ.cl_otdel_s[i].Tip_tovarov = textBox2.Text;
                    СУМ.cl_otdel_s[i].Otv_sotr = textBox3.Text;
                }
            }
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
