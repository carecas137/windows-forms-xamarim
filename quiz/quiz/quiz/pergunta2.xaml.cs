using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace quiz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pergunta2 : ContentPage
	{
         int d = 0;
        int t = 0;

        public pergunta2 (int p)
		{
           
            InitializeComponent ();
            int d = 0;
             t = p;
            if (p == 1)
            {
                ponta.Text = "Pontuação:10";
                d = 1;
            }
            if (p == 0)
            {
                ponta.Text = "Pontuação:0";
                d = 0;
            }

        }
        async void per3cAsync(object sender, EventArgs e)
        {
            if (t == 1)
            { 
                d = 2;
            }
            if (t == 0)
            {
              
                d = 1;
            }
            Button button = (sender as Button);
            button.BackgroundColor = Color.Green;
            await Task.Delay(2000);
            Thread.Sleep(5);
            await Navigation.PushAsync(new fim(d));
        }
        async void per3eAsync(object sender, EventArgs e)
        {

            if (t == 1)
            {
                d = 1;
            }
            if (t == 0)
            {

                d = 0;
            }
            Button button = (sender as Button);
            button.BackgroundColor = Color.Red;
            await Task.Delay(2000);
            Thread.Sleep(5);

            await Navigation.PushAsync(new fim(d));
        }
    }
}