using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SendValue
{
    public partial class Result : ContentPage
    {

        public Result(string Num1, string Num2)
        {
            InitializeComponent();
            int resutado = Convert.ToInt32(Num1) + Convert.ToInt32(Num2);
            result.Text = "Resultado da soma: " + resutado;
        }
        void VoltarTela(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
