using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21Link
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxViewPage : ContentPage
    {
        BoxView box;
        public BoxViewPage()
        {
            box = new BoxView()
            {
                Color= Color.Black,
                CornerRadius= 10,
                WidthRequest= 20,
                HeightRequest= 30,
                HorizontalOptions= LayoutOptions.Center,
                VerticalOptions= LayoutOptions.Center
            };
            TapGestureRecognizer tap= new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            Content= box;
        }

        Random rnd;
        int x = 10;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            rnd = new Random();
            box.Color= Color.FromRgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));
            //x += 10;
            //box.CornerRadius = x;
            box.WidthRequest = box.Width + 5;
            box.HeightRequest = box.Height + 10;
            box.Rotation += 5;
            //41
            try
            {
                Vibration.Vibrate();
                var a=TimeSpan.FromSeconds(0.5);
                Vibration.Vibrate();
            }
            catch (Exception)
            {
            }
        }
    }
}