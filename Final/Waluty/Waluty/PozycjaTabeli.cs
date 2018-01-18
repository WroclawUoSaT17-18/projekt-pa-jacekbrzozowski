using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Waluty
{
    public class PozycjaTabeli
    {
        [XmlElement("nazwa_waluty")]
        public string NazwaWaluty { get; set; }

        [XmlElement("przelicznik")]
        public string Przelicznik { get; set; }

        [XmlElement("kod_waluty")]
        public string KodWaluty { get; set; }

        [XmlElement("kurs_kupna")]
        public string KursKupna { get; set; }

        [XmlElement("kurs_sprzedazy")]
        public string KursSprzedazy { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.KodWaluty, this.NazwaWaluty);
        }
    }
}
