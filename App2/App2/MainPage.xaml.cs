using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using static Xamarin.Forms.Device;
using Xamarin.Forms.StyleSheets;

namespace App2
{
    public partial class MainPage : CarouselPage
    {

        public MainPage()
        {
            InitializeComponent();
            Base.Title = $"Welcome,{Page1.nameUser}";
        }
    }
}
