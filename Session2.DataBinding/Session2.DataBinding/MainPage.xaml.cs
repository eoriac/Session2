using Session2.DataBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Session2.DataBinding
{
    public partial class MainPage : ContentPage
    {
        public Article PageArticle { get; set; }

        public MainPage()
        {
            InitializeComponent();

            PageArticle = new Article()
            {
                Id = 1,
                Description = "Test description",
                Price = 10.99,
                Title = "Test Title",
            };

            //this.BindingContext = PageArticle;

            this.BindingContext = this;

            //MainGrid.BindingContext = article;

            //Binding articleTitleBinding = new Binding();
            //articleTitleBinding.Source = article;
            //articleTitleBinding.Path = "Title";

            //TitleEntry.SetBinding(Entry.TextProperty, articleTitleBinding);

            //Binding articleDescriptionBinding = new Binding();
            //articleDescriptionBinding.Source = article;
            //articleDescriptionBinding.Path = "Description";

            //DescriptionEntry.SetBinding(Entry.TextProperty, articleDescriptionBinding);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PageArticle.Price++;
            PageArticle.Title += " Hola";
        }
    }
}
