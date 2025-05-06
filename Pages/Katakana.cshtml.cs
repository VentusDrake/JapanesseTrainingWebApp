using BasicJapanesseTraining.Models;
using BasicJapanesseTraining.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicJapanesseTraining.Pages
{
    public class KatakanaModel : PageModel
    {
        private readonly ILogger<KatakanaModel> _logger;
        private readonly IKanaService _kanaService;

        public Kana Katakana { get; private set; }

        public KatakanaModel(ILogger<KatakanaModel> logger, IKanaService kanaService)
        {
            _logger = logger;
            _kanaService = kanaService;
        }

        public void OnGet()
        {
            Katakana = _kanaService.GetRandomKatakana();
        }
    }

}
