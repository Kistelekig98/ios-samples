using UIKit;

namespace BasicTable
{
  public class TableItem 
	{
		public string Heading { get; set; }		
		public string SubHeading { get; set; }		
		public string ImageName { get; set; }		
		public UITableViewCellStyle CellStyle { get; set; } = UITableViewCellStyle.Default;	
		public UITableViewCellAccessory CellAccessory { get; set; } = UITableViewCellAccessory.None;

		public TableItem (string heading) => Heading = heading;
	}
}
