using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeRing.Shared
{
    public static class BlazeRingConstants
    {
        public static string ApiUrl = "https://api3.loopring.io";
        public static string GetAccountInformationApiEndpoint = "/api/v3/account";
        public static string GetApiKeyEndpoint = "api/v3/apiKey";
        public static string GetUserNFTsEndpoint = "api/v3/user/nft/balances";
        public static string GetUserNFTsByCollectionEndpoint = "api/v3/nft/collection";
        public static string GetUserAssetsEndpoint = "api/v3/user/balances";

        public static string specificNftData = "0x22829c359ca1f7b1e9bbb2d95992e33bc92394f8f22254d340daa2769c0a2494";
        public static string specificNftDatas = "0x2b4c082018bbe80fec8deb288dfaa088d2913d33f5c9fe3db18f2adb3379cf71,0x0bf8e9af100ca3f5f5a8ec399c51be6b7b4a6b75c77545d8728663fbc1d21d64"; 
        public static string specificCollectionAddress = "0xa6a1de23cfe7a2cbd9d3c63d53efd263426bc8ed";

        public static string singleNftLinkUrl = "https://loopexchange.art/collection/maize-access/item/0x6692d7a147762ce9335746c7b062576ef9834500f5546a29c724c55752f668c7";
        public static string multipleNftLinkUrl = "https://nft.gamestop.com/collection/EVA-NATE";
        public static string collectionNftLinkUrl = "https://loopexchange.art/collection/cobsfarm";

        public static string githubIndex = "https://github.com/cobmin/token-gate-with-loopring/blob/master/BlazeRing/Client/Pages/Index.razor";

        public static string nftAssetsDocUrl = "https://docs-protocol.loopring.io/counterfactual-nft/api-references/get-nft-assets";
        public static string collectionAssetsDocUrl = "https://docs-protocol.loopring.io/counterfactual-nft/api-references/nft-collection/list-owned-collections";
        public static string cryptoAssetsDocUrl = "https://docs-protocol.loopring.io/erc20-tokens/api-references/get-assets";

        public static int lrcTokenId = 1;


    }
}
