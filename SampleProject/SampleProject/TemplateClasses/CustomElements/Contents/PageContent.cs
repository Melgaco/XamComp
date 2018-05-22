using SampleProject.TemplateClasses.CustomElements.PageElements;
using SampleProject.TemplateClasses.CustomElements.PageElements.InnerElements;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleProject.TemplateClasses.CustomElements.Contents
{
    public partial class ListContent
    {
        Image _image;
        double _heightRequest = 16;
        double _widthRequest = 16;

        //public RoundedEntry MountRoundedEntry(Entry entry, string pathImage, float cornerRadius, LayoutOptions verticalLayoutOptions, LayoutOptions horizontalLayoutOptions, 
        //    double heightRequestImage = -1, double widthRequestImage = -1, int columnImage = 1)
        //{
        //    RoundedEntry roundedEntry = new RoundedEntry()
        //    {
        //        grid = new Grid()
        //        {
        //            RowDefinitions =
        //        {
        //            new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
        //        },
        //            ColumnDefinitions =
        //        {
        //            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
        //            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) }
        //        },
        //            VerticalOptions = verticalLayoutOptions,
        //            HorizontalOptions = horizontalLayoutOptions
        //        },
        //        innerElements = new InnerElementsRoundedEntry(),
        //    };

        //    //initialize elem
        //    roundedEntry.innerElements.image = new Image();
        //    roundedEntry.innerElements.entry = new Entry();


        //    if (!pathImage.Equals(""))
        //    {

        //        _image = new Image()
        //        {
        //            Source = ImageSource.FromUri(new Uri(pathImage)),
        //            Aspect = Aspect.AspectFill,
        //            HeightRequest = widthRequestImage < 0 ? _widthRequest : widthRequestImage,
        //            WidthRequest = heightRequestImage < 0 ? _heightRequest : heightRequestImage,
        //            HorizontalOptions = LayoutOptions.Center,
        //            VerticalOptions = LayoutOptions.Center
        //        };
        //        roundedEntry.innerElements.image = _image;
                
        //        switch (columnImage)
        //        {
        //            case 0:
        //                Grid.SetColumn(roundedEntry.innerElements.entry, columnImage + 1);
        //                Grid.SetColumn(roundedEntry.innerElements.image, columnImage);
        //                break;
        //            default:
        //                columnImage = 1;
        //                Grid.SetColumn(roundedEntry.innerElements.entry, columnImage - 1);
        //                Grid.SetColumn(roundedEntry.innerElements.image, columnImage);
        //                break;
        //        }

        //        roundedEntry.grid.Children.Add(roundedEntry.innerElements.image);
        //    }
            
        //    roundedEntry.innerElements.entry = entry;
        //    roundedEntry.CornerRadius = cornerRadius;

        //    roundedEntry.grid.Children.Add(roundedEntry.innerElements.entry);
            
        //    roundedEntry.Content = roundedEntry.grid;

        //    return roundedEntry;
        //}


    }
}
