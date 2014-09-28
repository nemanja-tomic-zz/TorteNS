using System.Collections.Generic;
using TorteNS.Shared.Models;

namespace TorteNS.Shared
{
	public interface IDataAccess
	{
		IEnumerable<Client> GetAllClients();
	}
}