using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SMSServiceProxy
    {
        private SMSService _smsService;
        Dictionary<string, int> sentCount = new Dictionary<string, int>();
        public string SendMsg(string custId, string Mobile, string SMS)
        {
            if (_smsService == null)

            { _smsService = new ConcreteSMSService();}

            //First Call//

            if (!sentCount.ContainsKey(custId))
                {
                        sentCount.Add(custId, 1);
                    return _smsService.SendMsg(custId, Mobile, SMS);
                }
            //Not The First//
            else
                {
                var customer = sentCount.Where(x => x.Key == custId).FirstOrDefault();
                if (customer.Value >= 4) 
                { return " Did not sent!"; }

                else 
                { sentCount[custId] = customer.Value + 1;
                    return _smsService.SendMsg(custId, Mobile, SMS);
                }
            }
            
        }
    }
}
