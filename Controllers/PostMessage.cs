using Newtonsoft.Json;

namespace ProactiveBot
{
    public class PostMessage
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        
        [JsonProperty("user")]
        public string User { get; set; }
    }
}