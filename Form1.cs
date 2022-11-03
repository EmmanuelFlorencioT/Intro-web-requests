﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WebRequestBibUASLP
{
    public partial class Form1 : Form
    {
        string url;
        HtmlAgilityPack.HtmlDocument htmlSrc;
        
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            btnSearch.Enabled = false;
        }

        private void tbSearchQ_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = tbSearchQ.Text.Length > 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadPage();
        }

        private void loadPage()
        {
            url = "https://www.bibliotecas.uaslp.mx/cgi-bin/koha/opac-search.pl?idx=&q="
                + tbSearchQ.Text + "&weight_search=1";
            var html = @url.ToString();

            HtmlWeb web = new HtmlWeb();

            htmlSrc = web.Load(html);
        }
    }
}
