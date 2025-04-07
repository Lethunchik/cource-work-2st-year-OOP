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
    public partial class UpravlenieM : Form
    {
        List<cl_forlist> cl_list1 = new List<cl_forlist> { };

        public UpravlenieM()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
            {
                if(СУМ.indexOFg == Convert.ToInt32(СУМ.cl_magazin_s[i].Gorod))
                {
                    cl_list1.Add(new cl_forlist
                    {
                        ID = СУМ.cl_magazin_s[i].ID,
                        Name = СУМ.cl_magazin_s[i].Name + ",     " + СУМ.cl_magazin_s[i].Adress
                    });
                }
            }
            listBox_Upravlenie.DataSource = cl_list1;
            listBox_Upravlenie.DisplayMember = "Name";
            listBox_Upravlenie.ValueMember = "ID";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_Add_m FAdd_m = new Form_Add_m();
            FAdd_m.Show();
            this.Close();
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                СУМ.indexOFm = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                Form_Red_m FRed_m = new Form_Red_m();
                FRed_m.Show();
                this.Close();
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                int id = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
                {
                    if (id == Convert.ToInt32(СУМ.cl_magazin_s[i].ID)) { СУМ.cl_magazin_s.RemoveAt(i); }
                }
                MessageBox.Show("Данные удалены!");
            }
            UpravlenieM FUpravlenieM = new UpravlenieM();
            FUpravlenieM.Show();
            this.Close();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                СУМ.indexOFm = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                Form_Inf_m FInf_m = new Form_Inf_m();
                FInf_m.Show();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Upravlenie Form_Upravlenie = new Upravlenie();
            Form_Upravlenie.Show();
            this.Close();
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            СУМ.indexOFm = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
            UpravlenieO Form_UpravlenieO = new UpravlenieO();
            Form_UpravlenieO.Show();
            this.Close();
        }
    }
}
