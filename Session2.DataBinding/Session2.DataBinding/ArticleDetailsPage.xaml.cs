using Session2.DataBinding.Models;
using Session2.DataBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Session2.DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleDetailsPage : ContentPage
    {
        public Article Article { get; set; }

        public ArticleDetailViewModel ArticleDetailViewModel { get; set; }

        public ArticleDetailsPage()
        {
            InitializeComponent();

            ArticleDetailViewModel = new ArticleDetailViewModel()
            {
                Article = new Article()
                {
                    Id = 1,
                    Title = "Article test title",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 10.99,
                    ImageUrl = "https://source.unsplash.com/user/c_v_r/1900x800",
                    InStock = true,
                    AvailableFromDate = DateTime.Now,
                },
                Author = "Edgar Allan Poe"
            };

            this.BindingContext = ArticleDetailViewModel;
        }

        private async void SaveArticleButton_Clicked(object sender, EventArgs e)
        {
            // Save Article Logic
            await DisplayAlert("Saved", "Article Saved", "Done");
        }
    }
}