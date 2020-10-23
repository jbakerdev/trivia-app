using System.Text.Json.Serialization;

namespace TriviaApp
{
    public class ApiResponse
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }

        [JsonPropertyName("results")]
        public Question[] Results { get; set; }
    }
}