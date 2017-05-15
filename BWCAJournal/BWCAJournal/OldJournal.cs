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
            Title = "Journal Entries";

            Label message = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Review Your Old Jounrnal Entries",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            //ListView entries = new ListView
            //{

            //};

            Content = new StackLayout
            {
                BackgroundColor = Color.Olive,
                Children = {
                    message
                }
            };
        }
    }
}
