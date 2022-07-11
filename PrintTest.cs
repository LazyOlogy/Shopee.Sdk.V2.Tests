using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopeeSdkV2;
using ShopeeSdkV2Tests;
using System.Diagnostics;
using System.Web.Script.Serialization;


namespace ShopeeSdkV2.Tests
{
    [TestClass()]
    public class PrintTest : Core
    {   


        [TestMethod()]
        public void Print711Test()
        {
            string trackNo = "G02934869745";
            client.產生711出貨單PDF(trackNo, $"W:\\出貨單/{trackNo}.pdf");
        }


        [TestMethod()]
        public void PrintHiLifeTest()
        {
            string trackNo = "2MBH58540203";
            client.產生萊爾富出貨單PDF(trackNo, $"W:\\出貨單/{trackNo}.pdf");
        }

        [TestMethod()]
        public void PrintFMTest()
        {
            string OrderSn = "2207116RR6A64Q";
            client.產生全家出貨單PDF(OrderSn, $"W:\\出貨單/{OrderSn}.pdf");
        }

        [TestMethod()]
        public void PrintShopeeTest()
        {
            string OrderSn = "2207116RS5RTXS";
            client.產生蝦皮店到店出貨單PDF(OrderSn, $"W:\\出貨單/{OrderSn}.pdf");
        }

        [TestMethod()]
        public void PrintOKTest()
        {
            string OrderSn = "2207116RT3BU5M";
            client.產生OK店到店出貨單PDF(OrderSn, $"W:\\出貨單/{OrderSn}.pdf");
        }







    }
}