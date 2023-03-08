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
    public partial class Text : ContentPage
    {
        Editor editor;
        Label lbl,albl;
        public Text()
        {
            Button TagasiBtn = new Button
            {
                Text = "Tagasi",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            TagasiBtn.Clicked += TagasiBtn_Clicked;
            editor = new Editor
            {
                Placeholder="Kirjuta tekst",
                PlaceholderColor= Color.Black,
                BackgroundColor= Color.White,
                TextColor = Color.Black
            };
            editor.TextChanged += Editor_TextChanged;
            lbl = new Label
            {
                Text = "Siia tuleb ka tekst",
                BackgroundColor= Color.White,
                TextColor= Color.Black,
                FontSize= 24
            };
            albl = new Label
            {
                Text = "Siia tuleb A arv",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                FontSize = 24
            };
            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Gray,
                Children= {editor, lbl, albl, TagasiBtn}
            };
        }
        int i;
        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            //lbl.Text = editor.Text;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';
            if (key == 'A' || key=='a')
            {
                i++;
                albl.Text = key.ToString() + ": "+i.ToString();
            }
        }

        private async void TagasiBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}