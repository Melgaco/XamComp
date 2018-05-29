using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleProject.TemplateClasses.CustomElements.PageSchema.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

            var metrics = DeviceDisplay.ScreenMetrics;

            centerView.RowDefinitions = new RowDefinitionCollection()
            {
                new RowDefinition { Height = new GridLength(metrics.Height/3, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(metrics.Height/3, GridUnitType.Auto) },
                new RowDefinition { Height = new GridLength(metrics.Height/3, GridUnitType.Star) },
            };

            imageLogo.Source = "logo.png";//your logo name here
            imageLogo.HeightRequest = 144;//Your image height here

        }
	}
}