using System;
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
        private string urlScout, urlCatalog;
        private HtmlAgilityPack.HtmlDocument htmlSrc;
        private List<string> urlBooks = new List<string>();

        private int numResults = 0;
        
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
            LoadScoutPage();
            DoCatalogSearch();
        }

        private void LoadScoutPage()
        {
            urlScout = "https://www.bibliotecas.uaslp.mx/cgi-bin/koha/opac-search.pl?idx=&q="
                + tbSearchQ.Text + "&weight_search=1";

            HtmlWeb web = new HtmlWeb();

            htmlSrc = web.Load(@urlScout.ToString());

            var node = htmlSrc.DocumentNode.SelectSingleNode("//h2[@id='numresults']/span");

            if(!int.TryParse(node.InnerHtml, out numResults)) //Returns false if parsing went wrong
            {
                MessageBox.Show("No se encontraron resultados!");
            }
        }

        private void DoCatalogSearch()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlNodeCollection htmlNodeScout;

            //Stores the html of each iteration of the search
            HtmlAgilityPack.HtmlDocument htmlScout;

            urlBooks.Clear();
            lbBookResults.Items.Clear();

            for (int i = 0; i < min(40, numResults); i += 20)
            {
                urlCatalog = "https://www.bibliotecas.uaslp.mx/cgi-bin/koha/opac-search.pl?idx=&q="
                    + tbSearchQ.Text +"&offset="+ i.ToString() + "&sort_by=relevance_dsc&count=20";
                
                htmlScout = web.Load(@urlCatalog.ToString());

                htmlNodeScout = htmlScout.DocumentNode.SelectNodes("//a[@class='title']");

                foreach(var node in htmlNodeScout)
                {
                    urlBooks.Add(processBookUrl(node.OuterHtml));
                    lbBookResults.Items.Add(processBookTitle(node.InnerHtml));
                }
            }

        }

        private void lbBookResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbBookResults.SelectedIndex != -1)
            {
                MessageBox.Show(urlBooks[lbBookResults.SelectedIndex]);
            }
        }

        private int min(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }

        private string processBookTitle(string innerhtml)
        {
            string title;

            title = innerhtml.Substring(0, innerhtml.IndexOf("/")-1);

            return title;
        }

        private string processBookUrl(string outerhtml)
        {
            string url = "https://www.bibliotecas.uaslp.mx";

            outerhtml = outerhtml.Substring(outerhtml.IndexOf("/"));
            url += outerhtml.Substring(0, outerhtml.IndexOf("\""));

            return url;
        }
    }
}
