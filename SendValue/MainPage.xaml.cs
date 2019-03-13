using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SendValue
{
    public partial class MainPage : ContentPage
    {
        void calcular(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Result(Num1.Text, Num2.Text));
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
