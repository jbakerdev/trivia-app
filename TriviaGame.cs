using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace TriviaApp
{
    public static class TriviaGame
    {
        private static readonly HttpClient Client = new HttpClient();

        private const string Endpoint = "https://opentdb.com/api.php?amount=1";

        public static async Task<Question> GetQuestionAsync()
        {
            Client.DefaultRequestHeaders.Accept.Clear();

            var streamTask = Client.GetStreamAsync(Endpoint);
            var apiResponse = await JsonSerializer.DeserializeAsync<ApiResponse>(await streamTask);

            return apiResponse.Results[0];
        }
    }
}