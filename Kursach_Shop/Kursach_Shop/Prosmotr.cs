using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach_Shop;

namespace Kursach_Shop
{

    public partial class Prosmotr : Form
    {
        public static List<string> Nsp = new List<string> { };
        public List<string> sp1 = new List<string> { };
        public List<string> sp2 = new List<string> { };
        public List<string> sp3 = new List<string> { };
        public List<string> sp4 = new List<string> { };
        public static List<string> LB = new List<string> { };
        public Context context = new Context();

        public static string spin_m1;
        public static string spin_m2;
        public static string spin_m3;
        public static string spin_t1;
        public static string spin_t2;
        public static string tb_min;
        public static string tb_max;

        public Prosmotr()
        {
            InitializeComponent();
            comboBox_m2.Items.Add("Все");
            comboBox_m3.Items.Add("Все");
            comboBox_t1.Items.Add("Все");
            comboBox_t2.Items.Add("Все");

            comboBox1.SelectedIndex = 0;
            for (int i = 0; i < СУМ.cl_sity_s.Count; i++)
            {
                if (!sp1.Contains(СУМ.cl_sity_s[i].Name))
                {
                    sp1.Add(СУМ.cl_sity_s[i].Name);
                }
            }
            for (int i = 0; i < sp1.Count; i++)
            {
                comboBox_m2.Items.Add(sp1[i]);
            }
            for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
            {
                if (!sp2.Contains(СУМ.cl_magazin_s[i].Name))
                {
                    sp2.Add(СУМ.cl_magazin_s[i].Name);
                }
            }
            for (int i = 0; i < sp2.Count; i++)
            {
                comboBox_m3.Items.Add(sp2[i]);
            }
            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
            {
                if (!sp3.Contains(СУМ.cl_tovar_s[i].Name))
                {
                    sp3.Add(СУМ.cl_tovar_s[i].Name);
                }
                if (!sp4.Contains(СУМ.cl_tovar_s[i].Proizvod))
                {
                    sp4.Add(СУМ.cl_tovar_s[i].Proizvod);
                }
            }
            for (int i = 0; i < sp3.Count; i++)
            {
                comboBox_t1.Items.Add(sp3[i]);
            }
            for (int i = 0; i < sp4.Count; i++)
            {
                comboBox_t2.Items.Add(sp4[i]);
            }
            comboBox_m1.SelectedIndex = 0;
            comboBox_m2.SelectedIndex = 0;
            comboBox_m3.SelectedIndex = 0;
            comboBox_t1.SelectedIndex = 0;
            comboBox_t2.SelectedIndex = 0;
            if (comboBox1.SelectedIndex == 1)
            {
                context.SetStrategy(new ConcreteStrategyA());
            }
            else
            {
                context.SetStrategy(new ConcreteStrategyB());
            }
            spin_m1 = comboBox_m1.SelectedItem.ToString();
            spin_m2 = comboBox_m2.SelectedItem.ToString();
            spin_m3 = comboBox_m3.SelectedItem.ToString();
            spin_t1 = comboBox_t1.SelectedItem.ToString();
            spin_t2 = comboBox_t2.SelectedItem.ToString();
            tb_min = textBox_tMin.Text;
            tb_max = textBox_tMax.Text;
            sortirovka();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox_prosmotr.SelectedIndex > -1)
            {
                СУМ.indexOFt = Convert.ToInt32(Nsp[listBox_prosmotr.SelectedIndex]);
                for (int i = 0; i < СУМ.cl_tovar_s.Count; i++) {
                    if (СУМ.indexOFt.ToString() == СУМ.cl_tovar_s[i].ID) {
                        СУМ.indexOFo = Convert.ToInt32(СУМ.cl_tovar_s[i].Otdel);
                    }
                }
                for (int i = 0; i < СУМ.cl_otdel_s.Count; i++)
                {
                    if (СУМ.indexOFo.ToString() == СУМ.cl_otdel_s[i].ID)
                    {
                        СУМ.indexOFm = Convert.ToInt32(СУМ.cl_otdel_s[i].Magazin);
                    }
                }
                for (int i = 0; i < СУМ.cl_magazin_s.Count; i++)
                {
                    if (СУМ.indexOFm.ToString() == СУМ.cl_magazin_s[i].ID)
                    {
                        СУМ.indexOFg = Convert.ToInt32(СУМ.cl_magazin_s[i].Gorod);
                    }
                }
                Form_Inf_t FInf_t = new Form_Inf_t();
                FInf_t.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spin_m1 = comboBox_m1.SelectedItem.ToString();
            spin_m2 = comboBox_m2.SelectedItem.ToString();
            spin_m3 = comboBox_m3.SelectedItem.ToString();
            spin_t1 = comboBox_t1.SelectedItem.ToString();
            spin_t2 = comboBox_t2.SelectedItem.ToString();
            tb_min = textBox_tMin.Text;
            tb_max = textBox_tMax.Text;

            if (comboBox1.SelectedIndex == 1) {
                context.SetStrategy(new ConcreteStrategyA());
            }
            else
            {
                context.SetStrategy(new ConcreteStrategyB());
            }
            sortirovka();
        }

