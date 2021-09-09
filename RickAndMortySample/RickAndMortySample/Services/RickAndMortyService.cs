using Refit;
using RickAndMortySample.Models;
using RickAndMortySample.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.Services
{
    public class RickAndMortyService
    {
        private readonly IRickAndMortyApi rickAndMortyApi;
        internal RickAndMortyService()
        {
            rickAndMortyApi = RestService.For<IRickAndMortyApi>("https://rickandmortyapi.com");
        }

        internal async Task<IEnumerable<Episode>> GetEpisodesAsync()
        {
            try
            {
                var response = await rickAndMortyApi.GetEpisodes();
                if (response != null)
                {
                    return response.results;
                }
            }
            catch (Refit.ApiException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return new List<Episode>();
        }

        internal async Task<IEnumerable<Character>> GetCharactersAsync()
        {
            try
            {
                var response = await rickAndMortyApi.GetCharacters();
                if (response != null)
                {
                    return response.results;
                }
            }
            catch (Refit.ApiException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return new List<Character>();
        }
    }
}
