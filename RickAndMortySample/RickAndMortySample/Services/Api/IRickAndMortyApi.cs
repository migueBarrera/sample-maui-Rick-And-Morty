using Refit;
using RickAndMortySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.Services.Api
{
    public interface IRickAndMortyApi
    {
        [Get("/api/episode")]
        Task<RickAndMortyResponse<Episode>> GetEpisodes();
        
        [Get("/api/character")]
        Task<RickAndMortyResponse<Character>> GetCharacters();
    }
}
