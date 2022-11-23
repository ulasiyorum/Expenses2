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
using Android.Graphics.Drawables;
using Android.Graphics;
using System.ComponentModel;

[assembly: ResolutionGroupName("VerdantGames")]
[assembly: ExportEffect(typeof(SelectedEffect),"SelectedEffect")]
namespace Expenses2.Droid.Effects
{
    public class SelectedEffect : PlatformEffect
    {
        Android.Graphics.Color selectedColor;
        protected override void OnAttached()
        {
            selectedColor = new Android.Graphics.Color(229, 235, 234);
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((ColorDrawable)Control.Background).Color != selectedColor)
                    {
                        Control.SetBackgroundColor(selectedColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(Android.Graphics.Color.White);
                    }
                }
            }
            catch (InvalidCastException)
            {
                Control.SetBackgroundColor(selectedColor);
            }
        }

        protected override void OnDetached()
        {
            
        }
    }
}