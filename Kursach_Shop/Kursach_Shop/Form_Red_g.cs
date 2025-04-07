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
    public partial class Form_Red_g : Form
    {
        public Form_Red_g()
        {
            InitializeComponent();

            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)
            {
                if (СУМ.indexOFg == Convert.ToInt32(СУМ.cl_sity_s[i].ID))
                {
                    textBox_Name.AppendText(СУМ.cl_sity_s[i].Name);
                    textBox_oblast.AppendText(СУМ.cl_sity_s[i].Oblast);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)
            {
                if (СУМ.indexOFg == Convert.ToInt32(СУМ.cl_sity_s[i].ID))
                {
                    СУМ.cl_sity_s[i].Name = textBox_Name.Text;
                    СУМ.cl_sity_s[i].Oblast = textBox_oblast.Text;
                }
            }
            Upravlenie FUpravlenie = new Upravlenie();
            FUpravlenie.Show();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Upravlenie FUpravlenie = new Upravlenie();
            FUpravlenie.Show();
            this.Close();
        }
    }
}
