namespace çalışanyönetimsistemi.Models.Baglantisql
{
    using System;
    using System.Collections.Generic;
    
    public partial class iletişim
    {
        public int iletişimid { get; set; }
        public string ad { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string mesaj { get; set; }
    }
}
