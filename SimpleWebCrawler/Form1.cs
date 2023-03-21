using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abot2.Core;
using Abot2.Crawler;
using Abot2.Poco;
using Serilog;
namespace SimpleWebCrawler
{

    public partial class Form1 : Form
    {
        public string consoleText;

        public Form1(string consoleText)
        {
            this.consoleText = consoleText ?? throw new ArgumentNullException(nameof(consoleText));
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Btn_Crawler_Click(object sender, EventArgs e)
        {
            string[] args = { "0", "1" };
            string url = Weblink.Text;
            _ = Main(args, url);
            
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "HTML (*.html)|*.html |Text file (*.txt)|*.txt";
        }

        private void Btn_htmld_Click(object sender, EventArgs e)
        {
            var client = new WebClient();

            var text = client.DownloadString(txtboxhtmld.Text);
            
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, text);
            }

        }
    }
}
