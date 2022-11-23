using System;
using System.ComponentModel;
using Expenses2.Models;

namespace Expenses2.ViewModels
{
    public class ExpenseDetailsVM : INotifyPropertyChanged
    {
        private Expense expense;
        public Expense Expense
        {
            get { return expense; }
            set
            {
                expense = value;
                OnPropertyChanged("Expense");
            }
        }

        public ExpenseDetailsVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
