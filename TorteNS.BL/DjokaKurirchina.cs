using TorteNS.Shared;

namespace TorteNS.BL
{
    public class DjokaKurirchina : IKurirchina
    {
	    private readonly IDataAccess _dataAccess;

	    public DjokaKurirchina(IDataAccess dataAccess)
	    {
		    _dataAccess = dataAccess;
	    }
    }
}
