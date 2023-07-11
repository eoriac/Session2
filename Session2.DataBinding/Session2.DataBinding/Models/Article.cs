using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Session2.DataBinding.Models
{
    //public class Article
    //{
    //    public int Id { get; set; }

    //    public string Title { get; set; }

    //    public string Description { get; set; }

    //    public double Price { get; set; }
    //}

    public class Article : INotifyPropertyChanged
    {
        private int id;
        private string title;
        private double price;
        private string description;
        private string imageUrl;
        private bool inStock;
        private DateTime availableFromDate;


        public int Id
        {

            get => this.id;

            set
            {
                this.id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string Title
        {
            get => this.title;
            set
            {
                this.title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get => this.description;
            set
            {
                this.description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        public double Price
        {
            get => this.price;
            set
            {
                this.price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        public string ImageUrl
        {
            get => imageUrl;
            set
            {
                imageUrl = value;
                RaisePropertyChanged(nameof(ImageUrl));
            }
        }

        public bool InStock
        {
            get => inStock;
            set
            {
                inStock = value;
                RaisePropertyChanged(nameof(InStock));
            }
        }
        public DateTime AvailableFromDate
        {
            get => availableFromDate;
            set
            {
                availableFromDate = value;
                RaisePropertyChanged(nameof(AvailableFromDate));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
