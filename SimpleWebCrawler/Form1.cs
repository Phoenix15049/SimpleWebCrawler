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


        static async Task Main(string[] args, string url)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("Demo starting up!");


            await DemoSimpleCrawler(url);
            await DemoSinglePageRequest();
        }

        private static async Task DemoSimpleCrawler(string url)
        {
            var config = new CrawlConfiguration
            {
                MaxPagesToCrawl = 20, //Only crawl 10 pages
                MinCrawlDelayPerDomainMilliSeconds = 3000 //Wait this many millisecs between requests
            };
            var crawler = new PoliteWebCrawler(config);

            crawler.PageCrawlCompleted += PageCrawlCompleted;//Several events available...

            var crawlResult = await crawler.CrawlAsync(new Uri(url));
        }

        private static async Task DemoSinglePageRequest()
        {
            var pageRequester = new PageRequester(new CrawlConfiguration(), new WebContentExtractor());

            var crawledPage = await pageRequester.MakeRequestAsync(new Uri("http://google.com"));
            Log.Logger.Information("{result}", new
            {

                url = crawledPage.Uri,
                status = Convert.ToInt32(crawledPage.HttpResponseMessage.StatusCode)
            });
        }

        private static void PageCrawlCompleted(object sender, PageCrawlCompletedArgs e)
        {
            var httpStatus = e.CrawledPage.HttpResponseMessage.StatusCode;
            var rawPageText = e.CrawledPage.Content.Text;//HTML

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
