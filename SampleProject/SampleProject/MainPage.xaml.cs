using SampleProject.TemplateClasses;
using SampleProject.TemplateClasses.CustomElements;
using SampleProject.TemplateClasses.CustomElements.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleProject
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var listContent = new ListContent();
            #region testElements
            /*//TESTING IMAGEBUTTON
            var imageButton = listContent.MountImageButton("https://www.al-murad.co.uk/3805/gloss-black-square-48cm-x-48cm-wall-mosaic.jpg", 108, 108, new Label(), 0, Color.Black);
            MainGrid.Children.Add(imageButton);*/
            /*//TESTING IMAGEHEADER
            var imageHeader = listContent.MountImageHeader("http://curiosamente.diariodepernambuco.com.br/wp-content/uploads/2017/08/banana.png",200 ,200, "https://www.al-murad.co.uk/3805/gloss-black-square-48cm-x-48cm-wall-mosaic.jpg", 400, 400);
            MainGrid.Children.Add(imageHeader);*/
            /*//TESTING FOOTERLOGO
            List<string> footerList = new List<string>()
            {
                "http://curiosamente.diariodepernambuco.com.br/wp-content/uploads/2017/08/banana.png",
                "https://www.al-murad.co.uk/3805/gloss-black-square-48cm-x-48cm-wall-mosaic.jpg"
            };
            var fl = listContent.MountFooterLogo(footerList);
            MainGrid.Children.Add(fl);*/

            //TESTING ROUNDED ENTRY
            /*var roundedEntry = listContent.MountRoundedEntry(
                new Entry() { WidthRequest = 200  }, "https://image.flaticon.com/icons/png/16/34/34202.png",
                100, LayoutOptions.Center, LayoutOptions.Center);

            MainGrid.Children.Add(roundedEntry);*/
            #endregion



        }

    }
}
