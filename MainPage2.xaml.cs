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
    public partial class MainPage2 : ContentPage
   
        private string[] _brailleletters = new string[]
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
            };    // Braille alfabesinin resim dosya uzantıları

        public void imagename(int a)
        {
            brailleimages.Source = _brailleletters[a];  // switch case içerisine eklenecek, Brailler fotoğraf adresi functionu
        }


        public MainPage2()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (textalani.Text)
            {
                case "a":
                case "A":
                    imagename(0); // _brailleletters dizisinin ilk elemanı
                    break;
                case "b":
                case "B":
                    imagename(1);
                    break;
                case "c":
                case "C":
                    imagename(2);
                    break;
                case "d":
                case "D":
                    imagename(3);
                    break;
                case "e":
                case "E":
                    imagename(4);
                    break;
                case "f":
                case "F":
                    imagename(5);
                    break;
                case "g":
                case "G":
                    imagename(6);
                    break;
                case "h":
                case "H":
                    imagename(7);
                    break;
                case "ı":
                case "I":
                    imagename(8);
                    break;
                case "j":
                case "J":
                    imagename(9);
                    break;
                case "k":
                case "K":
                    imagename(10);
                    break;
                case "l":
                case "L":
                    imagename(11);
                    break;
                case "m":
                case "M":
                    imagename(12);
                    break;
                case "n":
                case "N":
                    imagename(13);
                    break;
                case "o":
                case "O":
                    imagename(14);
                    break;
                case "p":
                case "P":
                    imagename(15);
                    break;
                case "q":
                case "Q":
                    imagename(16);
                    break;
                case "r":
                case "R":
                    imagename(17);
                    break;
                case "s":
                case "S":
                    imagename(18);
                    break;
                case "t":
                case "T":
                    imagename(19);
                    break;
                case "u":
                case "U":
                    imagename(20);
                    break;
                case "v":
                case "V":
                    imagename(21);
                    break;
                case "w":
                case "W":
                    imagename(22);
                    break;
                case "x":
                case "X":
                    imagename(23);
                    break;
                case "y":
                case "Y":
                    imagename(24);
                    break;
                case "z":
                case "Z":
                    imagename(25);
                    break;

                default:
                    DisplayAlert("UYARI", "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }
        }
    }
}
