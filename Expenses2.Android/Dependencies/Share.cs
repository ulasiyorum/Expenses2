using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using Expenses2.Droid.Dependencies;
using Expenses2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly:Dependency(typeof(Share))]
namespace Expenses2.Droid.Dependencies
{
    public class Share : IShare
    {
        public Task Show(string title, string message, string filePath)
        {
            var intent = new Intent(Intent.ActionSend);
            intent.SetType("text/plain");
            var documentUri = FileProvider.GetUriForFile(Android.App.Application.Context, "com.companyname.expenses2", new Java.IO.File(filePath));

            intent.PutExtra(Intent.ExtraStream, documentUri);
            intent.PutExtra(Intent.ExtraText, title);
            intent.PutExtra(Intent.ExtraSubject, message);

            var chooserIntent = Intent.CreateChooser(intent, title);
            chooserIntent.SetFlags(ActivityFlags.GrantReadUriPermission);
            chooserIntent.AddFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(chooserIntent);
            return Task.FromResult(true);
        }
    }
}