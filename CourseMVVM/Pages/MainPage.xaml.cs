using CourseMVVM.Models;
using CourseMVVM.PageModels;

namespace CourseMVVM.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}