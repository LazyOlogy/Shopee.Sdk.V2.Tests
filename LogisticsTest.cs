using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopeeSdkV2Tests;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace ShopeeSdkV2.Tests
{



    [TestClass()]
    public class LogisticsTest : Core
    {

        [TestMethod()]
        public void GetShippingParameterTest()
        {
            var r = client.GetShippingParameter(OrderSn);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void ShipOrderTest()
        {
            var r = client.ShipOrder(OrderSn, Dropoff: new Models.Logistics.ShipOrder.ShipOrderRequest.Dropoff(sender_real_name: "王小明"));


            //var r = client.ShipOrder(OrderSn,Pickup:new Models.Logistics.ShipOrder.ShipOrderRequest.Pickup(22981,null,null));

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetTrackingNumberTest()
        {
            var r = client.GetTrackingNumber(OrderSn);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetShippingDocumentParameterTest()
        {
            var r = client.GetShippingDocumentParameter(new List<Models.Logistics.GetShippingDocumentParameter.GetShippingDocumentParameterOrderRequest.Order> {
                 new Models.Logistics.GetShippingDocumentParameter.GetShippingDocumentParameterOrderRequest.Order(OrderSn)
            });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetTrackingInfoTest()
        {
            var r = client.GetTrackingInfo(OrderSn);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetAddressListTest()
        {
            var r = client.GetAddressList();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetChannelListTest()
        {
            var r = client.GetChannelList();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void CreateShippingDocumentTest()
        {
            var r = client.CreateShippingDocument(new List<Models.Logistics.CreateShippingDocument.CreateShippingDocumentRequest.Order> {
                 new Models.Logistics.CreateShippingDocument.CreateShippingDocumentRequest.Order(OrderSn)
            });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }
    }
}

