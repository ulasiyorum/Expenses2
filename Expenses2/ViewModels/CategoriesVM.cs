using System;
using System.Linq;
using System.Collections.ObjectModel;
using Expenses2.Models;
namespace Expenses2.ViewModels
{
    public class CategoriesVM
    {
        public ObservableCollection<string> Categories
        {
            get;
            set;
        }
        public ObservableCollection<CategoryExpenses> CategoryExpensesCollection { get; set; }

        public CategoriesVM()
        {
            Categories = new ObservableCollection<string>();
            CategoryExpensesCollection = new ObservableCollection<CategoryExpenses>();   
            GetCategories();
            GetExpensesPerCategory();
        }
        public void GetExpensesPerCategory()
        {
            CategoryExpensesCollection.Clear();
            float totalExpensesAmount = Expense.TotalExpensesAmount();
            foreach(string c in Categories)
            {
                var expenses = Expense.GetExpenses(c);
                float expensesAmountInCategory = expenses.Sum(e => e.Amount);

                CategoryExpenses ce = new CategoryExpenses()
                {
                    Category = c,
                    ExpensesPercentage = expensesAmountInCategory / totalExpensesAmount, 
                };
                CategoryExpensesCollection.Add(ce);
            }
        }
        private void GetCategories()
        {
            Categories.Clear();
            Categories.Add("Housing");
            Categories.Add("Debt");
            Categories.Add("Health");
            Categories.Add("Food");
            Categories.Add("Personal");
            Categories.Add("Travel");
            Categories.Add("Other");
        }
        public struct CategoryExpenses
        {
            public string Category { get; set; }
            public float ExpensesPercentage { get; set; }
        }
    }
}
