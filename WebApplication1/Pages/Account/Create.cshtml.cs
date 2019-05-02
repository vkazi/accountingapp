﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Pages.Account
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public CreateModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccountModel AccountModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AccountModel.Add(AccountModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}