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
                ShowAlert();
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

        private async void ShowAlert()
        {
            if (SelectedEpisode == null)
            {
                return;
            }

            await App.Current.MainPage.DisplayAlert("Nice!!", $"You tap {selectedEpisode.episode} {selectedEpisode.Name}", "Close");

            SelectedEpisode = null;
        }
    }
}
