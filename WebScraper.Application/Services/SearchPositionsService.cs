using System.Text.RegularExpressions;
using WebScraper.Application.Models;

namespace WebScraper.Application.Services
{
    public class SearchPositionsService : ISearchPositionsService
    {
        public SearchPositionsService()
        {

        }

        public async Task<SearchPositionsResult> GetSearchPositions(string baseUrl, string searchUrl, string regex, string keywords, string searchFor)
        {
            HttpClient httpClient = GetHttpClient(baseUrl);
            var response = await httpClient.GetStringAsync($"{searchUrl}{keywords.Replace(" ", "+")}");

            // No more requests so we can dispose of httpclient
            httpClient.Dispose();

            var contentString = System.Web.HttpUtility.HtmlDecode(response);

            string positions = GetPositions(contentString, regex, searchFor);
            return new SearchPositionsResult { Positions = positions};
        }

        // Creates a http client with the specified base url
        public HttpClient GetHttpClient(string baseUrl)
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri(baseUrl)
            };
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36");

            return client;
        }

        // Logic for getting the matching links from the returned request data.
        public string GetPositions(string content, string regex, string searchFor)
        {
            string positions = "";
            var links = Regex.Matches(content, regex);
            List<string> linkValues = links.Select(link => Regex.Match(link.Value, "http(.*?\")").Value).ToList();
            foreach (string link in linkValues)
            {
                if (link.ToLower().Contains(searchFor.ToLower()))
                    positions = positions + $"{linkValues.IndexOf(link) + 1} ";
            }

            // if searchFor did not appear in results, we set positions to 0 so we know there were no matches instead of empty string.
            if (positions.Length == 0) positions = "0";

            positions = positions.Trim();
            return positions;
        }
    }
}
