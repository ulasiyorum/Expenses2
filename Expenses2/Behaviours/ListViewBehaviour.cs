using Expenses2.Models;
using Expenses2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Expenses2.Behaviours
{
    internal class ListViewBehaviour : Behavior<ListView>
    {
        ListView listView;
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            listView = bindable;
            listView.ItemSelected += ListView_ItemSelected;
        }

        void ListView_ItemSelected(object s,SelectedItemChangedEventArgs e)
        {
            Expense selected = listView.SelectedItem as Expense;
            Application.Current.MainPage.Navigation.PushAsync(new ExpenseDetailsPage(selected));
        }
        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);

            listView.ItemSelected -= ListView_ItemSelected;
        }
    }
}
