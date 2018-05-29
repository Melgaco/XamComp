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
	public partial class LoginPage_2 : ContentPage
	{
		public LoginPage_2 ()
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
            var btn = centerView.Children.OfType<Grid>().First().Children.OfType<Button>().First();

            btn.BackgroundColor = Color.FromHex("#9CCC65");
        }
	}
}