namespace çalışanyönetimsistemi.Models.Baglantisql
{
    using System;
    using System.Collections.Generic;
    
    public partial class izintalep
    {
        public int izintalepid { get; set; }
        public string çalışanad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string izinbaslangıctarihi { get; set; }
        public string istenilenizinmiktar { get; set; }
        public string açıklama { get; set; }
    }
}
