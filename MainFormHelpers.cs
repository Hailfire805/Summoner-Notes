using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Configuration;

internal static class MainFormHelpers {
    internal static Task GetEndpoint(string summonerNamesEndpoint, string riotApiBaseUrl, string[] returning) {
        throw new NotImplementedException();
    }

    private static string[] GetEndpoint(string endpoint, string baseUri, string[] returns) {
        string RiotApiKey = WebConfigurationManager.AppSettings["RiotApiKey"];
        List<string> strings = new List<string>();
        bool[] founds = { };
        for (int returnNum = 0; returnNum < returns.Length; returnNum++) {
            string returnString = returns[returnNum];
            founds[returnNum] = false;
            strings.Add(returnString);
        }

        using (HttpClient client = new HttpClient()) {
            UriBuilder uri = new UriBuilder(baseUri + endpoint) {
                Query = $"api_key={RiotApiKey}"
            };
            try {
                HttpResponseMessage response = await client.GetAsync(uri.Uri);
                if (response.IsSuccessStatusCode) {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    foreach (string line in responseBody.Split(new char[] { ',' })) {
                        var lineParts = line.Split(':');

                        for (int i = 0; i < lineParts.Length; i++) {
                            int startField = lineParts[i].IndexOf('\"') + 1;
                            int endField = lineParts[i].LastIndexOf('\"');
                            lineParts[i] = lineParts[i].Substring(startField, endField - startField);
                        }
                        for (int j = 0; j < returns.Length; j++) {
                            if (returns[j] != null && returns[j] == lineParts[0].Trim()) {
                                strings.Add(lineParts[1]);
                                founds[j] = true;
                            }
                            else if (returns[j] != null && founds[j] != true) {
                                Console.WriteLine($"Did not find {returns[j]}");
                            }
                        }
                        string CleanedLine = $"{lineParts[0]} : {lineParts[1]}";
                        Console.WriteLine($"{CleanedLine}");
                    }
                }
            }

            catch (Exception) {

            }
            client.Dispose();
        }
    }
}