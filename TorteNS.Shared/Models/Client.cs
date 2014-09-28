namespace TorteNS.Shared.Models
{
	public class Client
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string PhoneNumber { get; set; }
		public string PhoneNumber2 { get; set; }
		public string Email { get; set; }
		public string FacebookLink { get; set; }
		public string Notes { get; set; }
		public string Address { get; set; }
		public uint Rating { get; set; }
		public ClientStatus Status { get; set; }
	}
}
