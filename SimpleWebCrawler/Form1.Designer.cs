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
            this.SuspendLayout();
            // 
            // Btn_Crawler
            // 
            this.Btn_Crawler.Location = new System.Drawing.Point(268, 239);
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
            this.Weblink.Location = new System.Drawing.Point(252, 110);
            this.Weblink.Name = "Weblink";
            this.Weblink.Size = new System.Drawing.Size(236, 34);
            this.Weblink.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
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
    }
}

