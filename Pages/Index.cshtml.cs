using BasicJapanesseTraining.Models;
using BasicJapanesseTraining.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicJapanesseTraining.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHiraganaService _hiraganaService;
        public Hiragana Hiragana {  get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IHiraganaService hiraganaService)
        {
            _logger = logger;
            _hiraganaService = hiraganaService;

        }

        public void OnGet()
        {
            Hiragana = _hiraganaService.GetRandomHiragana();
        }
    }
}
