﻿using LexiconIMDB.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LexiconIMDB.Services
{
    public interface IGenreSelectListService
    {
        IEnumerable<SelectListItem> GetGenres(IEnumerable<Movie> movies);
    }
}