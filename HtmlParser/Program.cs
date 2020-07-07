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
            HtmlParseManager.HtmlParseManagement parseManagement = new HtmlParseManager.HtmlParseManagement("//*[@id='mw-content-text']/div/p[2]", "https://tr.wikipedia.org/wiki/Vikipedi:Hakkında");
            var result = parseManagement.GetHtmlText();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
