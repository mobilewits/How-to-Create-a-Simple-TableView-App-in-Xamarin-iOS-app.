using System;
using UIKit;

namespace SampleTableView
{
	public class TableSource : UITableViewSource
	{
		string[] itemData;
		string cellIdentifier = "TableCell";
		public TableSource (string[] items)
		{
			itemData = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return itemData.Length;
		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			// if there are no cells to reuse, create a new one
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = itemData[indexPath.Row];
			return cell;
		}
	}
}

