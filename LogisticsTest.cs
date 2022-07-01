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
        /// <summary>
        /// 使用此 api 獲取發貨參數
        /// </summary>
        [TestMethod()]
        public void GetShippingParameterTest()
        {
            var r = client.GetShippingParameter(OrderSn);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 API 啟動物流，包括為非整合物流管道安排取件、投遞或裝運。應該調用v2.logistics.get_shipping_parameter首先獲取所有必需的參數。建議在下訂單后一小時啟動物流，因為有一個小時的視窗，買家可以在沒有向賣家請求的情況下取消任何訂單。
        /// </summary>
        [TestMethod()]
        public void ShipOrderTest()
        {
            var r = client.ShipOrder(OrderSn, Dropoff: new Models.Logistics.ShipOrder.ShipOrderRequest.Dropoff(sender_real_name: "王小明"));


            //var r = client.ShipOrder(OrderSn,Pickup:new Models.Logistics.ShipOrder.ShipOrderRequest.Pickup(22981,null,null));

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 api 獲取tracking_number何時收到發貨訂單。
        /// </summary>
        [TestMethod()]
        public void GetTrackingNumberTest()
        {
            var r = client.GetTrackingNumber(OrderSn);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 api 獲取可選shipping_document_type和建議的shipping_document_type
        /// </summary>
        [TestMethod()]
        public void GetShippingDocumentParameterTest()
        {
            var r = client.GetShippingDocumentParameter(new List<Models.Logistics.GetShippingDocumentParameter.GetShippingDocumentParameterOrderRequest.Order> {
                 new Models.Logistics.GetShippingDocumentParameter.GetShippingDocumentParameterOrderRequest.Order(OrderSn)
            });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 獲取訂單的物流跟蹤資訊
        /// </summary>
        [TestMethod()]
        public void GetTrackingInfoTest()
        {
            var r = client.GetTrackingInfo(OrderSn);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 對於整合物流管道，請使用此呼叫獲取取件模式訂單的取件位址
        /// </summary>
        [TestMethod()]
        public void GetAddressListTest()
        {
            var r = client.GetAddressList();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 API 獲取所有受支援的物流管道
        /// </summary>
        [TestMethod()]
        public void GetChannelListTest()
        {
            var r = client.GetChannelList();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 API 為每個訂單或包裹創建裝運單據任務
        /// </summary>
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

