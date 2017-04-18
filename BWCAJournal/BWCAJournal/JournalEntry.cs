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
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Journal Entry" }
                }
            };
        }
    }
}
