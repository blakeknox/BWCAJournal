using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BWCAJournal
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Button PrevEntry = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "View Previous Journal Entry",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            PrevEntry.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new OldJournal());
            };

            Button NewEntry = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "New Journal Entry",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            NewEntry.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new JournalEntry());
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Home Page" },
                    PrevEntry,
                    NewEntry
                }
            };
        }
    }
}
