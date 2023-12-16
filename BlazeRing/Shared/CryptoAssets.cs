using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeRing.Shared
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Pending
    {
        public string withdraw { get; set; }
        public string deposit { get; set; }
    }

    public class CryptoAssets
    {
        public int accountId { get; set; }
        public int tokenId { get; set; }
        public string total { get; set; }
        public string locked { get; set; }
        public Pending pending { get; set; }
    }


}
