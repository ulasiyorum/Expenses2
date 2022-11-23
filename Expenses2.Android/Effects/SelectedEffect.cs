using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Expenses2.Droid.Effects;

[assembly: ResolutionGroupName("VerdantGames")]
[assembly: ExportEffect(typeof(SelectedEffect),"SelectedEffect")]
namespace Expenses2.Droid.Effects
{
    public class SelectedEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            
        }

        protected override void OnDetached()
        {
            
        }
    }
}