using BasicJapanesseTraining.Models;
using System.Text.Json;

namespace BasicJapanesseTraining.Services {
    public class KanaService : IKanaService {
        public List<Kana> LoadHiragana(string path = "Config/hiragana.json") {
            var fullPath = Path.Combine(AppContext.BaseDirectory, path);
            var json = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<Kana>>(json);
        }

        public List<Kana> LoadKatakana(string path = "Config/katakana.json") {
            var fullPath = Path.Combine(AppContext.BaseDirectory, path);
            var json = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<Kana>>(json);
        }
        public Kana GetRandomHiragana() {
            List<Kana> hiraganaList = LoadHiragana();

            Random rand = new Random();
            var hiraganaIndex = rand.Next(0, hiraganaList.Count);

            return hiraganaList[hiraganaIndex];
        }

        public Kana GetRandomKatakana() {
            List<Kana> katakanaList = LoadKatakana();

            Random rand = new Random();
            var katakanaIndex = rand.Next(0, katakanaList.Count);

            return katakanaList[katakanaIndex];
        }
    }
}
