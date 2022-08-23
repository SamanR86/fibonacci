using infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fibonacci.web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Messeage { get; set; }
        
        public void OnGet()
        {
            int number = 15;
            Fiboo fiboonachi   =new Fiboo(number);
            Messeage =  $" Fiboonachi({number}):" + fiboonachi.result ;
        }
    } 
  
}