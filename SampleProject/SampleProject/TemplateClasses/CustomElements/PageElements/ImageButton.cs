using SampleProject.TemplateClasses.CustomElements.PageElements.InnerElements;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleProject.TemplateClasses.CustomElements.PageElements
{
    public class ImageButton : Frame
    {
        public Grid grid { get; set; }
        public InnerElementsImageButton innerElements { get; set; }
    }
}
