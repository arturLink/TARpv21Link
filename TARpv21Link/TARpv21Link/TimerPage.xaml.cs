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
    public partial class TimerPage : ContentPage
    {
        public TimerPage()
        {
            InitializeComponent();
        }
        bool onoff = false;
        private async void NaitaAeg()
        {
            while (onoff == false)
            {
                lbl.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NaitaAeg();

        }
    }
}