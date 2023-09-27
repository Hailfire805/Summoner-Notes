using System;

public class GetPlayers
{
	public async void GetPlayers()
	{
        string RiotApiKey = WebConfigurationManager.AppSettings["RiotApiKey"];
        using (HttpClient client = new HttpClient()) {
            string summonerNamesEndpoint = "/lol/summoner/v4/summoners/by-name/";

            List<string> participantNames = new List<string>();

            // Replace these sample summoner names with actual summoner names you want to retrieve
            string summonerName = player;

            UriBuilder uriBuilder = new UriBuilder(RiotApiBaseUrl + summonerNamesEndpoint + Uri.EscapeDataString(summonerName)) {
                Query = $"api_key={RiotApiKey}"
            };

            try {
                HttpResponseMessage response = await client.GetAsync(uriBuilder.Uri);
                if (response.IsSuccessStatusCode) {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var json = JsonSerializer.Deserialize<Dictionary<string, string>>(responseBody);
                    // Parse the summoner information from the response and extract the summoner name
                    // Add the summoner name to the participantNames list
                    // For example, you can use JSON serialization/deserialization to parse the response
                    Console.WriteLine(json);
                    foreach (var line in json) {
                    }
                }
            }
            catch (Exception) {
                // Handle and log any exceptions that occur during the API request.
            }
            // Once you have populated the participantNames list, add them to the AlliedBox
            foreach (var name in participantNames) {
                if (name != "YourSummonerName") {
                    AlliedBox.Items.Add(name);
                }
            }
        }
    }
}
}
