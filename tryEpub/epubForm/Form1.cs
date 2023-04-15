using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace epubForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var stream = File.OpenRead("toc.xml"))
            {
                var other = (List<string>)(serializer.Deserialize(stream));
                
            }
        }
    }
}
