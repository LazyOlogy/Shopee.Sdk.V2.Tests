using Microsoft.VisualStudio.TestTools.UnitTesting;

using ShopeeSdkV2Tests;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace ShopeeSdkV2.Tests
{
    [TestClass()]
    public class ShopTest : Core
    {




        [TestMethod()]
        public void GetShopAuthorizationUrlTest()
        {

            Trace.Write(client.GetShopAuthorizationUrl(Webhook));
        }


        [TestMethod()]
        public void CancelShopAuthorizationUrlTest()
        {

            Trace.Write(client.CancelShopAuthorizationUrl("https://www.google.com.tw"));
        }

        [TestMethod()]
        public void GetAccessTokenTest()
        {
            string Code = "794f564f426164657278624b73466d66";
            client = new Client(PartnerId, ShopId, Key);
            var r = client.GetAccesstoken(Code);
            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }


        [TestMethod()]
        public void RefreshAccessTokenTest()
        {

            var r = client.RefreshAccessToken();
            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetShopInfoTest()
        {
            var r = client.GetShopInfo();
            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }



    }
}