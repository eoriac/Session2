using Session2.DataBinding.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Session2.DataBinding.TemplateSelector
{
    public class ArticleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RegularArticleTemplate { get; set; }

        public DataTemplate NotInStockTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Article)item).InStock ? RegularArticleTemplate : NotInStockTemplate;
        }
    }
}