        public void sortirovka() {
            
            Nsp.Clear();
            LB.Clear();
            listBox_prosmotr.Items.Clear();
            
            context.DoSomeBusinessLogic();
            for (int i = 0; i < LB.Count; i++) { listBox_prosmotr.Items.Add(LB[i]); }
        }

        private void textBox_tMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox_tMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }

    public class Context
    {
        // Контекст хранит ссылку на один из объектов Стратегии. Контекст не
        // знает конкретного класса стратегии. Он должен работать со всеми
        // стратегиями через интерфейс Стратегии.
        private IStrategy _strategy;

        public Context()
        { }

        // Обычно Контекст принимает стратегию через конструктор, а также
        // предоставляет сеттер для её изменения во время выполнения.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Обычно Контекст позволяет заменить объект Стратегии во время
        // выполнения.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Вместо того, чтобы самостоятельно реализовывать множественные версии
        // алгоритма, Контекст делегирует некоторую работу объекту Стратегии.
        public void DoSomeBusinessLogic()
        {
            int sortsc;
            string otdSrt = "";
            string magSrt = "";
            string magSrtN = "";
            string garSrt = "";
            string garSrtN = "";
            string garSrtO = "";
            string otd;
            string mag = "";
            string magN = "";
            string magA = "";

            for (int i = 0; i < СУМ.cl_tovar_s.Count; i++)
            {
                otdSrt = СУМ.cl_tovar_s[i].Otdel;
                for (int q = 0; q < СУМ.cl_otdel_s.Count; q++)
                {
                    if (СУМ.cl_otdel_s[q].ID == otdSrt)
                        magSrt = СУМ.cl_otdel_s[q].Magazin;
                }
                for (int q = 0; q < СУМ.cl_magazin_s.Count; q++)
                {
                    if (СУМ.cl_magazin_s[q].ID == magSrt)
                    {
                        magSrtN = СУМ.cl_magazin_s[q].Name;
                        garSrt = СУМ.cl_magazin_s[q].Gorod;
                    }
                }
                for (int q = 0; q < СУМ.cl_sity_s.Count; q++)
                {
                    if (СУМ.cl_sity_s[q].ID == magSrt)
                    {
                        garSrtN = СУМ.cl_sity_s[q].Name;
                        garSrtO = СУМ.cl_sity_s[q].Oblast;
                    }
                }

                sortsc = 0;
                if (Prosmotr.tb_min.Length > 0) if (Convert.ToInt32(СУМ.cl_tovar_s[i].Price) < Convert.ToInt32(Prosmotr.tb_min)) sortsc++;
                if (Prosmotr.tb_max.Length > 0) if (Convert.ToInt32(СУМ.cl_tovar_s[i].Price) > Convert.ToInt32(Prosmotr.tb_max)) sortsc++;
                if (Prosmotr.spin_m1.ToString() != "Все" &&
                    Prosmotr.spin_m1.ToString() != garSrtO) sortsc++;
                if (Prosmotr.spin_m2.ToString() != "Все" &&
                    Prosmotr.spin_m2.ToString() != garSrtN) sortsc++;
                if (Prosmotr.spin_m3.ToString() != "Все" &&
                    Prosmotr.spin_m3.ToString() != magSrtN) sortsc++;
                if (Prosmotr.spin_t1.ToString() != "Все" &&
                    Prosmotr.spin_t1.ToString() != СУМ.cl_tovar_s[i].Name) sortsc++;
                if (Prosmotr.spin_t2.ToString() != "Все" &&
                    Prosmotr.spin_t2.ToString() != СУМ.cl_tovar_s[i].Proizvod) sortsc++;


                if (sortsc == 0)
                {
                    //Размещение начало
                    otd = СУМ.cl_tovar_s[i].Otdel;
                    for (int q = 0; q < СУМ.cl_otdel_s.Count; q++)
                    {
                        if (СУМ.cl_otdel_s[q].ID == otd)
                        {
                            mag = СУМ.cl_otdel_s[q].Magazin;
                        }
                    }
                    for (int q = 0; q < СУМ.cl_magazin_s.Count; q++)
                    {
                        if (СУМ.cl_magazin_s[q].ID == mag)
                        {
                            magN = СУМ.cl_magazin_s[q].Name;
                            magA = СУМ.cl_magazin_s[q].Adress;
                        }
                    }
                    Prosmotr.Nsp.Add(СУМ.cl_tovar_s[i].ID);
                    Prosmotr.LB.Add(СУМ.cl_tovar_s[i].Name + "  цена:" +
                        СУМ.cl_tovar_s[i].Price + "руб.   производство:" + СУМ.cl_tovar_s[i].Proizvod + "  магазин:" +
                        magN + "  " + magA);
                    /*listBox_prosmotr.Items.Add(СУМ.cl_tovar_s[i].Name + "  цена:" +
                        СУМ.cl_tovar_s[i].Price + "руб.   производство:" + СУМ.cl_tovar_s[i].Proizvod + "  магазин:" +
                        magN + "  " + magA);*/
                    //Размещение конец
                }
            }
            this._strategy.DoAlgorithm();
        }
    }

