using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace TARpv21Link
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RgbPage : ContentPage
    {
        Random rnd = new Random();
        Label rlbl, glbl, blbl;
        Slider r, g, b;
        Slider rgb;
        BoxView rgbBox;
        List<Slider> sliders = new List<Slider>() { new Slider(), new Slider(), new Slider() };
        public RgbPage()
        {
            List<Object> objects = new List<Object>() { };


            rgbBox = new BoxView()
            {
                Color = Color.FromRgb(2, 102, 202),
                CornerRadius = 10,
                WidthRequest = 400,
                HeightRequest = 270,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            objects.Add(rgbBox);

            rlbl = new Label()
            {
                Text = "Red",
                TextColor= Color.Black,
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            objects.Add(rlbl);

            r = new Slider()
            {
                Minimum = 0,
                Maximum = 255,
                Value = rnd.Next(255),
                MinimumTrackColor = Color.Gray,
                MaximumTrackColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center
            };
            r.ValueChanged += rgbValue;
            objects.Add(r);

            glbl = new Label()
            {
                Text = "Green",
                TextColor = Color.Black,
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            objects.Add(glbl);

            g = new Slider()
            {
                Minimum = 0,
                Maximum = 255,
                Value = rnd.Next(255),
                MinimumTrackColor = Color.Gray,
                MaximumTrackColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center
            };
            g.ValueChanged += rgbValue;
            objects.Add(g);

            blbl = new Label()
            {
                Text = "Blue",
                TextColor = Color.Black,
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            objects.Add(blbl);

            b = new Slider()
            {
                Minimum = 0,
                Maximum = 255,
                Value = rnd.Next(255),
                MinimumTrackColor = Color.Gray,
                MaximumTrackColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center
            };
            b.ValueChanged += rgbValue;
            objects.Add(b);
            AbsoluteLayout abs = new AbsoluteLayout();
            double y = 0;
            foreach (var item in objects)
            {
                y = y + 0.2;
                AbsoluteLayout.SetLayoutBounds((BindableObject)item, new Rectangle(0.1, y, 400, 500));
                AbsoluteLayout.SetLayoutFlags((BindableObject)item, AbsoluteLayoutFlags.PositionProportional);
                abs.Children.Add((View)item);
            }
            Content = abs;
        }

        private void rgbValue(object sender, ValueChangedEventArgs e)
        {
            Slider slSender = sender as Slider;
            if (slSender == r)
            {
                rlbl.Text = String.Format("Red = {0:X2}", (int)e.NewValue);
            }
            else if (slSender == g)
            {
                glbl.Text = String.Format("Green = {0:X2}", (int)e.NewValue);
            }
            else if (slSender == b)
            {
                blbl.Text = String.Format("Blue = {0:X2}", (int)e.NewValue);
            }
            rgbBox.Color = Color.FromRgb((int)r.Value,(int)g.Value,(int)b.Value);
        }
    }
}