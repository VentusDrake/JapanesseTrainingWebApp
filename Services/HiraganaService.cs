using BasicJapanesseTraining.Models;
using System.Text.Json;

namespace BasicJapanesseTraining.Services {
    public class HiraganaService : IHiraganaService {
        public List<Hiragana> LoadHiragana(string path = "Config/hiragana.json") {
            var fullPath = Path.Combine(AppContext.BaseDirectory, path);
            var json = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<Hiragana>>(json);
        }

        public Hiragana GetRandomHiragana() {
            List<Hiragana> hiraganaList = LoadHiragana();

            Random rand = new Random();
            var hiraganaIndex = rand.Next(0, hiraganaList.Count);

            return hiraganaList[hiraganaIndex];
        }
    }
}
