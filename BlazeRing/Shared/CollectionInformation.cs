using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeRing.Shared
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Cached
    {
        public string avatar { get; set; }
        public string banner { get; set; }
        public string tileUri { get; set; }
        public string thumbnail { get; set; }
    }

    public class Collection
    {
        public Collection collection { get; set; }
    }

    public class Collection2
    {
        public int id { get; set; }
        public string owner { get; set; }
        public string name { get; set; }
        public string contractAddress { get; set; }
        public string collectionAddress { get; set; }
        public string baseUri { get; set; }
        public string nftFactory { get; set; }
        public string description { get; set; }
        public string avatar { get; set; }
        public string banner { get; set; }
        public string thumbnail { get; set; }
        public string tileUri { get; set; }
        public Cached cached { get; set; }
        public string deployStatus { get; set; }
        public string nftType { get; set; }
        public bool isPublic { get; set; }
        public bool isCounterFactualNFT { get; set; }
        public bool isMintable { get; set; }
        public bool isEditable { get; set; }
        public bool isDeletable { get; set; }
        public Times times { get; set; }
        public Extra extra { get; set; }
    }

    public class Extra
    {
        public Properties properties { get; set; }
        public string mintChannel { get; set; }
    }

    public class Properties
    {
        public bool isLegacy { get; set; }
        public bool isPublic { get; set; }
        public bool isCounterFactualNFT { get; set; }
        public bool isMintable { get; set; }
        public bool isEditable { get; set; }
        public bool isDeletable { get; set; }
    }

    public class CollectionInformation
    {
        public List<Collection> collections { get; set; }
        public int totalNum { get; set; }
    }

    public class Times
    {
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
    }


}
