using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BrailleUygulamasi
{
    public partial class MainPage : ContentPage
    {
        private int _index = 0;  // Dizilerin içinde sürekli artacak değer.

        private string[] _quotes = new string[]
        {
            " A HARFİ ",
            " B HARFİ ",
            " C HARFİ ",
            " D HARFİ ",
            " E HARFİ ",
            " F HARFİ ",
            " G HARFİ ",
            " H HARFİ ",
            " I HARFİ ",
            " J HARFİ ",
            " K HARFİ ",
            " L HARFİ ",
            " M HARFİ ",
            " N HARFİ ",
            " O HARFİ ",
            " P HARFİ ",
            " Q HARFİ ",
            " R HARFİ ",
            " S HARFİ ",
            " T HARFİ ",
            " U HARFİ ",
            " V HARFİ ",
            " W HARFİ ",
            " X HARFİ ",
            " Y HARFİ ",
            " Z HARFİ ",

        };   // Harf Dizisi

        private string[] _images = new string[]
        {
             "A.png",
             "B.png",
             "C.png",
             "D.png",
             "E.png",
             "F.png",
             "G.png",
             "H.png",
             "i.png",
             "J.png",
             "K.png",
             "L.png",
             "M.png",
             "N.png",
             "O.png",
             "P.png",
             "Q.png",
             "R.png",
             "S.png",
             "T.png",
             "U.png",
             "V.png",
             "W.png",
             "X.png",
             "Y.png",
             "Z.png"
        };   // Harflerin image Dizisi


        public MainPage()
        {
            InitializeComponent();

            currentQuote.Text = _quotes[_index];    // Anlık harf kaynağı için oluşturulan değişken ve harf dizisine eşitlendi.

            imageList.Source = _images[_index];     // Braille alfabesi fotoğraflarının kaynağı ve images dizisine eşitlendi.

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _index++;

            if (_index >= _quotes.Length)         // index'in sayısı harf dizisinin toplam veri sayısını geçerse aşağıdakileri uygula. 

                _index = 0;

            currentQuote.Text = _quotes[_index];
            imageList.Source = _images[_index];
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {



            if (_index < _quotes.Length)
            {            // eğer index sayısı harf dizisinin toplam veri sayısının altındaysa bunları uygula.

                _index--;

                /* if (_index==0)
                 { 
                     DisplayAlert("UYARI","Ilk Harfe Geri Döndünüz.\nLütfen 'Next' Butonu Ile Devam Ediniz. ","OK");
                     // ilk harfe geldiğince çalışan uyarı
                 }*/

                if (_index < 0)
                {
                    _index = 25;        // A dan Z ye geri döndürme
                }


                currentQuote.Text = _quotes[_index];
                imageList.Source = _images[_index];



            }

        }

        private void Button_Clicked_2(object sender, EventArgs e)   // Braille alfabesi nedir butonu
        {
            DisplayAlert("Braille Alfabesi", "Braille alfabesi veya Körler alfabesi;\n\n" +
                " 1821 yılında Louis Braille tarafından geliştirilmiş görme engelli insanların okuyup yazması için kullanılan bir alfabe yöntemidir.\n" +
                " İki kolon taşıyan dikdörtgen düzen üzerine dizilmiş altı kabartılmış noktadan oluşur. \n" +
                "Her iki kolonda üçer nokta bulunur. Noktalardan her biri altmışdört farklı kombinasyondan birini oluşturması için farklı şekillerde dizilir. ", "OK");
        }
    }
}

