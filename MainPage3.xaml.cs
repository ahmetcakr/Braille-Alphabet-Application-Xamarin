using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrailleUygulamasi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage3 : ContentPage
    {
        public MainPage3()
        {
            InitializeComponent();
        }

        int b1, b2, b3, b4, b5, b6;



        private void Button_1(object sender, EventArgs e)
        {

            if (color_1.BackgroundColor == Color.Black && b1 == 1)
            {
                color_1.BackgroundColor = Color.LightGray;
                b1 = 0;
            }
            else
            {
                color_1.BackgroundColor = Color.Black;
                b1 = 1;
            }

        }

        private void Button_Temizle(object sender, EventArgs e)
        {
            color_1.BackgroundColor = Color.LightGray;
            color_2.BackgroundColor = Color.LightGray;
            color_3.BackgroundColor = Color.LightGray;
            color_4.BackgroundColor = Color.LightGray;
            color_5.BackgroundColor = Color.LightGray;
            color_6.BackgroundColor = Color.LightGray;

            b1 = 0;
            b2 = 0;
            b3 = 0;
            b4 = 0;
            b5 = 0;
            b6 = 0;
        }

        private void Button_Goster(object sender, EventArgs e)
        {
            if (b2 == 1 && b1 == 0 && b3 == 0 && b4 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " A HARFİ ", "OK");

            }
            if (b2 == 1 && b4 == 1 && b1 == 0 && b3 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " B HARFİ ", "OK");

            }
            else if (b2 == 1 && b1 == 1 && b3 == 0 && b4 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " C HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b3 == 1 && b4 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " D HARFİ ", "OK");
            }
            else if (b2 == 1 && b3 == 1 && b1 == 0 && b4 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " E HARFİ ", "OK");
            }
            else if (b2 == 1 && b4 == 1 && b1 == 1 && b3 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " F HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b3 == 1 && b4 == 1 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " G HARFİ ", "OK");
            }
            else if (b2 == 1 && b3 == 1 && b4 == 1 && b1 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " H HARFİ ", "OK");
            }
            else if (b4 == 1 && b1 == 1 && b2 == 0 && b3 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " I HARFİ ", "OK");
            }
            else if (b4 == 1 && b1 == 1 && b3 == 1 && b2 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " J HARFİ ", "OK");
            }
            else if (b6 == 1 && b2 == 1 && b1 == 0 && b3 == 0 && b4 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " K HARFİ ", "OK");
            }
            else if (b2 == 1 && b4 == 1 && b6 == 1 && b1 == 0 && b3 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " L HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b6 == 1 && b3 == 0 && b4 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " M HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b3 == 1 && b6 == 1 && b4 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " N HARFİ ", "OK");
            }
            else if (b2 == 1 && b3 == 1 && b6 == 1 && b1 == 0 && b4 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " O HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b4 == 1 && b6 == 1 && b3 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " P HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b3 == 1 && b4 == 1 && b6 == 1 && b5 == 0)
            {
                DisplayAlert("Göster", " Q HARFİ ", "OK");
            }
            else if (b2 == 1 && b4 == 1 && b3 == 1 && b6 == 1 && b1 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " R HARFİ ", "OK");
            }
            else if (b2 == 1 && b4 == 1 && b1 == 1 && b3 == 0 && b5 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " S HARFİ ", "OK");
            }
            else if (b4 == 1 && b1 == 1 && b3 == 1 && b6 == 1 && b2 == 0 && b5 == 0)
            {
                DisplayAlert("Göster", " T HARFİ ", "OK");
            }
            else if (b2 == 1 && b5 == 1 && b6 == 1 && b1 == 0 && b3 == 0 && b4 == 0)
            {
                DisplayAlert("Göster", " U HARFİ ", "OK");
            }
            else if (b2 == 1 && b4 == 1 && b6 == 1 && b5 == 1 && b1 == 0 && b3 == 0)
            {
                DisplayAlert("Göster", " V HARFİ ", "OK");
            }
            else if (b4 == 1 && b1 == 1 && b3 == 1 && b5 == 1 && b2 == 0 && b6 == 0)
            {
                DisplayAlert("Göster", " W HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b5 == 1 && b6 == 1 && b3 == 0 && b4 == 0)
            {
                DisplayAlert("Göster", " X HARFİ ", "OK");
            }
            else if (b2 == 1 && b1 == 1 && b3 == 1 && b5 == 1 && b6 == 1 && b4 == 0)
            {
                DisplayAlert("Göster", " Y HARFİ ", "OK");
            }
            else if (b2 == 1 && b5 == 1 && b3 == 1 && b6 == 1 && b1 == 0 && b4 == 0)
            {
                DisplayAlert("Göster", " Z HARFİ ", "OK");
            }
        }

        private void Button_2(object sender, EventArgs e)
        {


            if (color_2.BackgroundColor == Color.Black && b2 == 1)
            {
                color_2.BackgroundColor = Color.LightGray;
                b2 = 0;
            }
            else
            {
                color_2.BackgroundColor = Color.Black;
                b2 = 1;
            }
        }

        private void Button_3(object sender, EventArgs e)
        {

            if (color_3.BackgroundColor == Color.Black && b3 == 1)
            {
                color_3.BackgroundColor = Color.LightGray;
                b3 = 0;
            }
            else
            {
                color_3.BackgroundColor = Color.Black;
                b3 = 1;

            }
        }

        private void Button_4(object sender, EventArgs e)
        {

            if (color_4.BackgroundColor == Color.Black && b4 == 1)
            {
                color_4.BackgroundColor = Color.LightGray;
                b4 = 0;
            }
            else
            {
                color_4.BackgroundColor = Color.Black;
                b4 = 1;

            }
        }

        private void Button_5(object sender, EventArgs e)
        {

            if (color_5.BackgroundColor == Color.Black && b5 == 1)
            {
                color_5.BackgroundColor = Color.LightGray;
                b5 = 0;
            }
            else
            {
                color_5.BackgroundColor = Color.Black;
                b5 = 1;

            }
        }

        private void Button_6(object sender, EventArgs e)
        {

            if (color_6.BackgroundColor == Color.Black && b6 == 1)
            {
                color_6.BackgroundColor = Color.LightGray;
                b6 = 0;
            }
            else
            {
                color_6.BackgroundColor = Color.Black;
                b6 = 1;

            }
        }


    }
}