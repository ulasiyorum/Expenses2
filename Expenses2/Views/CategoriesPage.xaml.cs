using Expenses2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expenses2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        CategoriesVM VM;
        public CategoriesPage()
        {
            InitializeComponent();
            VM = Resources["vm"] as CategoriesVM;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            VM.GetExpensesPerCategory();
        }
    }
}