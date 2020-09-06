using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;

namespace Generate
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 1; i <= 444; i++)
            {

                String text = "";
                String pageprev = "page" + (i - 1);
                String pagenext = "page" + (i + 1);
                String page = "page" + i;
                String image = "2018_2019_page_" + i;
                // Example #2: Write one string to a text file.
                text = "<!DOCTYPE html>\n\t" +
    "<html>\n\t" +
    "<head>\n\t" +
        "<title> Year Book  | AAU </title>\n\t" +
        " <meta charset = \"UTF-8\" />\n\t" +
     "  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n\t" +
     "  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n\t" +
    "  <link rel=\"SHORTCUT ICON\" href=\"http://www.ammanu.edu.jo/Ar/images/icon.png\" type=\"image/png\" />\n\t" +
           "  <meta name=\"description\" content=\"Year Book\"/>\n\t" +
    "  <meta name=\"keywords\" content=\"AAU,Al Ahliyya Amman University,AAU Graduate Students,Amman,Salt,private,Ahliyya,Year Book,Faculties,Departments,Graduate Year,YearBook,Year Book\" />\n\t" +
    "  <link rel=\"stylesheet\" type=\"text/css\" href=\"../css/Style.css\">\n\t" +

                                 " </head>\n\t" +
                                   "<body>\n\t" +

                                   "<div class=\"header\">\n\t" +

      "<a href = \"http://www.ammanu.edu.jo/English/Homep/Home.aspx\" target=_blank>\n\t" +
    "<p class=\"h1\">Al Ahliyya Amman University</p>" +

    "<div class=\"logo\">\n\t" +
    "<img class=\"img1\" src=\"../images/logo.png\">\n\t" +
    "</div>\n\t" +

                "<p class=\"h2\">جامعة عمان الاهلية</p>\n\t" +

    "<div class=\"clear\"></div>" +
            "<a href =\"../Home.html\" class=\"back\">Back</a>\n" +
    "</a>\n\t" +
    "</div>\n\t" +


"<p class=\"title\">Year Book 2018/2019</p>\n\t" +
    "<div class=\"pagenumber\"> <span>" + i + "</span> of <span>444</span>  </div>\n\t" +
"<div class=\"wrapper\">\n\t" +


    "<a class=\"arrowl\" href=\"" + pageprev + ".html\">\n\t" +
        "<img src =\"../images/left-arrow.png\" />\n\t" +
        "prev\n\t" +
    "</a>\n\t" +


    "<img class=\"page\" src=\"../images/2018_2019/" + image + ".png\"/>\n\t" +


    "<a class=\"arrowr\" href=\"" + pagenext + ".html\">\n\t" +
        "<img src =\"../images/right-arrow.png\" />\n\t" +
        "next\n\t" +
        "</a>\n\t" +

    "<div class=\"clear\"></div>" +
    "</div>\n\t" +


                "<div class=\"footer\">\n\t" +
                "<p> <a href = \"http://www.ammanu.edu.jo/ENGLISH/COPYRIGHTS/COPYRIGHTS.ASPX\"  + id=\"date\"  target=_blank>   Copyright © Al-Ahliyya Amman University  2019 </a> | <a target = _blank  href=\"http://www.ammanu.edu.jo/English/hec/home.aspx\">Developed By HEC</p>\n\t" +
                "</div>\n\t" +

                "</body>\n\t" +
                "</html>" +
                  "<script src = \"js/user.js\"></script>\n\t" +

                "<script>" +

    "$(document).ready(function() {" +

                    "var d = new Date();" +
                    "var n = \"Copyright © Al-Ahliyya Amman University \"  + d.getFullYear();" +
                    "document.getElementById(\"date\" ).innerHTML = n;" +

               " }); " +
            "</script> \n\t" ;



                System.IO.File.WriteAllText(@"C:\\Users\\Admin\\Desktop\\2018_2019\\" + page + ".html", text);
            }








        }
    }
}
