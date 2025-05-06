using System.Text.Json.Serialization;

namespace BasicJapanesseTraining.Models {
    public class Hiragana {
        [JsonPropertyName("character")]
        public string Character { get; set; }
        [JsonPropertyName("romanization")]
        public string Roumaji { get; set; }
    }
}
