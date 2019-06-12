using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2.AspNet.Repetition.DAL;
using S2.AspNet.Repetition.Entities;

namespace S2.AspNet.Repetition.Pages
{
    public class SearchMemesModel : PageModel
    {
        private MemeCreationRepository memeCreationRepository = new MemeCreationRepository();
        public List<MemeCreation> MemeCreations { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet()
        {
            if (SearchTerm != null)
            {
                MemeCreations = memeCreationRepository.SearchMemeText(SearchTerm);
            }
            
        }


    }
}