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
    public partial class MyTabbedPage1 : TabbedPage
    {
        public MyTabbedPage1()
        {
            //InitializeComponent();
            Children.Add(new MainPage());
            Children.Add(new MainPage2());
            Children.Add(new MainPage3());
            Children.Add(new MainPage4());
        }
    }
}