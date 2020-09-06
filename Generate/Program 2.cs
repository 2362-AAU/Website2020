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
    using Excel = Microsoft.Office.Interop.Excel;
    //Create COM Objects. Create a COM object for everything that is referenced

    class Program2
    {
        public void ReadSample()
        {
            
        }

        static void Main(string[] args)
        {

            String text = "";
            Excel.Application excelApp = new Excel.Application();
            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(@"C:\\Users\\Admin\\Desktop\\xmltest\\123456789-344.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                for (int i = 2; i <= rowCount; i++)
                {
                   
                        Excel.Range range = (excelWorksheet.Cells[i, 13] as Excel.Range);
                        string cellValue = range.Value.ToString();


                    Excel.Range range2 = (excelWorksheet.Cells[i, 18] as Excel.Range);
                    string cellValue2 = range2.Value.ToString();


                    text =  text +
                           

                          
             "<Article>\n\t" +
              "<Journal>\n\t" +
             "<PublisherName>"+cellValue+"</PublisherName>\n\t" +
             "<JournalTitle>"+cellValue2+"</JournalTitle>\n\t" +

             "<PISSN></PISSN>\n\t" +
             "<EISSN></EISSN>\n\t" +
                 "<Volume></Volume>\n\t" +
             "<Issue></Issue>\n\t" +
                 "<PartNumber></PartNumber>\n\t" +
                 "<IssueTopic></IssueTopic>\n\t" +
                 "<IssueLanguage></IssueLanguage>\n\t" +
                 "<Season></Season>\n\t" +
                 "<SpecialIssue>Y/N</SpecialIssue>\n\t" +
                 "<SupplementaryIssue>Y/N</SupplementaryIssue>\n\t" +
                 "<IssueOA>Y/N</IssueOA>\n\t" +
                 "<PubDate>\n\t" +
             "<Year></Year>\n\t" +
             "<Month></Month>\n\t" +
             "<Day></Day>\n\t" +
             "</PubDate>\n\t" +
             "</Journal>\n\t" +
          "<ArticleType></ArticleType>\n\t" +
          "<ArticleTitle></ArticleTitle>\n\t" +
          "<SubTitle></SubTitle>\n\t" +
          "<ArticleLanguage></ArticleLanguage>\n\t" +
          "<ArticleOA>Y/N</ArticleOA>\n\t" +
          "<FirstPage></FirstPage>\n\t" +
          "<LastPage></LastPage>\n\t" +

        "<AuthorList>\n\t" +
            "<Author>\n\t" +
            "<FirstName></FirstName>\n\t" +
            "<MiddleName></MiddleName>\n\t" +
                "<LastName></LastName>\n\t" +
                "<AuthorLanguage></AuthorLanguage>\n\t" +
            "<Affiliation></Affiliation>\n\t" +
                "<Country></Country>\n\t" +
                "<Phone></Phone>\n\t" +
                "<Fax></Fax>\n\t" +
                "<AuthorEmails></AuthorEmails>\n\t" +
                "<CorrespondingAuthor>Y/N</CorrespondingAuthor>\n\t" +
            "</Author>\n\t" +
        "</AuthorList>\n\t" +
        "<DOI></DOI>\n\t" +
        "<Abstract></Abstract>\n\t" +
        "<AbstractLanguage></AbstractLanguage>\n\t" +
        "<Keywords></Keywords>\n\t" +
        "<Fulltext></Fulltext>\n\t" +
        "<URLs>\n\t" +
            "<abstract></abstract>\n\t" +
                "<Fulltext>\n\t" +
                "<pdf></pdf>\n\t" +
            "</Fulltext>\n\t" +

        "</URLs>\n\t" +
        "<FulltextLanguage></FulltextLanguage>\n\t" +

        "<References>\n\t" +
          "<ReferencesarticleTitle></ReferencesarticleTitle>\n\t" +
          "<ReferencesfirstPage></ReferencesfirstPage>\n\t" +
          "<ReferenceslastPage></ReferenceslastPage>\n\t" +
          "<authorList>\n\t" +
            "<author>\n\t" +
            "<ReferencesfirstName></ReferencesfirstName>\n\t" +
            "<ReferencesmiddleName></ReferencesmiddleName>\n\t" +
              "<ReferenceslastName></ReferenceslastName>\n\t" +
           "<Referencesaffiliation></Referencesaffiliation>\n\t" +
                "<Referencescountry></Referencescountry>\n\t" +
            "</author>\n\t" +
        "</authorList>\n\t" +
        "</References>\n\t" +
            "</Article>"
       ;










                    }
          

                System.IO.File.WriteAllText(@"C:\\Users\\Admin\\Desktop\\xmltest\\www" + ".xml", text);

                excelWorkbook.Close();
                excelApp.Quit();
            }



        }
    }
}
