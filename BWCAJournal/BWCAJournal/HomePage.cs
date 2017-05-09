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
            
            BackgroundColor = Color.Olive;
            
            Button PrevEntry = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                Text = "View Previous Journal Entry",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button))
            };
            PrevEntry.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new OldJournal());
            };

            Button NewEntry = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                Text = "New Journal Entry",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button))
            };
            NewEntry.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new JournalEntry());
            };

            Label Title = new Label {
                BackgroundColor = Color.Navy,
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Home Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            Image back = new Image
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Source = ImageSource.FromResource("BWCAJournal.backimg.jpg")
            };
            
            Content = new StackLayout
            {
                
                Children = {
                    Title,
                    back,
                    PrevEntry,
                    NewEntry
                }
            };
        }
    }
}
