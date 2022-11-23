using System;
using System.Collections.Generic;
using Expenses2.Models;
using Expenses2.ViewModels;
using Xamarin.Forms;

namespace Expenses2.Views
{
    public partial class ExpenseDetailsPage : ContentPage
    {
        ExpenseDetailsVM ViewModel;
        public ExpenseDetailsPage()
        {
            InitializeComponent();
        }

        public ExpenseDetailsPage(Expense expense)
        {
            InitializeComponent();

            ViewModel = Resources["vm"] as ExpenseDetailsVM;
            ViewModel.Expense = expense;
        }
    }
}
