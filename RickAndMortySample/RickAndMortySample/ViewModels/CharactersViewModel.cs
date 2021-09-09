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
    public class CharactersViewModel : BindableBase
    {
        private readonly RickAndMortyService rickAndMortyService = new RickAndMortyService();

        private IEnumerable<Character> characters;
        public IEnumerable<Character> Characters
        {
            get => characters;
            set
            {
                characters = value;
                OnPropertyChanged();
            }
        }

        private Character selectedCharacter;
        public Character SelectedCharacter
        {
            get => selectedCharacter;
            set
            {
                selectedCharacter = value;
                OnPropertyChanged();
                NavigateToCharacterDetail();
            }
        }

        public CharactersViewModel()
        {
            FetchAsync();
        }

        private async void FetchAsync()
        {
            Characters = await rickAndMortyService.GetCharactersAsync();
        }

        private async void NavigateToCharacterDetail()
        {
            if (selectedCharacter == null)
            {
                return;
            }

            await App.Current.MainPage.DisplayAlert("Nice!!", $"You select {selectedCharacter.Name}", "Close");

            SelectedCharacter = null;
        }
    }
}
