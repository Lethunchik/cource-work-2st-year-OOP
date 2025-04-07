using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kursach_Shop
{
    public partial class СУМ : Form
    {
        bool opForm = false;
        public static List<cl_city> cl_sity_s = new List<cl_city> { };
        public static List<cl_magazin> cl_magazin_s = new List<cl_magazin> { };
        public static List<cl_otdel> cl_otdel_s = new List<cl_otdel> { };
        public static List<cl_tovar> cl_tovar_s = new List<cl_tovar> { };
        public static int indexOFg;
        public static int indexOFm;
        public static int indexOFo;
        public static int indexOFt;
        
        public СУМ()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Prosmotr Form_Prosmotr = new Prosmotr();
                Form_Prosmotr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Upravlenie Form_Upravlenie = new Upravlenie();
                Form_Upravlenie.Show();
                opForm = true;
                
        }

        private void SaveExcel_Click(object sender, EventArgs e)
        {
            int sc;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application xlApp = new Excel.Application(); //Excel
            Excel.Workbook xlWB; //рабочая книга              
            Excel.Worksheet xlSht; //лист Excel   
            xlWB = xlApp.Workbooks.Open(ofd.FileName); //название файла Excel                                             
            xlSht = xlWB.Worksheets["Город"]; //1-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null) //чистим
            {
                xlSht.Range["A" + sc].Value = "";
                xlSht.Range["B" + sc].Value = "";
                xlSht.Range["C" + sc].Value = "";
                sc++;
            }
            sc = 2;
            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)//записываем
            {
                    xlSht.Range["A" + sc].Value = СУМ.cl_sity_s[i].ID;
                    xlSht.Range["B" + sc].Value = СУМ.cl_sity_s[i].Name;
                    xlSht.Range["C" + sc].Value = СУМ.cl_sity_s[i].Oblast;
                    sc++;
            }
            xlSht = xlWB.Worksheets["Магазин"]; //2-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null) //чистим
            {
                xlSht.Range["A" + sc].Value = "";
                xlSht.Range["B" + sc].Value = "";
                xlSht.Range["C" + sc].Value = "";
                xlSht.Range["D" + sc].Value = "";
                xlSht.Range["E" + sc].Value = "";
                xlSht.Range["F" + sc].Value = "";
                sc++;
            }
            sc = 2;
            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)//записываем
            {
                xlSht.Range["A" + sc].Value = СУМ.cl_magazin_s[i].ID;
                xlSht.Range["B" + sc].Value = СУМ.cl_magazin_s[i].Name;
                xlSht.Range["C" + sc].Value = СУМ.cl_magazin_s[i].Napravlennost;
                xlSht.Range["D" + sc].Value = СУМ.cl_magazin_s[i].Adress;
                xlSht.Range["E" + sc].Value = СУМ.cl_magazin_s[i].Gorod;
                xlSht.Range["F" + sc].Value = СУМ.cl_magazin_s[i].Vr_rab;
                sc++;
            }
            xlSht = xlWB.Worksheets["Отдел"]; //3-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null) //чистим
            {
                xlSht.Range["A" + sc].Value = "";
                xlSht.Range["B" + sc].Value = "";
                xlSht.Range["C" + sc].Value = "";
                xlSht.Range["D" + sc].Value = "";
                xlSht.Range["E" + sc].Value = "";
                sc++;
            }
            sc = 2;
            for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)//записываем
            {
                xlSht.Range["A" + sc].Value = СУМ.cl_otdel_s[i].ID;
                xlSht.Range["B" + sc].Value = СУМ.cl_otdel_s[i].Number;
                xlSht.Range["C" + sc].Value = СУМ.cl_otdel_s[i].Magazin;
                xlSht.Range["D" + sc].Value = СУМ.cl_otdel_s[i].Tip_tovarov;
                xlSht.Range["E" + sc].Value = СУМ.cl_otdel_s[i].Otv_sotr;
                sc++;
            }
            xlSht = xlWB.Worksheets["Товар"]; //4-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null) //чистим
            {
                xlSht.Range["A" + sc].Value = "";
                xlSht.Range["B" + sc].Value = "";
                xlSht.Range["C" + sc].Value = "";
                xlSht.Range["D" + sc].Value = "";
                xlSht.Range["E" + sc].Value = "";
                xlSht.Range["F" + sc].Value = "";
                xlSht.Range["G" + sc].Value = "";
                xlSht.Range["H" + sc].Value = "";
                sc++;
            }
            sc = 2;
            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)//записываем
            {
                xlSht.Range["A" + sc].Value = СУМ.cl_tovar_s[i].ID;
                xlSht.Range["B" + sc].Value = СУМ.cl_tovar_s[i].Name;
                xlSht.Range["C" + sc].Value = СУМ.cl_tovar_s[i].Otdel;
                xlSht.Range["D" + sc].Value = СУМ.cl_tovar_s[i].Kol_vo;
                xlSht.Range["E" + sc].Value = СУМ.cl_tovar_s[i].Date_izg;
                xlSht.Range["F" + sc].Value = СУМ.cl_tovar_s[i].Date_godn;
                xlSht.Range["G" + sc].Value = СУМ.cl_tovar_s[i].Price;
                xlSht.Range["H" + sc].Value = СУМ.cl_tovar_s[i].Proizvod;
                sc++;
            }

            MessageBox.Show("Данные сохранены");
            xlWB.Close(true); //закрываем книгу, изменения не сохраняем
            xlApp.Quit(); //закрываем Excel
        }

        private void LoadExcel_Click(object sender, EventArgs e)
        {
            int sc;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application xlApp = new Excel.Application(); //Excel
            Excel.Workbook xlWB; //рабочая книга              
            Excel.Worksheet xlSht; //лист Excel   
            xlWB = xlApp.Workbooks.Open(ofd.FileName); //название файла Excel                                             
            xlSht = xlWB.Worksheets["Город"]; //1-й лист в книге
            sc = 2;
            while (xlSht.Range["A"+sc].Value != null){
                cl_sity_s.Add(new cl_city
                {
                    ID = xlSht.Range["A" + sc].Value.ToString(),
                    Name = xlSht.Range["B" + sc].Value.ToString(),
                    Oblast = xlSht.Range["C" + sc].Value.ToString()
                });
                sc++;
            }
            xlSht = xlWB.Worksheets["Магазин"]; //2-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null)
            {
                cl_magazin_s.Add(new cl_magazin
                {
                    ID = xlSht.Range["A" + sc].Value.ToString(),
                    Name = xlSht.Range["B" + sc].Value.ToString(),
                    Napravlennost = xlSht.Range["C" + sc].Value.ToString(),
                    Adress = xlSht.Range["D" + sc].Value.ToString(),
                    Gorod = xlSht.Range["E" + sc].Value.ToString(),
                    Vr_rab = xlSht.Range["F" + sc].Value.ToString()
                });
                sc++;
            }
            xlSht = xlWB.Worksheets["Отдел"]; //3-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null)
            {
                cl_otdel_s.Add(new cl_otdel
                {
                    ID = xlSht.Range["A" + sc].Value.ToString(),
                    Number = xlSht.Range["B" + sc].Value.ToString(),
                    Magazin = xlSht.Range["C" + sc].Value.ToString(),
                    Tip_tovarov = xlSht.Range["D" + sc].Value.ToString(),
                    Otv_sotr = xlSht.Range["E" + sc].Value.ToString()
                });
                sc++;
            }
            xlSht = xlWB.Worksheets["Товар"]; //4-й лист в книге
            sc = 2;
            while (xlSht.Range["A" + sc].Value != null)
            {
                cl_tovar_s.Add(new cl_tovar
                {
                    ID = xlSht.Range["A" + sc].Value.ToString(),
                    Name = xlSht.Range["B" + sc].Value.ToString(),
                    Otdel = xlSht.Range["C" + sc].Value.ToString(),
                    Kol_vo = xlSht.Range["D" + sc].Value.ToString(),
                    Date_izg = xlSht.Range["E" + sc].Value.ToString(),
                    Date_godn = xlSht.Range["F" + sc].Value.ToString(),
                    Price = xlSht.Range["G" + sc].Value.ToString(),
                    Proizvod = xlSht.Range["H" + sc].Value.ToString()
                });
                sc++;
            }

            xlWB.Close(false); //закрываем книгу, изменения не сохраняем
            xlApp.Quit(); //закрываем Excel
        }
    }
}
