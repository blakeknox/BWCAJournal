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
        
        DateTime enter;
        DateTime leave;
        public JournalEntry()
        {
            Title = "Journal Entry";
            
            Label Enter = new Label
            {
               // VerticalOptions = LayoutOptions.Center,
                //HorizontalOptions = LayoutOptions.Center,
                Text = "Choose and entry date",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            Label Exit = new Label
            {
                //VerticalOptions = LayoutOptions.Center,
                //HorizontalOptions = LayoutOptions.Center,
                Text = "Choose and exit date",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            Label  Comment = new Label
            {
                //VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Text = "Please enter your trip details below",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            DatePicker enterdate = new DatePicker
            {
                HorizontalOptions = LayoutOptions.Center,                                  
            };
            enterdate.PropertyChanged += Enterdate_PropertyChanged;
            enterdate.DateSelected += Enterdate_DateSelected;


            DatePicker exitdate = new DatePicker
            {
                HorizontalOptions = LayoutOptions.Center,
                               
            };
            exitdate.DateSelected += Exitdate_DateSelected;

            Editor journal = new Editor
            {
                Margin = new Thickness(5,0,5,0),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                
            };
            Button btnEnter = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                //Margin = new Thickness(0, 0, 0, 5),
                Text = "Save Journal Entry",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };
            btnEnter.Clicked += BtnEnter_Clicked;


            Content = new StackLayout
            {
                //HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Olive,
                Children = {
                    Enter,
                    enterdate,
                    Exit,
                    exitdate,
                    Comment,
                    journal,
                    btnEnter
                }
            };
        }

        private void Exitdate_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker exitdate = (DatePicker)sender;
            leave = exitdate.Date;
        }

        private void Enterdate_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker enterdate = (DatePicker)sender;
            enter = enterdate.Date;
        }        
        private void Enterdate_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //DatePicker enterdate = (DatePicker)sender;
            //enter = enterdate.Date;
        }

        private void BtnEnter_Clicked(object sender, EventArgs e)
        {
                //if (enter != null && leave != null )
                //{
                    
                //}    
        }
    }
}
