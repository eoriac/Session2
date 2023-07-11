using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Session2.DataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new ViewBindingsPage();
            // MainPage = new ArticleDetailsPage();
            MainPage = new ArticlesListPage();
            // MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
