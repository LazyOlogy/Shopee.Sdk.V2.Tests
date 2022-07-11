using ShopeeSdkV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopeeSdkV2Tests
{
    public class Core
    {
#if DEBUG
        //Test Partner
        public const int PartnerId = 1008000;
        public const int ShopId = 53422;
        public const string Key = "90d02071b0a7381d311422783afcb0bf39ce1e86c546a56f23e3273079050f85";
        public string OrderSn = "2206307WPAPFTM";
        public string Webhook = "https://eztool-func.azurewebsites.net/api/ShopeeAuthHookDev";

        public Client client = new Client(PartnerId,
            ShopId, Key,
            AsscessToken: "6558554a426b65626d654d434f465a41",
            RefreshToken: "7075576456686c4173494c6c5a736c4b");
#else

        //Production Partner

        public const int PartnerId = 2004216;
        public const int ShopId = 21603064;
        public const string Key = "333fd356b38ab062252b8cd5a384be41e5c26538d81bf244c2e823fce72dedbf";
        public string OrderSn = "2207116RPVBPDC";
        public string Webhook = "https://eztool-func.azurewebsites.net/api/ShopeeAuthHook";

        public Client client = new Client(PartnerId,
            ShopId, Key,
            AsscessToken: "614f554943594d6d6574577a6e484575",
            RefreshToken: "4a4d6d7664775a6e5544574c44675172");
#endif

    }
}
