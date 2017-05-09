using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BWCAJournal
{
    public class JournalEntry : ContentPage
    {
        public JournalEntry()
        {
            Padding = new Thickness(10);
            Label Title = new Label
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Enter a New Journal Entry",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            
            
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Olive,
                Children = {
                    Title
                }
            };
        }
    }
}
