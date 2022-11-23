using Expenses2.iOS.Effect;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ResolutionGroupName("VerdantGames")]
[assembly: ExportEffect(typeof(SelectedEffect),"SelectedEffect")]
namespace Expenses2.iOS.Effect
{
    internal class SelectedEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
           
        }

        protected override void OnDetached()
        {
            
        }
    }
}