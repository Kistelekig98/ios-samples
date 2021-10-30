using System.Collections.Generic;

namespace BasicTable
{
  /// <summary>
  /// A group that contains table items
  /// </summary>
  public class TableItemGroup 
	{
		public string Name { get; set; }
		public string Footer { get; set; }	
		public List<TableItem> Items { get; set; } = new List<TableItem>();
	}
}
