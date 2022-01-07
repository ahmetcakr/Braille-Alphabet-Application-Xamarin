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

            if (kelimealani.Text == "selam" || kelimealani.Text=="Selam" || kelimealani.Text == "SELAM")
            {
                brailleimages01.Source = "S.png";
                brailleimages02.Source = "E.png";
                brailleimages03.Source = "L.png";
                brailleimages04.Source = "A.png";
                brailleimages05.Source = "M.png";
            }


          

            
        }
    }
}