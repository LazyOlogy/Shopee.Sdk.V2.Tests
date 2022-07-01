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

            Trace.Write(client.GetShopAuthorizationUrl("https://www.google.com.tw"));
        }


        [TestMethod()]
        public void CancelShopAuthorizationUrlTest()
        {

            Trace.Write(client.CancelShopAuthorizationUrl("https://www.google.com.tw"));
        }

        [TestMethod()]
        public void GetAccessTokenTest()
        {
            string Code = "496567576872516f6753527a49436668";
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