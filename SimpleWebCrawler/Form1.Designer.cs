namespace SimpleWebCrawler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Crawler = new System.Windows.Forms.Button();
            this.Weblink = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtboxhtmld = new System.Windows.Forms.TextBox();
            this.Btn_htmld = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crawlLabel = new System.Windows.Forms.Label();
            this.mainconsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Crawler
            // 
            this.Btn_Crawler.Location = new System.Drawing.Point(60, 100);
            this.Btn_Crawler.Name = "Btn_Crawler";
            this.Btn_Crawler.Size = new System.Drawing.Size(197, 68);
            this.Btn_Crawler.TabIndex = 0;
            this.Btn_Crawler.Text = "Crawl!";
            this.Btn_Crawler.UseVisualStyleBackColor = true;
            this.Btn_Crawler.Click += new System.EventHandler(this.Btn_Crawler_Click);
            // 
            // Weblink
            // 
            this.Weblink.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weblink.Location = new System.Drawing.Point(43, 46);
            this.Weblink.Name = "Weblink";
            this.Weblink.Size = new System.Drawing.Size(236, 34);
            this.Weblink.TabIndex = 1;
            // 
            // txtboxhtmld
            // 
            this.txtboxhtmld.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxhtmld.Location = new System.Drawing.Point(497, 46);
            this.txtboxhtmld.Name = "txtboxhtmld";
            this.txtboxhtmld.Size = new System.Drawing.Size(236, 34);
            this.txtboxhtmld.TabIndex = 2;
            // 
            // Btn_htmld
            // 
            this.Btn_htmld.Location = new System.Drawing.Point(513, 100);
            this.Btn_htmld.Name = "Btn_htmld";
            this.Btn_htmld.Size = new System.Drawing.Size(197, 68);
            this.Btn_htmld.TabIndex = 3;
            this.Btn_htmld.Text = "Download!";
            this.Btn_htmld.UseVisualStyleBackColor = true;
            this.Btn_htmld.Click += new System.EventHandler(this.Btn_htmld_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "This method will download html of this url";
            // 
            // crawlLabel
            // 
            this.crawlLabel.AutoSize = true;
            this.crawlLabel.Location = new System.Drawing.Point(14, 181);
            this.crawlLabel.Name = "crawlLabel";
            this.crawlLabel.Size = new System.Drawing.Size(392, 16);
            this.crawlLabel.TabIndex = 6;
            this.crawlLabel.Text = "This method will crawl all subpages of the url that you entering to it";
            // 
            // mainconsole
            // 
            this.mainconsole.Location = new System.Drawing.Point(32, 271);
            this.mainconsole.Name = "mainconsole";
            this.mainconsole.Size = new System.Drawing.Size(664, 22);
            this.mainconsole.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.mainconsole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crawlLabel);
            this.Controls.Add(this.Btn_htmld);
            this.Controls.Add(this.txtboxhtmld);
            this.Controls.Add(this.Weblink);
            this.Controls.Add(this.Btn_Crawler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Crawler;
        private System.Windows.Forms.TextBox Weblink;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtboxhtmld;
        private System.Windows.Forms.Button Btn_htmld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label crawlLabel;
        private System.Windows.Forms.TextBox mainconsole;
    }
}

