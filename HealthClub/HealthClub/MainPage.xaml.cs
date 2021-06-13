using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthClub
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddCustomer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomerPage());
        }
    }
}
