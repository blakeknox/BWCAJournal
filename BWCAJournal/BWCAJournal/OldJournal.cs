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
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Review previous entries" }
                }
            };
        }
    }
}
