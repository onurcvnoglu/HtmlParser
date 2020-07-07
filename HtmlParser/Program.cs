using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlParseManager.HtmlParseManagement parseManagement = new HtmlParseManager.HtmlParseManagement("/html/body/font/font/font/p[4]/table", "https://www.kadifeli.com/vasil/detayliKC.html");
            var result = parseManagement.GetHtmlText();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
