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
        List<ContentPage> cntPages = new List<ContentPage>() { new Text(), new TimerPage(), new BoxViewPage(), new Valgusfoor(),
            new StepperSliderPage(), new RgbPage()};
        List<string> tekstid = new List<string> { "Text Page", "Timer Page", "Box Page", "Valgusfoor Page", "Stepper Slider Page", "RGB Page" };
        public StartPage()
        {
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Gray,
            };
            for (int i = 0; i < cntPages.Count; i++)
            {
                Button btn = new Button
                {
                    Text = tekstid[i],
                    TabIndex= i,
                    BackgroundColor= Color.White,
                    TextColor= Color.Black,
                };
                btn.Clicked += NavigFunktsioon;
                st.Children.Add(btn);
            }
            Content = st;
        }

        private async void NavigFunktsioon(object sender, EventArgs e)
        {
            Button bSender = (Button)sender;
            await Navigation.PushAsync(cntPages[bSender.TabIndex]);
        }
    }
}