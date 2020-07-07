using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParseManager
{
    public class HtmlParseManagement
    {
        public string xPath { get; set; }
        public string url { get; set; }
        public HtmlParseManagement(string xPath, string url)
        {
            this.xPath = xPath;
            this.url = url;
        }
        public string GetHtmlText()
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
                var html = url;

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);
                xPath = xPath.Replace("\"", "\'");
                var node = htmlDoc.DocumentNode.SelectSingleNode(xPath); ////*[@id="from-web"]/span                
                if (node == null)
                {
                    return "Not Found";
                }
                return node.InnerText;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
