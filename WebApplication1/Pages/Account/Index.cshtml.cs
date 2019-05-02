﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public IndexModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<AccountModel> AccountModel { get;set; }

        public async Task OnGetAsync()
        {
            AccountModel = await _context.AccountModel.ToListAsync();
        }
    }
}
