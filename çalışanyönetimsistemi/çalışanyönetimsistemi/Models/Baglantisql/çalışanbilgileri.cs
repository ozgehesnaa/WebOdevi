namespace çalışanyönetimsistemi.Models.Baglantisql
{
    using System;
    using System.Collections.Generic;
    
    public partial class çalışanbilgileri
    {
        public int çalışanid { get; set; }
        public string çalışanad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string işebaşlamatarihi { get; set; }
        public string görev { get; set; }
        public string maaş { get; set; }
    }
}
