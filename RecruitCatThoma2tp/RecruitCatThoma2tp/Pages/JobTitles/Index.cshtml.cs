﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatThoma2tp.Data;
using RecruitCatThoma2tp.Models;

namespace RecruitCatThoma2tp.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext _context;

        public IndexModel(RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
