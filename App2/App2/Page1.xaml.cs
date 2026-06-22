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
    public partial class Page1 : ContentPage
    {
        public static string nameUser = "";
        public Page1()
        {
            InitializeComponent();
            MyPicker.Items.Add("Аннуитетные");
            MyPicker.Items.Add("Дифференцированные");
            SliderPr.ValueChanged += (s, e) =>
            {
                 Procent2.Text = $"{Math.Round(SliderPr.Value):F0}%";          
            };
            


        }
        public void ButtonClicked(object sender, EventArgs e)
        {
            int money;
            try
            {
                money = Convert.ToInt32(SumCredit.Text);
                if (money <= 0)
                {
                    SumCredit.Text = "";
                    SumCredit.Placeholder = "Нельзя так";
                    LABEL1.Text = "Ежемесячный платеж: ...";
                    LABEL2.Text = "Общая сумма: ...";
                    LABEL3.Text = "Переплата: ...";
                    return;
                }
            }
            catch
            {
                SumCredit.Text = "";
                SumCredit.Placeholder = "Нельзя так";
                LABEL1.Text = "Ежемесячный платеж: ...";
                LABEL2.Text = "Общая сумма: ...";
                LABEL3.Text = "Переплата: ...";
                return;
            }
            int money2 = 0;
            try
            {


                money2 = Convert.ToInt32(CreditM.Text);
                if (money2 <= 0)
                {
                    CreditM.Text = "";
                    CreditM.Placeholder = "Нельзя так";
                    LABEL1.Text = "Ежемесячный платеж: ...";
                    LABEL2.Text = "Общая сумма: ...";
                    LABEL3.Text = "Переплата: ...";
                    return;
                }
            }
            catch
            {
                CreditM.Text = "";
                CreditM.Placeholder = "Нельзя так";
                LABEL1.Text = "Ежемесячный платеж: ...";
                LABEL2.Text = "Общая сумма: ...";
                LABEL3.Text = "Переплата: ...";
                return;
            }
            if (MyPicker.SelectedIndex == 0)
            {
                DisplayAlert("Information", $"Сумма кредита: {money}\nСрок (месяцев): {money2}\nДанное значение слайдера: {Math.Round(SliderPr.Value)}\nМаксимальное значение слайдера: {SliderPr.Maximum}", "Close");
                LABEL1.Text = $"Ежемесячный платеж: {money / money2 + (((Math.Round(SliderPr.Value) / 100) * (money / money2)))}";
                LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * money)}";
                LABEL3.Text = $"Переплата: {Math.Abs((money + ((Math.Round(SliderPr.Value) / 100) * money) - money))}";
            }
            else if(MyPicker.SelectedIndex == 1)
            {
                DisplayAlert("Information", $"Сумма кредита: {money}\nСрок (месяцев): {money2}\nДанное значение слайдера: {Math.Round(SliderPr.Value)}\nМаксимальное значение слайдера: {SliderPr.Maximum}", "Close");
                LABEL1.Text = "Ежемесячный платеж: ...";
                LABEL2.Text = $"Общая сумма: {money + ((Math.Round(SliderPr.Value) / 100) * money)}";
                LABEL3.Text = $"Переплата: {Math.Abs((money + ((Math.Round(SliderPr.Value) / 100) * money) - money))}";

            }
        }
    }
}