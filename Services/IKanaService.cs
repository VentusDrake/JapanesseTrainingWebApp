using BasicJapanesseTraining.Models;

namespace BasicJapanesseTraining.Services {
    public interface IKanaService {
        Kana GetRandomHiragana();
        Kana GetRandomKatakana();
    }
}