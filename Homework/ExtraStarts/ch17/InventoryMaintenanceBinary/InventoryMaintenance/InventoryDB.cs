namespace InventoryMaintenance
{
	public static class InventoryDB
	{
		private const string Path = @"..\..\..\InventoryItems.dat";

        public static List<InventoryItem> GetItems()
		{
            // create the list
            List<InventoryItem> items = new();

            // Add code here to read the binary file into the List<InventoryItem> object.

            return items;
		}

		public static void SaveItems(List<InventoryItem> items)
		{
            // Add code here to write the List<InventoryItems> object to a binary file.
        }
    }
}