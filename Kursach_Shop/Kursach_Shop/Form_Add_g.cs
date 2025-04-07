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
    public partial class Form_Add_g : Form
    {
        public Form_Add_g()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Upravlenie FUpravlenie = new Upravlenie();
            FUpravlenie.Show();
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int max = 1;
            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)
            {
                if (Convert.ToInt32(СУМ.cl_sity_s[i].ID) > max) {
                    max = Convert.ToInt32(СУМ.cl_sity_s[i].ID);
                }
            }
            max++;
            СУМ.cl_sity_s.Add(new cl_city
            {
                
                ID = max.ToString(),
                Name = textBox_Name.Text,
                Oblast = textBox_oblast.Text
            });
            Upravlenie FUpravlenie = new Upravlenie();
            FUpravlenie.Show();
            this.Close();
        }
    }
}
