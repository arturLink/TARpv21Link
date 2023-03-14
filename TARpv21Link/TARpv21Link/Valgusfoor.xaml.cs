using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21Link
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        Label redlbl, yellbl, grnlbl;
        Button valja, lulitada, paevrezim, oorezim;
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
            oorezim = new Button()
            {
                Text = "Öö rezim",
                BackgroundColor = Color.Gray,
                TextColor = Color.Black,
            };
            oorezim.Clicked += Oorezim_Clicked;
            paevrezim = new Button()
            {
                Text = "Päev rezim",
                BackgroundColor = Color.Gray,
                TextColor = Color.Black,
            };
            paevrezim.Clicked += Paevrezim_Clicked;
            st = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White,
                Children = { red, redlbl, yel, yellbl, grn, grnlbl, valja, lulitada, paevrezim, oorezim }
                
            };
            Content = st;
        }
        bool oorezimBL = false;
        bool paevrezimBL = false;
        bool onOff = false;
        private async void Oorezim_Clicked(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                await DisplayAlert("Tähelepanu", "Välgusfoor tuleb välja lülitada", "Ok");
            }
            else if (onOff == true)
            {
                paevrezimBL = false;
                oorezimBL = true;
                while (oorezimBL == true)
                {
                    red.Color = Color.Gray;
                    yel.Color = Color.Yellow;
                    grn.Color = Color.Gray;
                    if (oorezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                    await Task.Delay(1000);
                    red.Color = Color.Gray;
                    yel.Color = Color.Gray;
                    grn.Color = Color.Gray;
                    if (oorezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                    await Task.Delay(1000);
                }
            

            }
        }

        private async void Paevrezim_Clicked(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                await DisplayAlert("TÄHELEPANU", "Välgusfoor tuleb välja lülitada", "Ok");
            }
            else if (onOff == true)
            {
                oorezimBL = false;
                paevrezimBL = true;
                while (paevrezimBL == true)
                {
                    red.Color = Color.Red;
                    yel.Color = Color.Gray;
                    grn.Color = Color.Gray;
                    if (paevrezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                    await Task.Delay(5000);
                    red.Color = Color.Gray;
                    yel.Color = Color.Yellow;
                    grn.Color = Color.Gray;
                    if (paevrezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                    await Task.Delay(2000);
                    red.Color = Color.Gray;
                    yel.Color = Color.Gray;
                    grn.Color = Color.Green;
                    if (paevrezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                    await Task.Delay(5000);
                    red.Color = Color.Gray;
                    yel.Color = Color.Yellow;
                    grn.Color = Color.Gray;
                    if (paevrezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                    await Task.Delay(2000);
                    if (paevrezimBL == false)
                    {
                        red.Color = Color.DarkRed;
                        yel.Color = Color.Goldenrod;
                        grn.Color = Color.DarkGreen;
                        break;
                    }
                }
            
            }
        }

        private void Tapvalg_Tapped(object sender, EventArgs e)
        {
            oorezimBL = false;
            paevrezimBL = false;
            BoxView view_sender = (BoxView)sender;
            if (view_sender.Color == Color.DarkRed)
            {
                view_sender.Color = Color.Red;
            }
            else if (view_sender.Color == Color.Goldenrod)
            {
                view_sender.Color = Color.Yellow;
            }
            else if (view_sender.Color == Color.DarkGreen)
            {
                view_sender.Color = Color.Yellow;
            }
        }

        private void Lulitada_Clicked(object sender, EventArgs e)
        {
            onOff = true;
            oorezimBL = false;
            paevrezimBL = false;
            red.Color = Color.DarkRed;
            yel.Color = Color.Goldenrod;
            grn.Color = Color.DarkGreen;
            redlbl.Text = "Punane";
            yellbl.Text = "Kollane";
            grnlbl.Text = "Roheline";
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            onOff = false;
            oorezimBL = false;
            paevrezimBL = false;
            red.Color = Color.Gray;
            yel.Color = Color.Gray;
            grn.Color = Color.Gray;
            redlbl.Text = "Lülitage valgusfoor sisse";
            yellbl.Text = "Lülitage valgusfoor sisse";
            grnlbl.Text = "Lülitage valgusfoor sisse"; 
        }
    }
}