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
    public partial class Valgusfoor : ContentPage
    {
        Label redlbl, yellbl, grnlbl;
        Button valja, lulitada;
        BoxView red, yel, grn;
        StackLayout st;
        public Valgusfoor()
        {
            ////////boxview/////////
            red = new BoxView()
            {
                Color = Color.Gray,
                CornerRadius = 70,
                WidthRequest = 140,
                HeightRequest = 140,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            TapGestureRecognizer tapred = new TapGestureRecognizer();
            tapred.Tapped += Tapvalg_Tapped; 
            red.GestureRecognizers.Add(tapred);
            redlbl = new Label()
            {
                Text = "Lülitage valgusfoor sisse",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            yel = new BoxView()
            {
                Color = Color.Gray,
                CornerRadius = 70,
                WidthRequest = 140,
                HeightRequest = 140,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            TapGestureRecognizer tapyel = new TapGestureRecognizer();
            tapyel.Tapped += Tapvalg_Tapped;
            yel.GestureRecognizers.Add(tapyel);
            yellbl = new Label()
            {
                Text = "Lülitage valgusfoor sisse",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            grn = new BoxView()
            {
                Color = Color.Gray,
                CornerRadius = 70,
                WidthRequest = 140,
                HeightRequest = 140,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            TapGestureRecognizer tapgrn = new TapGestureRecognizer();
            tapgrn.Tapped += Tapvalg_Tapped;
            red.GestureRecognizers.Add(tapgrn);
            grnlbl = new Label()
            {
                Text = "Lülitage valgusfoor sisse",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            ////////buttons/////////
            valja = new Button()
            {
                Text = "Välja",
                BackgroundColor = Color.Gray,
                TextColor = Color.Black,
            };
            valja.Clicked += Valja_Clicked;
            lulitada = new Button()
            {
                Text = "Lüllitada",
                BackgroundColor = Color.Gray,
                TextColor = Color.Black,
            };
            lulitada.Clicked += Lulitada_Clicked;
            st = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White,
                Children = { red, redlbl, yel, yellbl, grn, grnlbl, valja, lulitada }
                
            };
            Content = st;
        }

        private void Tapvalg_Tapped(object sender, EventArgs e)
        {
            BoxView viev_sender = (BoxView)sender;
            if (viev_sender.Color == Color.DarkRed)
            {
                viev_sender.Color = Color.Red;
            }
            else if (viev_sender.Color == Color.Goldenrod)
            {
                viev_sender.Color = Color.Yellow;
            }
            else if (viev_sender.Color == Color.DarkGreen)
            {
                grn.Color = Color.GreenYellow;
            }
        }

        private void Lulitada_Clicked(object sender, EventArgs e)
        {
            red.Color = Color.DarkRed;
            yel.Color = Color.Goldenrod;
            grn.Color = Color.DarkGreen;
            redlbl.Text = "Punane";
            yellbl.Text = "Kollane";
            grnlbl.Text = "Roheline";
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            red.Color = Color.Gray;
            yel.Color = Color.Gray;
            grn.Color = Color.Gray;
            redlbl.Text = "Lülitage valgusfoor sisse";
            yellbl.Text = "Lülitage valgusfoor sisse";
            grnlbl.Text = "Lülitage valgusfoor sisse"; 
        }
    }
}