using Newtonsoft.Json;
using SampleProject.TemplateClasses.CustomElements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleProject.TemplateClasses
{
    public partial class ListContent
    {
        Example example;
        bool isBusy = false;
        string _content = string.Empty;
        int _offset = 0;
        int _limit = 12;
        int linha = 0;
        int coluna = 0;
        Color _colorTxt = Color.Black;
        Color _colorBg = Color.White;
        bool _hasWebService;

        public ListContent(bool hasWebService = false, string serializedContent = "")
        {
            if (hasWebService)
            {
                _content = serializedContent;
            }
            _hasWebService = hasWebService;
        }

        private void MountExample(string serializedContent)
        {
            example = JsonConvert.DeserializeObject<Example>(_content);
        }

        public void LazyScroll(object sender, ScrolledEventArgs e)
        {

            var item = sender as ScrollView;

            if (item == null)
            {
                return;
            }

            var scrollingSpace = item.ContentSize.Height - item.Height;

            if (scrollingSpace <= e.ScrollY && !isBusy)
            {
                isBusy = true;
                MountExample(_content);
            }
        }

        public void LoadImage(List<LabeledImages> images, Grid grid, bool nameInnerTopImage, 
            bool nameInnerBottomImage, int linha, int coluna, Color textColor, Color bgColor)
        {
            foreach (var t in images)
            {
                Image image = new Image
                {
                    Aspect = Aspect.AspectFill,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Source = t.image.Source
                };

                grid.Children.Add(image);

                Grid.SetColumn(image, coluna);
                Grid.SetRow(image, linha);

                if (nameInnerTopImage || nameInnerBottomImage)
                {
                    Label label = new Label
                    {
                        Text = t.label.Text,
                        HorizontalOptions = LayoutOptions.FillAndExpand
                    };
                    if (bgColor == null)
                    {
                        label.BackgroundColor = _colorBg;
                    }
                    else
                    {
                        label.BackgroundColor = bgColor;
                    }
                    if (textColor == null)
                    {
                        label.TextColor = _colorTxt;
                    }
                    else
                    {
                        label.TextColor = textColor;
                    }

                    if (nameInnerTopImage)
                        label.VerticalOptions = LayoutOptions.Start;
                    else if (nameInnerBottomImage)
                        label.VerticalOptions = LayoutOptions.End;

                    grid.Children.Add(label);

                    Grid.SetColumn(label, coluna);
                    Grid.SetRow(label, linha);
                }
                //coluna = coluna == 2 ? 0 : coluna + 1;

                //if (coluna == 0)
                //    linha++;
            }
        }

        public async void Loading(Grid view)
        {
            isBusy = true;

            ActivityIndicator activityIndicator = new ActivityIndicator
            {
                IsRunning = isBusy
            };

            activityIndicator.BindingContext = this;
            activityIndicator.SetBinding(ActivityIndicator.IsVisibleProperty, "isBusy");
            activityIndicator.VerticalOptions = LayoutOptions.Center;
            activityIndicator.HorizontalOptions = LayoutOptions.Center;
            activityIndicator.Color = Color.Blue;


            view.Children.Add(activityIndicator);
            await Task.Delay(300);
            isBusy = false;
        }

        public async void Loading(StackLayout view)
        {
            isBusy = true;

            ActivityIndicator activityIndicator = new ActivityIndicator
            {
                IsRunning = isBusy
            };

            activityIndicator.BindingContext = this;
            activityIndicator.SetBinding(ActivityIndicator.IsVisibleProperty, "isBusy");
            activityIndicator.VerticalOptions = LayoutOptions.Center;
            activityIndicator.HorizontalOptions = LayoutOptions.Center;
            activityIndicator.Color = Color.Blue;


            view.Children.Add(activityIndicator);
            await Task.Delay(300);
            isBusy = false;
        }

        public async void Loading(AbsoluteLayout view)
        {
            isBusy = true;

            ActivityIndicator activityIndicator = new ActivityIndicator
            {
                IsRunning = isBusy
            };

            activityIndicator.BindingContext = this;
            activityIndicator.SetBinding(ActivityIndicator.IsVisibleProperty, "isBusy");
            activityIndicator.VerticalOptions = LayoutOptions.Center;
            activityIndicator.HorizontalOptions = LayoutOptions.Center;
            activityIndicator.Color = Color.Blue;

            view.Children.Add(activityIndicator);
            await Task.Delay(300);
            isBusy = false;
        }

        public ImageButton MountImageButton(string imgPath, double heightRequest, double widthRequest, Label imgLabel, 
            float CornerRadius, Color _OutlineColor, bool hasShadow = true)
        {
            var imageButton = new ImageButton
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = heightRequest,
                WidthRequest = widthRequest,
                HasShadow = hasShadow,
            };
            imageButton.GestureRecognizers.Add(new TapGestureRecognizer { NumberOfTapsRequired = 1 });

            imageButton.OutlineColor =
                _OutlineColor == null? _colorBg  : _OutlineColor;

            imageButton.grid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
                WidthRequest = widthRequest,
                HeightRequest = heightRequest,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            
            Image _image = new Image
            {
                Source = ImageSource.FromUri(new Uri(imgPath)),
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            if(imgLabel != null || imgLabel != new Label())
            {
                imageButton.innerElements = new InnerElementsImageButton()
                {
                    image = _image,
                    label = imgLabel,
                };                
                Grid.SetColumn(imageButton.innerElements.image, 0);
                Grid.SetRow(imageButton.innerElements.image, 0);
                Grid.SetColumn(imageButton.innerElements.label, 0);
                Grid.SetRow(imageButton.innerElements.label, 1);

                imageButton.grid.Children.Add(imageButton.innerElements.image);
                imageButton.grid.Children.Add(imageButton.innerElements.label);
            }
            else
            {
                imageButton.innerElements = new InnerElementsImageButton()
                {
                    image = _image,
                };                
                Grid.SetColumn(imageButton.innerElements.image, 0);
                imageButton.grid.Children.Add(imageButton.innerElements.image);
            }

            imageButton.Content = imageButton.grid;

            return imageButton;
        }

        public ImageHeader MountImageHeader(string overlapImagePath, double overlapWidth, double overlapHeight, 
            string bgImagePath, double bgWidth, double bgHeight, bool hasSearchBar = false)
        {
            ImageHeader imageHeader = new ImageHeader
            {
                grid = new Grid()
                {
                    RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                    ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
                }
            };

            Image _imageOver = new Image
            {
                Source = ImageSource.FromUri(new Uri(overlapImagePath)),
                WidthRequest = overlapWidth,
                HeightRequest = overlapHeight
            };
            Image _imageBg = new Image
            {
                Source = ImageSource.FromUri(new Uri(bgImagePath)),
                WidthRequest = bgWidth,
                HeightRequest = bgHeight
            };

            imageHeader.innerElements = new InnerElementsImageHeader
            {
                imageOverlay = _imageOver,
                imageBackground = _imageBg
            };
            //SETS OVERLAP
            imageHeader.innerElements.imageOverlay.HorizontalOptions = LayoutOptions.Center;
            imageHeader.innerElements.imageOverlay.Aspect = Aspect.AspectFill;

            //SETS BACKGROUND
            imageHeader.innerElements.imageBackground.HorizontalOptions = LayoutOptions.FillAndExpand;
            imageHeader.innerElements.imageBackground.Aspect = Aspect.AspectFill;

            if (hasSearchBar)
            {
                imageHeader.innerElements.searchBar = new SearchBar()
                {
                    Placeholder = "",
                };
            }
            imageHeader.grid.Children.Add(imageHeader.innerElements.imageBackground);
            imageHeader.grid.Children.Add(imageHeader.innerElements.imageOverlay);

            Grid.SetColumn(imageHeader.innerElements.imageOverlay, 0);
            Grid.SetColumn(imageHeader.innerElements.imageBackground, 0);

            Grid.SetRow(imageHeader.innerElements.imageOverlay, 0);
            Grid.SetRow(imageHeader.innerElements.imageBackground, 0);

            imageHeader.Content = imageHeader.grid;

            return imageHeader;
        }

        public FooterLogo MountFooterLogo(List<string> logoImagesPaths)
        {
            List<Image> _logos = new List<Image>();
            foreach(var logoPath in logoImagesPaths)
            {
                _logos.Add(
                    new Image()
                    {
                        Source = ImageSource.FromUri(new Uri(logoPath))
                    });
            }

            FooterLogo footerLogo = new FooterLogo
            {
                logos = _logos,

                //DEFINIÇÃO DE LINHA
                grid = new Grid()
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                }
            };

            //DEFINIÇÕES DE COLUNAS
            footerLogo.grid.ColumnDefinitions = new ColumnDefinitionCollection();
            foreach (var logoPaths in logoImagesPaths)
            {
                footerLogo.grid.ColumnDefinitions
                    .Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            int colunaFooter = 0;
            foreach (var fl in _logos)
            {
                footerLogo.grid.Children.Add(fl);
                Grid.SetColumn(fl, colunaFooter);
                colunaFooter++;
            }

            footerLogo.Content = footerLogo.grid;
            return footerLogo;
        }

    }
}
