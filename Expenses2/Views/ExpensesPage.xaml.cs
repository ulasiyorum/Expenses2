using Expenses2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expenses2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpensesPage : ContentPage
    {
        ExpensesVM VM;
        public ExpensesPage()
        {
            InitializeComponent();
        
            VM = Resources["vm"] as ExpensesVM;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            VM.GetExpenses();
        }
    }
}