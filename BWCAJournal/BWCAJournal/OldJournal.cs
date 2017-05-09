using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BWCAJournal
{
    public class OldJournal : ContentPage
    {
        public OldJournal()
        {
            Label Title = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Review Your Old Jounrnal Entries",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            Content = new StackLayout
            {
                BackgroundColor = Color.Olive,
                Children = {
                    Title
                }
            };
        }
    }
}
