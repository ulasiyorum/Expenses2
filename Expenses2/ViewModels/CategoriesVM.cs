using System;
using System.Linq;
using System.Collections.ObjectModel;
using Expenses2.Models;
using Expenses2.Interfaces;
using Xamarin.Forms;
using PCLStorage;
using System.IO;

namespace Expenses2.ViewModels
{
    public class CategoriesVM
    {
        public ObservableCollection<string> Categories
        {
            get;
            set;
        }
        public Command Export
        {
            get;
            set;
        }
        public ObservableCollection<CategoryExpenses> CategoryExpensesCollection { get; set; }

        public CategoriesVM()
        {
            Export = new Command(ShareReport);
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

        public async void ShareReport()
        {
            IFileSystem fileSystem = FileSystem.Current;
            IFolder rootFolder = fileSystem.LocalStorage;
            IFolder reportsFolder = await rootFolder.CreateFolderAsync("reports",CreationCollisionOption.OpenIfExists);
            var txtFile = await reportsFolder.CreateFileAsync("report.txt", CreationCollisionOption.ReplaceExisting);
            using(StreamWriter sw = new StreamWriter(txtFile.Path))
            {
                foreach(var ce in CategoryExpensesCollection)
                {
                    sw.WriteLine($"{ce.Category} - {ce.ExpensesPercentage}");
                }
            }
            IShare shareDependency = DependencyService.Get<IShare>();
            await shareDependency.Show("Expense Report", "Here is your expense report", txtFile.Path);
        }
    }
}
