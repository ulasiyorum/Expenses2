using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Expenses2.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(TextCell), typeof(CustomTextCellRenderer))]
namespace Expenses2.iOS.CustomRenderers
{
    public class CustomTextCellRenderer : TextCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            switch (item.StyleId)
            {
                case "none": cell.Accessory = UITableViewCellAccessory.None;
                    break;
                case "checkmark": cell.Accessory = UITableViewCellAccessory.Checkmark;
                    break;
                case "detail-button": cell.Accessory = UITableViewCellAccessory.DetailButton;
                    break;
                case "detail-disclosure-button": cell.Accessory = UITableViewCellAccessory.DetailDisclosureButton;
                    break;
                case "disclosure":
                default:
                    cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
                    break;
            }
            
            return cell;
        }
    }
}