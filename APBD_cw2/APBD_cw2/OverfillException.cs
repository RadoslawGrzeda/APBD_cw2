using System.Transactions;

namespace APBD_cw2;

public class OverfillException : Exception
{
    public OverfillException(string mess) : base(mess)
    {
    }
}