    // Интерфейс Стратегии объявляет операции, общие для всех поддерживаемых
    // версий некоторого алгоритма.
    //
    // Контекст использует этот интерфейс для вызова алгоритма, определённого
    // Конкретными Стратегиями.
    public interface IStrategy
    {
        void DoAlgorithm();
    }

    // Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу
    // Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
    class ConcreteStrategyB : IStrategy
    {
        public void DoAlgorithm()
        {
            List<string> LB1 = new List<string> { };
            List<string> Nsp1 = new List<string> { };
            for (int i = 0; i < Prosmotr.LB.Count; i++)
            {
                LB1.Add(Prosmotr.LB[i]);
                Nsp1.Add(Prosmotr.Nsp[i]);
            }
            Prosmotr.LB.Sort();
            for (int i = 0; i < Prosmotr.LB.Count; i++)
            {
                for (int j = 0; j < Prosmotr.LB.Count; j++)
                {
                    if (Prosmotr.LB[i] == LB1[j]) { Prosmotr.Nsp[i] = Nsp1[j]; }
                }
            }
        }
    }

    class ConcreteStrategyA : IStrategy
    {
        public void DoAlgorithm()
        {
            List<string> LB1 = new List<string> { };
            List<string> Nsp1 = new List<string> { };
            for (int i = 0; i < Prosmotr.LB.Count; i++)
            {
                LB1.Add(Prosmotr.LB[i]);
                Nsp1.Add(Prosmotr.Nsp[i]);
            }
            Prosmotr.LB.Sort();
            Prosmotr.LB.Reverse();
            for (int i = 0; i < Prosmotr.LB.Count; i++)
            {
                for (int j = 0; j < Prosmotr.LB.Count; j++)
                {
                    if (Prosmotr.LB[i] == LB1[j]) { Prosmotr.Nsp[i] = Nsp1[j]; }
                }
            }
        }
    }
}
