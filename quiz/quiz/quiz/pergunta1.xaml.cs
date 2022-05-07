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
	public partial class pergunta1 : ContentPage
	{
		public pergunta1 ()
		{
			InitializeComponent ();
		}
        async void per2cAsync(object sender, EventArgs e)
        {
            int p = 1;
            Button button = (sender as Button);
            button.BackgroundColor = Color.Green;
            await Task.Delay(2000);
            Thread.Sleep(5);
            await Navigation.PushAsync(new pergunta2(p));
        }
        async void per2eAsync(object sender, EventArgs e)
        {
            int p = 0;
            Button button = (sender as Button);
            button.BackgroundColor = Color.Red;
            await Task.Delay(2000);
            Thread.Sleep(5);
            await Navigation.PushAsync(new pergunta2(p));
        }
    }
}