using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using RickAndMortySample.Pages;
using Application = Microsoft.Maui.Controls.Application;

namespace RickAndMortySample
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new RAMTabbedPage();
		}
	}
}
