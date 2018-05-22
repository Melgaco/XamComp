using SampleProject.TemplateClasses.CustomElements.PageSchema.Controls.Parallax.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleProject.TemplateClasses.CustomElements.PageSchema.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ParallaxPage : ContentPage
	{
		public ParallaxPage()
		{
			InitializeComponent();
            HeaderView.Children.Add(new Image() {
                Source = "bg_tree.jpg",
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            });

            MainStack.Children.Add(new Label() { Text = "TITULO", FontSize= 18, TextColor = Color.White });
            MainStack.Children.Add(new Label() { Text = "Subtítulo", FontSize = 12, TextColor = Color.White });

            stackBar.Children.Add(new Label() { Text = "stackBarContent", TextColor = Color.Black });

            for (int x = 0; x < 100; x++)
            {
                listLabel.Children.Add(new Label()
                {
                    Text = "CONTENT",
                    FontSize = 16
                });
            }

            MainScroll.ParallaxView = HeaderView;
        }
    }
}

#region code
/*Grid mainGrid = new Grid()
{
    RowDefinitions =
    {
        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
    },
};//OUTER GRID
    Grid headerView = new Grid()
    {
        RowSpacing = 0,
        ColumnSpacing = 0,
    };
        Image image = new Image()
{
    HorizontalOptions = LayoutOptions.FillAndExpand,
    VerticalOptions = LayoutOptions.FillAndExpand,
    Source = ImageSource.FromUri(new Uri("bg_tree.jpg")),
    Aspect = Aspect.AspectFill
};
        headerView.Children.Add(image);
mainGrid.Children.Add(headerView);

ParallaxControl mainScroll = new ParallaxControl();
    Grid grid = new Grid()
    {
        RowSpacing = 0,
        RowDefinitions =
        {
            new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
            new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
        },
    };
        Grid mainStack = new Grid()
{
    RowSpacing = 0,
    RowDefinitions =
    {
        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
    },
};
            StackLayout stack = new StackLayout()
{
    Padding = 16,
    Spacing = 0,
    VerticalOptions = LayoutOptions.End,
    HorizontalOptions = LayoutOptions.FillAndExpand,
};
            stack.Children.Add(new Label() { Text = "Efeito Parallax", FontSize = 18, TextColor = Color.White });
            stack.Children.Add(new Label() { Text = "Subtítulo", FontSize = 12, TextColor = Color.White });
        mainStack.Children.Add(stack);
    grid.Children.Add(mainStack);
    StackLayout stackLayout = new StackLayout()
    {

    };
    Grid.SetRow(stackLayout, 1);

mainGrid.Children.Add(headerView);

this.Content = mainGrid;*/
#endregion