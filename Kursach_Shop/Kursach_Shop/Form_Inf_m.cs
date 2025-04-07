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
    public partial class Form_Inf_m : Form
    {
        public Form_Inf_m()
        {
            InitializeComponent();

            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)
            {
                if (СУМ.indexOFg == Convert.ToInt32(СУМ.cl_sity_s[i].ID))
                {
                    label_g1.Text = СУМ.cl_sity_s[i].Name;
                    label_g2.Text = СУМ.cl_sity_s[i].Oblast;
                }
            }

            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
            {
                if (СУМ.indexOFm == Convert.ToInt32(СУМ.cl_magazin_s[i].ID))
                {
                    label_m1.Text = СУМ.cl_magazin_s[i].Name;
                    label_m2.Text = СУМ.cl_magazin_s[i].Napravlennost;
                    label_m3.Text = СУМ.cl_magazin_s[i].Adress;
                    label_m4.Text = СУМ.cl_magazin_s[i].Vr_rab;
                }
            }
        }
    }
}
