using Session2.DataBinding.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Session2.DataBinding.ViewModels
{
    public class ArticleDetailViewModel
    {
        public ArticleDetailViewModel()
        {
            SaveArticle = new Command((article) =>
            {
                var art = article as Article;
                // service with save logic
            });
        }

        public Article Article { get; set; }

        public ICommand SaveArticle { get; private set; }

        public string Author { get; set; }
    }
}
