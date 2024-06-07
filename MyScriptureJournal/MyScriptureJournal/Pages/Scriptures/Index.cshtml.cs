using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        public SelectList BookType {  get; set; }

        public bool AscOrDesc { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ScriptureBookType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime SearchDateStart { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime SearchDateEnd { get; set; }

        public DateTime CreationDate { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from s in _context.Scripture
                                           orderby s.Book
                                           select s.Book;

            var scriptures = from s in _context.Scripture
                             select s;


            if (!string.IsNullOrEmpty(SearchString) ) 
            {
                scriptures = scriptures.Where(x => x.JournalEntry.Contains(SearchString));
            }
            if(!string.IsNullOrEmpty(ScriptureBookType) ) 
            { 
                scriptures = scriptures.Where(x => x.Book ==  ScriptureBookType);
            }
            if (AscOrDesc == true)
            {
                scriptures = scriptures.OrderByDescending(x => x.Book);
            }
            else 
            {
                scriptures = scriptures.OrderBy(x => x.Book);
            }
            if (SearchDateStart != default && SearchDateEnd != default)
            {
                scriptures = scriptures.Where(x => x.CreatedDate >= SearchDateStart && x.CreatedDate <= SearchDateEnd);
            }

            BookType = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scriptures.ToListAsync();
        }
    }
}
