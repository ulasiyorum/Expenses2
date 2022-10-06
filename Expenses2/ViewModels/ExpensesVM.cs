using System;
using System.Collections.ObjectModel;
using Expenses2.Models;
using Xamarin.Forms;
using Expenses2.Views;

namespace Expenses2.ViewModels
{
    public class ExpensesVM
    {
        public ObservableCollection<Expense> Expenses
        {
            get;
            set;
        }
        public Command AddExpenseCommand
        {
            get;
            set;
        }
        public ExpensesVM()
        {
            Expenses = new ObservableCollection<Expense>();
            AddExpenseCommand = new Command(AddExpense);
            GetExpenses();
        }

        public void GetExpenses()
        {
            var expenses = Expense.GetExpenses();

            Expenses.Clear();

            foreach(var expense in expenses)
            {
                Expenses.Add(expense);
            }
        }
        public void AddExpense()
        {
            Application.Current.MainPage.Navigation.PushAsync(new NewExpensePage());
        }
    }
}
