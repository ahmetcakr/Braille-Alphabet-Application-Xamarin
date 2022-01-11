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
    public partial class MainPage4 : ContentPage
    {
        
        private string[] _harfler = new string[]
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
        };

        private string[] _harfimages = new string[]
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
           };


        public MainPage4()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            /*if (kelimealani.Text == "selam" || kelimealani.Text=="Selam" || kelimealani.Text == "SELAM")
            {
                brailleimages01.Source = "S.png";
                brailleimages02.Source = "E.png";
                brailleimages03.Source = "L.png";
                brailleimages04.Source = "A.png";
                brailleimages05.Source = "M.png";
            }
            */

            switch (kelimealani.Text[0])
            {
                case 'a':
                case 'A':
                    brailleimages01.Source = "A.png";
                    break;

                case 'b':
                case 'B':
                    brailleimages01.Source = "B.png";
                    break;
                case 'c':
                case 'C':
                    brailleimages01.Source = "C.png";
                    break;
                case 'd':
                case 'D':
                    brailleimages01.Source = "D.png";
                    break;
                case 'e':
                case 'E':
                    brailleimages01.Source = "E.png";
                    break;
                case 'f':
                case 'F':
                    brailleimages01.Source = "F.png";
                    break;
                case 'g':
                case 'G':
                    brailleimages01.Source = "G.png";
                    break;
                case 'h':
                case 'H':
                    brailleimages01.Source = "H.png";
                    break;
                case 'ı':
                case 'I':
                case 'i':
                case 'İ':
                    brailleimages01.Source = "i.png";
                    break;
                case 'j':
                case 'J':
                    brailleimages01.Source = "J.png";
                    break;
                case 'k':
                case 'K':
                    brailleimages01.Source = "K.png";
                    break;
                case 'l':
                case 'L':
                    brailleimages01.Source = "L.png";
                    break;
                case 'm':
                case 'M':
                    brailleimages01.Source = "M.png";
                    break;
                case 'n':
                case 'N':
                    brailleimages01.Source = "N.png";
                    break;
                case 'o':
                case 'O':
                    brailleimages01.Source = "O.png";
                    break;
                case 'p':
                case 'P':
                    brailleimages01.Source = "P.png";
                    break;
                case 'q':
                case 'Q':
                    brailleimages01.Source = "Q.png";
                    break;
                case 'r':
                case 'R':
                    brailleimages01.Source = "R.png";
                    break;
                case 's':
                case 'S':
                    brailleimages01.Source = "S.png";
                    break;
                case 't':
                case 'T':
                    brailleimages01.Source = "T.png";
                    break;
                case 'u':
                case 'U':
                    brailleimages01.Source = "U.png";
                    break;
                case 'v':
                case 'V':
                    brailleimages01.Source = "V.png";
                    break;
                case 'w':
                case 'W':
                    brailleimages01.Source = "W.png";
                    break;
                case 'x':
                case 'X':
                    brailleimages01.Source = "X.png";
                    break;
                case 'y':
                case 'Y':
                    brailleimages01.Source = "Y.png";
                    break;
                case 'z':
                case 'Z':
                    brailleimages01.Source = "Z.png";
                    break;
                default:
                    DisplayAlert("UYARI", " 1. HARFTE HATALI GİRİŞ " +
                        "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }


            switch (kelimealani.Text[1])
            {
                case 'a':
                case 'A':
                    brailleimages02.Source = "A.png";
                    break;

                case 'b':
                case 'B':
                    brailleimages02.Source = "B.png";
                    break;
                case 'c':
                case 'C':
                    brailleimages02.Source = "C.png";
                    break;
                case 'd':
                case 'D':
                    brailleimages02.Source = "D.png";
                    break;
                case 'e':
                case 'E':
                    brailleimages02.Source = "E.png";
                    break;
                case 'f':
                case 'F':
                    brailleimages02.Source = "F.png";
                    break;
                case 'g':
                case 'G':
                    brailleimages02.Source = "G.png";
                    break;
                case 'h':
                case 'H':
                    brailleimages02.Source = "H.png";
                    break;
                case 'ı':
                case 'I':
                case 'i':
                case 'İ':
                    brailleimages02.Source = "i.png";
                    break;
                case 'j':
                case 'J':
                    brailleimages02.Source = "J.png";
                    break;
                case 'k':
                case 'K':
                    brailleimages02.Source = "K.png";
                    break;
                case 'l':
                case 'L':
                    brailleimages02.Source = "L.png";
                    break;
                case 'm':
                case 'M':
                    brailleimages02.Source = "M.png";
                    break;
                case 'n':
                case 'N':
                    brailleimages02.Source = "N.png";
                    break;
                case 'o':
                case 'O':
                    brailleimages02.Source = "O.png";
                    break;
                case 'p':
                case 'P':
                    brailleimages02.Source = "P.png";
                    break;
                case 'q':
                case 'Q':
                    brailleimages02.Source = "Q.png";
                    break;
                case 'r':
                case 'R':
                    brailleimages02.Source = "R.png";
                    break;
                case 's':
                case 'S':
                    brailleimages02.Source = "S.png";
                    break;
                case 't':
                case 'T':
                    brailleimages02.Source = "T.png";
                    break;
                case 'u':
                case 'U':
                    brailleimages02.Source = "U.png";
                    break;
                case 'v':
                case 'V':
                    brailleimages02.Source = "V.png";
                    break;
                case 'w':
                case 'W':
                    brailleimages02.Source = "W.png";
                    break;
                case 'x':
                case 'X':
                    brailleimages02.Source = "X.png";
                    break;
                case 'y':
                case 'Y':
                    brailleimages02.Source = "Y.png";
                    break;
                case 'z':
                case 'Z':
                    brailleimages02.Source = "Z.png";
                    break;
                default:
                    DisplayAlert("UYARI", "2. HARFTE HATALI GİRİŞ " +
                        "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }

            switch (kelimealani.Text[2])
            {
                case 'a':
                case 'A':
                    brailleimages03.Source = "A.png";
                    break;

                case 'b':
                case 'B':
                    brailleimages03.Source = "B.png";
                    break;
                case 'c':
                case 'C':
                    brailleimages03.Source = "C.png";
                    break;
                case 'd':
                case 'D':
                    brailleimages03.Source = "D.png";
                    break;
                case 'e':
                case 'E':
                    brailleimages03.Source = "E.png";
                    break;
                case 'f':
                case 'F':
                    brailleimages03.Source = "F.png";
                    break;
                case 'g':
                case 'G':
                    brailleimages03.Source = "G.png";
                    break;
                case 'h':
                case 'H':
                    brailleimages03.Source = "H.png";
                    break;
                case 'ı':
                case 'I':
                case 'i':
                case 'İ':
                    brailleimages03.Source = "i.png";
                    break;
                case 'j':
                case 'J':
                    brailleimages03.Source = "J.png";
                    break;
                case 'k':
                case 'K':
                    brailleimages03.Source = "K.png";
                    break;
                case 'l':
                case 'L':
                    brailleimages03.Source = "L.png";
                    break;
                case 'm':
                case 'M':
                    brailleimages03.Source = "M.png";
                    break;
                case 'n':
                case 'N':
                    brailleimages03.Source = "N.png";
                    break;
                case 'o':
                case 'O':
                    brailleimages03.Source = "O.png";
                    break;
                case 'p':
                case 'P':
                    brailleimages03.Source = "P.png";
                    break;
                case 'q':
                case 'Q':
                    brailleimages03.Source = "Q.png";
                    break;
                case 'r':
                case 'R':
                    brailleimages03.Source = "R.png";
                    break;
                case 's':
                case 'S':
                    brailleimages03.Source = "S.png";
                    break;
                case 't':
                case 'T':
                    brailleimages03.Source = "T.png";
                    break;
                case 'u':
                case 'U':
                    brailleimages03.Source = "U.png";
                    break;
                case 'v':
                case 'V':
                    brailleimages03.Source = "V.png";
                    break;
                case 'w':
                case 'W':
                    brailleimages03.Source = "W.png";
                    break;
                case 'x':
                case 'X':
                    brailleimages03.Source = "X.png";
                    break;
                case 'y':
                case 'Y':
                    brailleimages03.Source = "Y.png";
                    break;
                case 'z':
                case 'Z':
                    brailleimages03.Source = "Z.png";
                    break;
                default:
                    DisplayAlert("UYARI", "3. HARFTE HATALI GİRİŞ " +
                        "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }

            switch (kelimealani.Text[3])
            {
                case 'a':
                case 'A':
                    brailleimages04.Source = "A.png";
                    break;

                case 'b':
                case 'B':
                    brailleimages04.Source = "B.png";
                    break;
                case 'c':
                case 'C':
                    brailleimages04.Source = "C.png";
                    break;
                case 'd':
                case 'D':
                    brailleimages04.Source = "D.png";
                    break;
                case 'e':
                case 'E':
                    brailleimages04.Source = "E.png";
                    break;
                case 'f':
                case 'F':
                    brailleimages04.Source = "F.png";
                    break;
                case 'g':
                case 'G':
                    brailleimages04.Source = "G.png";
                    break;
                case 'h':
                case 'H':
                    brailleimages04.Source = "H.png";
                    break;
                case 'ı':
                case 'I':
                case 'i':
                case 'İ':
                    brailleimages04.Source = "i.png";
                    break;
                case 'j':
                case 'J':
                    brailleimages04.Source = "J.png";
                    break;
                case 'k':
                case 'K':
                    brailleimages04.Source = "K.png";
                    break;
                case 'l':
                case 'L':
                    brailleimages04.Source = "L.png";
                    break;
                case 'm':
                case 'M':
                    brailleimages04.Source = "M.png";
                    break;
                case 'n':
                case 'N':
                    brailleimages04.Source = "N.png";
                    break;
                case 'o':
                case 'O':
                    brailleimages04.Source = "O.png";
                    break;
                case 'p':
                case 'P':
                    brailleimages04.Source = "P.png";
                    break;
                case 'q':
                case 'Q':
                    brailleimages04.Source = "Q.png";
                    break;
                case 'r':
                case 'R':
                    brailleimages04.Source = "R.png";
                    break;
                case 's':
                case 'S':
                    brailleimages04.Source = "S.png";
                    break;
                case 't':
                case 'T':
                    brailleimages04.Source = "T.png";
                    break;
                case 'u':
                case 'U':
                    brailleimages04.Source = "U.png";
                    break;
                case 'v':
                case 'V':
                    brailleimages04.Source = "V.png";
                    break;
                case 'w':
                case 'W':
                    brailleimages04.Source = "W.png";
                    break;
                case 'x':
                case 'X':
                    brailleimages04.Source = "X.png";
                    break;
                case 'y':
                case 'Y':
                    brailleimages04.Source = "Y.png";
                    break;
                case 'z':
                case 'Z':
                    brailleimages04.Source = "Z.png";
                    break;
                default:
                    DisplayAlert("UYARI", "4. HARFTE HATALI GİRİŞ " +
                        "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }

            switch (kelimealani.Text[4])
            {
                case 'a':
                case 'A':
                    brailleimages05.Source = "A.png";
                    break;

                case 'b':
                case 'B':
                    brailleimages05.Source = "B.png";
                    break;
                case 'c':
                case 'C':
                    brailleimages05.Source = "C.png";
                    break;
                case 'd':
                case 'D':
                    brailleimages05.Source = "D.png";
                    break;
                case 'e':
                case 'E':
                    brailleimages05.Source = "E.png";
                    break;
                case 'f':
                case 'F':
                    brailleimages05.Source = "F.png";
                    break;
                case 'g':
                case 'G':
                    brailleimages05.Source = "G.png";
                    break;
                case 'h':
                case 'H':
                    brailleimages05.Source = "H.png";
                    break;
                case 'ı':
                case 'I':
                case 'i':
                case 'İ':
                    brailleimages05.Source = "i.png";
                    break;
                case 'j':
                case 'J':
                    brailleimages05.Source = "J.png";
                    break;
                case 'k':
                case 'K':
                    brailleimages05.Source = "K.png";
                    break;
                case 'l':
                case 'L':
                    brailleimages05.Source = "L.png";
                    break;
                case 'm':
                case 'M':
                    brailleimages05.Source = "M.png";
                    break;
                case 'n':
                case 'N':
                    brailleimages05.Source = "N.png";
                    break;
                case 'o':
                case 'O':
                    brailleimages05.Source = "O.png";
                    break;
                case 'p':
                case 'P':
                    brailleimages05.Source = "P.png";
                    break;
                case 'q':
                case 'Q':
                    brailleimages05.Source = "Q.png";
                    break;
                case 'r':
                case 'R':
                    brailleimages05.Source = "R.png";
                    break;
                case 's':
                case 'S':
                    brailleimages05.Source = "S.png";
                    break;
                case 't':
                case 'T':
                    brailleimages05.Source = "T.png";
                    break;
                case 'u':
                case 'U':
                    brailleimages05.Source = "U.png";
                    break;
                case 'v':
                case 'V':
                    brailleimages05.Source = "V.png";
                    break;
                case 'w':
                case 'W':
                    brailleimages05.Source = "W.png";
                    break;
                case 'x':
                case 'X':
                    brailleimages05.Source = "X.png";
                    break;
                case 'y':
                case 'Y':
                    brailleimages05.Source = "Y.png";
                    break;
                case 'z':
                case 'Z':
                    brailleimages05.Source = "Z.png";
                    break;
                default:
                    DisplayAlert("UYARI", "5. HARFTE HATALI GİRİŞ " +
                        "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }




        }
    }
}