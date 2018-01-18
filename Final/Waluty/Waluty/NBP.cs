using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Waluty
{
    class NBP
    {
        public async Task<string[]> PobierzDostepneNotowania()
        {
            using (HttpClient client = new HttpClient())
            {
                string notowania = await client.GetStringAsync(@"http://www.nbp.pl/kursy/xml/dir.txt");
                return notowania.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public async Task<TabelaKursow> PobierzTabeleNotowan(string notowanie)
        {
            using (HttpClient client = new HttpClient())
            {
                string tabela = await client.GetStringAsync(string.Format(@"http://www.nbp.pl/kursy/xml/{0}.xml", notowanie));

                XmlSerializer serializer = new XmlSerializer(typeof(TabelaKursow));
                return (TabelaKursow)serializer.Deserialize(new StringReader(tabela));
            }
        }
    }
}
