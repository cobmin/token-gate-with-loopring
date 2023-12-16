using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeRing.Shared
{
    public class WalletConnectionEventArgs : EventArgs
    {
        public AccountInformation AccountInfo { get; set; }
        public ApiKey ApiKey { get; set; }
    }

}
