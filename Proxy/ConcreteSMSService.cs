using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ConcreteSMSService:SMSService
    {
        public override string SendMsg(string custId, string Mobile, string SMS)
        {
            return $"Customer Id{custId},SMS sent to {Mobile}";
        }
    }
}
