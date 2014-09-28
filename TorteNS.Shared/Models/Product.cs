namespace TorteNS.Shared.Models
{
	public class Product
	{
		public string Name { get; set; }
		public string Price { get; set; }
		public string Weight { get; set; }
		public string Description { get; set; }
		public string Amount { get; set; }
		public uint PreparationDays { get; set; }
		public uint GroupId { get; set; }
	}
}