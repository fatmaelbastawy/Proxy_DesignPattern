using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public abstract class SMSService
    {
        public abstract string SendMsg(string custId, string Mobile, string SMS);
    }
}
