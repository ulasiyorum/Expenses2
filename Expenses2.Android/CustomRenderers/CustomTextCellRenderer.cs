
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Android.Views;
using Xamarin.Forms.Platform.Android;
using Expenses2.Droid.CustomRenderers;
using Android.Content;

[assembly: ExportRenderer(typeof(TextCell), typeof(CustomTextCellRenderer))]
namespace Expenses2.Droid.CustomRenderers
{
    public class CustomTextCellRenderer : TextCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View reusableCell, ViewGroup tv, Context context)
        {
            var cell = base.GetCellCore(item, reusableCell, tv,context);

            switch (item.StyleId)
            {
                case "AliceBlue":
                    cell.SetBackgroundColor(Android.Graphics.Color.AliceBlue);
                    break;
                case "Aqua":
                    cell.SetBackgroundColor(Android.Graphics.Color.Aqua);
                    break;
                case "Azure":
                    cell.SetBackgroundColor(Android.Graphics.Color.Azure);
                    break;
                case "Bisque":
                    cell.SetBackgroundColor(Android.Graphics.Color.Bisque);
                    break;
                case "BlanchedAlmond":
                default:
                    cell.SetBackgroundColor(Android.Graphics.Color.BlanchedAlmond);
                    break;
            }

            return cell;
        }
    }
}