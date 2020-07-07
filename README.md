# HtmlParser
You can parse html from url with this library.
You can use HtmlParseManager.dll file.
Just add to your project as reference.
Example using ;
#(We added to reference HtmlParseManager.dll)
  HtmlParseManager.HtmlParseManagement parseManagement = new HtmlParseManager.HtmlParseManagement(xpath, url);
  var result = parseManagement.GetHtmlText();
  
  #Simple use.
