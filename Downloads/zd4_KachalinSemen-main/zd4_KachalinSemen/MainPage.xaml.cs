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

namespace zd4_KachalinSemen
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();

            this.Resources.Add(StyleSheet.FromResource(
                "mystyles.css",
                IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly));
            Base.Title = $"Welcome,{Page1.nameUser}";
        }
    }
}
