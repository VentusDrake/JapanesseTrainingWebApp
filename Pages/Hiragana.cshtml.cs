using BasicJapanesseTraining.Models;
using BasicJapanesseTraining.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicJapanesseTraining.Pages
{
    public class HiraganaModel : PageModel
    {
        private readonly ILogger<HiraganaModel> _logger;
        private readonly IKanaService _kanaService;
        public Kana Hiragana {  get; private set; }
        public Kana Katakana { get; private set; }

        public HiraganaModel(ILogger<HiraganaModel> logger, IKanaService kanaService)
        {
            _logger = logger;
            _kanaService = kanaService;

        }

        public void OnGet()
        {
            Hiragana = _kanaService.GetRandomHiragana();
            Katakana = _kanaService.GetRandomKatakana();
        }
    }
}
