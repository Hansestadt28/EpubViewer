using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                XDocument doc = null;
                using (StreamReader stream = new StreamReader(entry.Open()))
                {
                    XDocument offlineHeadline = XDocument.Load(stream);
                    foreach (var item in offlineHeadline.DescendantNodes())
                    {

                    }
                }                 


            }
            return liste;
        }
    }
}
