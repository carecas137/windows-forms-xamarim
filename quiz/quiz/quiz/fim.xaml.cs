using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace quiz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class fim : ContentPage
	{
		public fim (int p)
		{
            
            InitializeComponent ();
            if (p == 1)
            {
                ponta.Text = "Pontuação:10";
            }
            if (p == 0)
            {
                ponta.Text = "Pontuação:0";
            }
            if(p==2)
            {
                ponta.Text = "Pontuação:20";
            }
        }
        async void voltarAsync(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}