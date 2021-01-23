using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheratence - miras
    //tüzel müşteri bir müşteridir
    //Musteri de olan TuzelMusteride de vardır
    class TuzelMusteri:Musteri   
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
