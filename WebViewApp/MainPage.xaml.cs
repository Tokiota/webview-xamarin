using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            webView.Source = "http://www.facebook.com/";
		}

        void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.ToUpper().Contains("Logout".ToUpper()))
            {
                e.Cancel = true;
            }
        }
        void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            
        }
    }
}
