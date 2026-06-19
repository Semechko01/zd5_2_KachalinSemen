using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_KachalinSemen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Welcome : ContentPage
	{
		public Welcome ()
		{
			InitializeComponent ();
		}
		public void ButtonClicked(object sender,EventArgs e)
		{

			if (String.IsNullOrEmpty(Logintxt.Text))
			{
                Logintxt.Text = "";
                Logintxt.Placeholder = "Пустая строка!";
				return;
			}
			if (String.IsNullOrEmpty(Passtxt.Text))
			{
				Passtxt.Text = "";
				Passtxt.Placeholder = "Пустая строка!";
				return;
			}
			if(Logintxt.Text.Length < 3)
			{
				Logintxt.Text = "";
				Logintxt.Placeholder = "Логин меньше 3";
				return;
			}
            if (Passtxt.Text.Length < 8)
            {
                Passtxt.Text = "";
                Passtxt.Placeholder = "Пароль меньше 8";
                return;
            }
			Page1.nameUser = Logintxt.Text;
			

			Navigation.PushAsync(new MainPage( ));

        }
	}
}