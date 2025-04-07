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
    public partial class UpravlenieO : Form
    {
        List<cl_forlist> cl_list1 = new List<cl_forlist> { };

        public UpravlenieO()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)
            {
                if (СУМ.indexOFm == Convert.ToInt32(СУМ.cl_otdel_s[i].Magazin))
                {
                    cl_list1.Add(new cl_forlist
                    {
                        ID = СУМ.cl_otdel_s[i].ID,
                        Name = СУМ.cl_otdel_s[i].Tip_tovarov + ",     " + СУМ.cl_otdel_s[i].Otv_sotr
                    });
                }
            }
            listBox_Upravlenie.DataSource = cl_list1;
            listBox_Upravlenie.DisplayMember = "Name";
            listBox_Upravlenie.ValueMember = "ID";
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                int id = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)
                {
                    if (id == Convert.ToInt32(СУМ.cl_otdel_s[i].ID)) { СУМ.cl_otdel_s.RemoveAt(i); }
                }
                MessageBox.Show("Данные удалены!");
            }
            UpravlenieO FUpravlenieO = new UpravlenieO();
            FUpravlenieO.Show();
            this.Close();
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                СУМ.indexOFo = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                Form_Red_o FRed_o = new Form_Red_o();
                FRed_o.Show();
                this.Close();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_Add_o FAdd_o = new Form_Add_o();
            FAdd_o.Show();
            this.Close();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                СУМ.indexOFo = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                Form_Inf_o FInf_o = new Form_Inf_o();
                FInf_o.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpravlenieM Form_UpravlenieM = new UpravlenieM();
            Form_UpravlenieM.Show();
            this.Close();
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            СУМ.indexOFo = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
            UpravlenieT Form_UpravlenieT = new UpravlenieT();
            Form_UpravlenieT.Show();
            this.Close();
        }
    }
}
