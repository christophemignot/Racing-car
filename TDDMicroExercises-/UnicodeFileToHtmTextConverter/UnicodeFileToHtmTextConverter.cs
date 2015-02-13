using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public class UnicodeFileToHtmTextConverter
    {
        private string _fullFilenameWithPath;


        public UnicodeFileToHtmTextConverter(string fullFilenameWithPath)
        {
            _fullFilenameWithPath = fullFilenameWithPath;
        }

        public string ConvertToHtml()
        {
            //TextReader to StreamReader
            //Première dépendance externe
            using (StreamReader unicodeFileStream = File.OpenText(_fullFilenameWithPath))
            {
                string html = string.Empty;

                string line = unicodeFileStream.ReadLine();
                while (line != null)
                {
                    //Seconde dépendance externe
                    html += HttpUtility.HtmlEncode(line);
                    html += "<br />";
                    line = unicodeFileStream.ReadLine();
                }

                return html;
            }
        }
    }
}
