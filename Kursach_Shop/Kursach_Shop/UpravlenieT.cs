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
    public partial class UpravlenieT : Form
    {
        List<cl_forlist> cl_list1 = new List<cl_forlist> { };

        public UpravlenieT()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
            {
                if (СУМ.indexOFo == Convert.ToInt32(СУМ.cl_tovar_s[i].Otdel))
                {
                    cl_list1.Add(new cl_forlist
                    {
                        ID = СУМ.cl_tovar_s[i].ID,
                        Name = СУМ.cl_tovar_s[i].Name + ",     " + СУМ.cl_tovar_s[i].Price
                    });
                }
            }
            listBox_Upravlenie.DataSource = cl_list1;
            listBox_Upravlenie.DisplayMember = "Name";
            listBox_Upravlenie.ValueMember = "ID";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_Add_t FAdd_t = new Form_Add_t();
            FAdd_t.Show();
            this.Close();
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                СУМ.indexOFt = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                Form_Red_t FRed_t = new Form_Red_t();
                FRed_t.Show();
                this.Close();
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                int id = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
                {
                    if (id == Convert.ToInt32(СУМ.cl_tovar_s[i].ID)) { СУМ.cl_tovar_s.RemoveAt(i); }
                }
                MessageBox.Show("Данные удалены!");
            }
            UpravlenieT FUpravlenieT = new UpravlenieT();
            FUpravlenieT.Show();
            this.Close();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie.SelectedValue != null)
            {
                СУМ.indexOFt = Convert.ToInt32(listBox_Upravlenie.SelectedValue);
                Form_Inf_t FInf_t = new Form_Inf_t();
                FInf_t.Show();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            UpravlenieO Form_UpravlenieO = new UpravlenieO();
            Form_UpravlenieO.Show();
            this.Close();
        }
    }
}
