using ParseWebPage.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToWebSite = ConfigurationManager.AppSettings["WebSitePath"];
            var outputFile = ConfigurationManager.AppSettings["OutputFileName"];

            try
            {
                string webPageSource = GetHTMLCodeOfWebPage(pathToWebSite);

                if (!String.IsNullOrEmpty(webPageSource))
                {
                    var allLinks = GetAllMatchesToArray(webPageSource, PatternConstants.patternForLinks);
                    var allEmails = GetAllMatchesToArray(webPageSource, PatternConstants.patternForEmail);
                    var allPhoneNumbers = GetAllMatchesToArray(webPageSource, PatternConstants.patternForPhoneNumber);

                    using (var writer = new StreamWriter(outputFile, false))
                    {
                        writer.WriteLine($"[{DateTime.Now}] was parsed site {pathToWebSite}");

                        WriteInfoToFile(writer, allLinks, MessageConstants.FoundedLinksMessage);
                        WriteInfoToFile(writer, allEmails, MessageConstants.FoundedEmailsMessage);
                        WriteInfoToFile(writer, allPhoneNumbers, MessageConstants.FoundedPhoneNumbersMessage);
                    }
                }

                Console.WriteLine(MessageConstants.FinishedMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception message: {e.Message} Inner exception: {e.InnerException}");
            }

            Console.ReadKey();
        }

        public static string GetHTMLCodeOfWebPage(string pathToWebSite)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(pathToWebSite);

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var receiveStream = response.GetResponseStream();

                    using (var readStream = new StreamReader(receiveStream))
                    {
                        return readStream.ReadToEnd();
                    }
                }

                return String.Empty;
            }
        }

        public static string[] GetAllMatchesToArray(string source, string pattern)
        {
            return Regex.Matches(source, pattern)
                      .Cast<Match>()
                      .Select(match => match.Value)
                      .ToArray();
        }

        public static void WriteInfoToFile(StreamWriter writer, string[] info, string message)
        {
            writer.WriteLine(message);

            foreach (var link in info)
            {
                writer.WriteLine(link);
            }

            writer.WriteLine();
        }
    }
}
