using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace quiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void per1Async(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new pergunta1());
        }
    }
   
}
