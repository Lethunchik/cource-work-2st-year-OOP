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
    public partial class Upravlenie : Form
    {
        List<cl_forlist> cl_list1 = new List<cl_forlist> { };

        public Upravlenie()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh() {
            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)
            {
                cl_list1.Add(new cl_forlist
                {
                    ID = СУМ.cl_sity_s[i].ID,
                    Name = СУМ.cl_sity_s[i].Name + ",     " + СУМ.cl_sity_s[i].Oblast + " область"
                });
            }
            listBox_Upravlenie_g.DataSource = cl_list1;
            listBox_Upravlenie_g.DisplayMember = "Name";
            listBox_Upravlenie_g.ValueMember = "ID";
        }

        private void button_add_g_Click(object sender, EventArgs e)
        {
            Form_Add_g FAdd_g = new Form_Add_g();
            FAdd_g.Show();
            this.Close();
        }

        private void button_del_g_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie_g.SelectedValue !=null){
                int id = Convert.ToInt32(listBox_Upravlenie_g.SelectedValue);
            for (int i = 0; i < СУМ.cl_sity_s.Count; i++){
                if(id == Convert.ToInt32(СУМ.cl_sity_s[i].ID)) { СУМ.cl_sity_s.RemoveAt(i); }
            }
                MessageBox.Show("Данные удалены!");
            }
            Upravlenie FUpravlenie = new Upravlenie();
            FUpravlenie.Show();
            this.Close();
        }

        private void button_red_g_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie_g.SelectedValue != null)
            {
                СУМ.indexOFg = Convert.ToInt32(listBox_Upravlenie_g.SelectedValue);
                Form_Red_g FRed_g = new Form_Red_g();
                FRed_g.Show();
                this.Close();
            }
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie_g.SelectedValue != null)
            {
                СУМ.indexOFg = Convert.ToInt32(listBox_Upravlenie_g.SelectedValue);
                Form_Inf_g FInf_g = new Form_Inf_g();
                FInf_g.Show();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            if (listBox_Upravlenie_g.SelectedValue != null){
                СУМ.indexOFg = Convert.ToInt32(listBox_Upravlenie_g.SelectedValue);
                UpravlenieM Form_UpravlenieM = new UpravlenieM();
                Form_UpravlenieM.Show();
                this.Close();
            }
        }
    }
}
