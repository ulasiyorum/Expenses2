using Expenses2.iOS.Effect;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ResolutionGroupName("VerdantGames")]
[assembly: ExportEffect(typeof(SelectedEffect),"SelectedEffect")]
namespace Expenses2.iOS.Effect
{
    public class SelectedEffect : PlatformEffect
    {
        UIColor selectedColor;
        protected override void OnAttached()
        {
            selectedColor = new UIColor(176 / 255, 152 / 255, 164 / 255, 1);
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if(args.PropertyName == "IsFocused")
            {
                if(Control.BackgroundColor != selectedColor)
                {
                    Control.BackgroundColor = selectedColor;
                }
                else
                {
                    Control.BackgroundColor = UIColor.White;
                }
            }
        }
        protected override void OnDetached()
        {
            
        }
    }
}