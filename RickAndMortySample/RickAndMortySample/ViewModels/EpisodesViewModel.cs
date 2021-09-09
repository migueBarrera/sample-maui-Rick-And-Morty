using RickAndMortySample.Models;
using RickAndMortySample.Pages;
using RickAndMortySample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.ViewModels
{
    public class EpisodesViewModel : BindableBase
    {
        private readonly RickAndMortyService episodesService = new RickAndMortyService();

        private IEnumerable<Episode> episodes;
        public IEnumerable<Episode> Episodes
        {
            get => episodes;
            set
            {
                episodes = value;
                OnPropertyChanged();
            }
        }

        private Episode selectedEpisode;
        public Episode SelectedEpisode 
        {
            get => selectedEpisode;
            set
            {
                selectedEpisode = value;
                OnPropertyChanged();
                NavigateToEpisode();
            } 
        }

        public EpisodesViewModel()
        {
            FetchAsync();
        }

        private async void FetchAsync()
        {
            Episodes = await episodesService.GetEpisodesAsync();
        }

        private void NavigateToEpisode()
        {
            if (SelectedEpisode == null)
            {
                return;
            }

            //App.Current.MainPage.Navigation.PushAsync(new EpisodeDetailPage(selectedEpisode));

            SelectedEpisode = null;
        }
    }
}
