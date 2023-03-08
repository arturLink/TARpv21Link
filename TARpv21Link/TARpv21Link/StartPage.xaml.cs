using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21Link
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            Button TextBtn = new Button
            {
                Text= "Text Page",
                BackgroundColor= Color.White,
                TextColor= Color.Black,
            };
            Button TimerBtn = new Button
            {
                Text = "Timer Page",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            Button BoxBtn = new Button
            {
                Text = "Box Page",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            StackLayout st= new StackLayout 
            { 
                Orientation= StackOrientation.Vertical,
                BackgroundColor= Color.Gray,
                Children= {TextBtn,TimerBtn, BoxBtn}
            };
            Content= st;
            TextBtn.Clicked += TextBtn_Clicked;
            TimerBtn.Clicked += TimerBtn_Clicked;
            BoxBtn.Clicked += BoxBtn_Clicked;
        }

        private async void BoxBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxViewPage());
        }

        private async void TimerBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void TextBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Text());
        }
    }
}