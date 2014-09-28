using System;

namespace TorteNS.Shared.Models
{
	public class Order
	{
		public string Description { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DueDate { get; set; }
		public uint ClientId { get; set; }
		public uint ProductId { get; set; }
	}
}