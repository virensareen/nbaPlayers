using Newtonsoft.Json;

public class PlayersResponse
{
    [JsonProperty("data")]
    public List<Player> Data { get; set; }
}