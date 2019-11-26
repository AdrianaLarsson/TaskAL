using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TaskAL
{
    public class TableViewSource : UITableViewSource
    {
        List<string> personData;

        public TableViewSource(List<string> items)
        {
            personData = PersonManager.personData;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cell");
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cell");
            }
            cell.TextLabel.Text = personData[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return personData.Count;
        }
    }
}
