using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Waluty
{
    [XmlRoot("tabela_kursow")]
    public class TabelaKursow
    {
        [XmlElement("numer_tabeli")]
        public string NumerTabeli { get; set; }

        [XmlElement("data_notowania")]
        public string DataNotowania { get; set; }

        [XmlElement("data_publikacji")]
        public string DataPublikacji { get; set; }

        [XmlElement("pozycja")]
        public PozycjaTabeli[] Pozycje { get; set; }
    }
}
