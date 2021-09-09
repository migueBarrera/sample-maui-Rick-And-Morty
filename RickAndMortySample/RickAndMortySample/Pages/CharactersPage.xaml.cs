using RickAndMortySample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.Pages
{
    public partial class CharactersPage
    {
        public CharactersPage()
        {
            InitializeComponent();

            this.BindingContext = new CharactersViewModel();
        }
    }
}