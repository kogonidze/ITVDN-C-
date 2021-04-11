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
            var pathForWebSite = ConfigurationManager.AppSettings["WebSitePath"];
            var outputFile = ConfigurationManager.AppSettings["OutputFileName"];

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(pathForWebSite);
            string webPageSource = String.Empty;

            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var receiveStream = response.GetResponseStream();

                        using (var readStream = new StreamReader(receiveStream))
                        {
                            webPageSource = readStream.ReadToEnd();
                        }
                    }
                }

                if (!String.IsNullOrEmpty(webPageSource))
                {
                    var allLinks = GetAllMatchesToArray(webPageSource, PatternConstants.patternForLinks);
                    var allEmails = GetAllMatchesToArray(webPageSource, PatternConstants.patternForEmail);
                    var allPhoneNumbers = GetAllMatchesToArray(webPageSource, PatternConstants.patternForPhoneNumber);

                    using (var writer = new StreamWriter(outputFile, false))
                    {
                        writer.WriteLine($"[{DateTime.Now}] was parsed site {pathForWebSite}");
                        writer.WriteLine("Founded links: ");

                        foreach (var link in allLinks)
                        {
                            writer.WriteLine(link);
                        }

                        writer.WriteLine();
                        writer.WriteLine("Founded emails: ");

                        foreach (var email in allEmails)
                        {
                            writer.WriteLine(email);
                        }

                        writer.WriteLine();
                        writer.WriteLine("Founded phone numbers: ");

                        foreach (var phoneNumber in allPhoneNumbers)
                        {
                            writer.WriteLine(phoneNumber);
                        }
                    }
                }

                Console.WriteLine("Finished!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception message: {e.Message} Inner exception: {e.InnerException}");
            }

            Console.ReadKey();
        }

        public static string[] GetAllMatchesToArray(string source, string pattern)
        {
            return Regex.Matches(source, pattern)
                      .Cast<Match>()
                      .Select(match => match.Value)
                      .ToArray();
        }
    }
}
