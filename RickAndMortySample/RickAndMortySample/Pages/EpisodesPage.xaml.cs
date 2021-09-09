using RickAndMortySample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.Pages
{
    public partial class EpisodesPage
    {
        public EpisodesPage()
        {
            InitializeComponent();

            this.BindingContext = new EpisodesViewModel();
        }
    }
}