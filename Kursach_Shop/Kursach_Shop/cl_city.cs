using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Shop
{
    public class cl_forlist
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class cl_city
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Oblast { get; set; }
    }

    public class cl_magazin
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Napravlennost { get; set; }
        public string Adress { get; set; }
        public string Gorod { get; set; }
        public string Vr_rab { get; set; }
    }

    public class cl_otdel
    {
        public string ID { get; set; }
        public string Number { get; set; }
        public string Magazin { get; set; }
        public string Tip_tovarov { get; set; }
        public string Otv_sotr { get; set; }
    }

    public class cl_tovar
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Otdel { get; set; }
        public string Kol_vo { get; set; }
        public string Date_izg { get; set; }
        public string Date_godn { get; set; }
        public string Price { get; set; }
        public string Proizvod { get; set; }
    }
}
