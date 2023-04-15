using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace epubReader.Helper
{
    public class Reader
    {

        ZipArchive archive;

        public List <String> ReadFile()
        {
            List<String> liste = new List<String>();

           // var zipPath = @"D:\ttt\git.epub";
            var zipPath = @"git.epub";

            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                ZipArchiveEntry entry = archive.GetEntry("OEBPS/toc.ncx");
                //XDocument doc = null;
                //using (StreamReader stream = new StreamReader(entry.Open()))
                //{
                //    XDocument offlineHeadline = XDocument.Load(stream);                  
                //    foreach (var item in offlineHeadline.DescendantNodes())
                //    {

                //    }

                //    foreach (var item in offlineHeadline.Descendants())
                //    {

                //    }

                //    var query = from c in offlineHeadline.Descendants("navMap") select c;
                //}
                var sss = entry.Open();

                var serializer = new XmlSerializer(typeof(List<ncxNavMapNavPointNavPointNavPoint>));
               
               
                var other = (List<ncxNavMapNavPointNavPointNavPoint>)(serializer.Deserialize(sss));
                    
                




                //XElement root = XElement.Load(entry.Open());
                //IEnumerable<XElement> toc =
                //    from el in root.Elements("navPoint")
                //    where (string)el.Attribute("playOrder") == "1"
                //    select el;
                //foreach (XElement el in toc)
                //{

                //}



            }
            return liste;
        }
    }
}
