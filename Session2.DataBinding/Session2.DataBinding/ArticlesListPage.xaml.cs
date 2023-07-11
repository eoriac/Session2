using Session2.DataBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Session2.DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticlesListPage : ContentPage
    {
        public ObservableCollection<Article> Articles { get; set; }

        public ArticlesListPage()
        {
            InitializeComponent();

            Articles = new ObservableCollection<Article>()
            {
                new Article()
                {
                    Id = 1,
                    Title = "Foo Article 1",
                    AvailableFromDate = DateTime.Now,
                    Description = "Bar",
                    ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                    InStock = true,
                    Price = 10.99,
                },
                new Article()
                {
                    Id = 2,
                    Title = "Foo 2",
                    AvailableFromDate = DateTime.Now,
                    Description = "Bar",
                    ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                    InStock = true,
                    Price = 99,
                },                          new Article()
                {
                    Id = 3,
                    Title = "Foo 3",
                    AvailableFromDate = DateTime.Now,
                    Description = "Bar",
                    ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                    InStock = true,
                    Price = 0.99,
                },              new Article()
                {
                    Id = 4,
                    Title = "Foo 4",
                    AvailableFromDate = DateTime.Now,
                    Description = "Bar",
                    ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                    InStock = true,
                    Price = 11,
                },              new Article()
                {
                    Id = 5,
                    Title = "Foo 5",
                    AvailableFromDate = DateTime.Now,
                    Description = "Bar",
                    ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                    InStock = true,
                    Price = 12,
                },
            };

            ArticlesListView.ItemsSource = Articles;
        }

        private void AddItemButton_Clicked(object sender, EventArgs e)
        {
            var article = new Article()
            {
                Title = "New Article",
                Description = "Lorem ipsum, blablabla",
                Price = 9.99,
                ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                InStock = true,
            };

            Articles.Add(article);
        }
    }
}