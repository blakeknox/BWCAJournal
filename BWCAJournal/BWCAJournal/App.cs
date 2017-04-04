using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BWCAJournal
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "BWCAJournal",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Your BWCA Trip Log!"
                        },
                        new Button
                        {
                          HorizontalOptions = LayoutOptions.Center,
                          Text = "New Journal Entry"
                        },
                        new Button
                        {
                            HorizontalOptions = LayoutOptions.Center,
                          Text = "Veiw Previous Journal Entry"

                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
