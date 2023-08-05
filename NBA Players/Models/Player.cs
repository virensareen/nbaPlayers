using Newtonsoft.Json;

public class Player
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}