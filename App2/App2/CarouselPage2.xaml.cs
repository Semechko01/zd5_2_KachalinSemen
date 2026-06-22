using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage2 : ContentPage
    {
        public CarouselPage2()
        {
            InitializeComponent();
            picker.Items.Add("OPTION 1");
            picker.Items.Add("OPTION 2");
            picker.Items.Add("OPTION 3");
        }
    }
}