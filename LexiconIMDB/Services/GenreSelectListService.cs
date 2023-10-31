﻿using LexiconIMDB.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LexiconIMDB.Services
{
    public class GenreSelectListService : IGenreSelectListService
    {
        private readonly LexiconIMDBContext _context;

        public GenreSelectListService(LexiconIMDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetGenresAsync()
        {
            return await _context.Movie.Select(m => m.Genre)
                               .Distinct()
                               .Select(g => new SelectListItem
                               {
                                   Text = g.ToString(),
                                   Value = g.ToString()
                               })
                               .ToListAsync();
        }
    }
}
