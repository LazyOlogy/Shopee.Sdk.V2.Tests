using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopeeSdkV2Tests;
using System;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace ShopeeSdkV2.Tests
{



    [TestClass()]
    public class OrderTest : Core
    {

        /// <summary>
        /// 使用此 API 搜尋訂單
        /// </summary>
        [TestMethod()]
        public void GetOrdersListTest()
        {
            var r = client.GetOrdersList(Models.Order.GetOrderList.EnumTimeRangeField.create_time,
                 DateTime.Now.AddDays(-10), DateTime.Now, OrderStatus: Models.Order.EnumOrderStatus.READY_TO_SHIP);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 api 獲取READY_TO_SHIP order_status的訂單清單。
        /// </summary>
        [TestMethod()]
        public void GetShipmentListTest()
        {
            var r = client.GetShipmentList();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 API 獲取訂單詳細資訊。
        /// </summary>
        [TestMethod()]
        public void GetOrderDetailTest()
        {
            var r = client.GetOrderDetail(new string[] { OrderSn });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }


        /// <summary>
        /// 使用此 API 取消訂單。
        /// </summary>
        [TestMethod()]
        public void CancelOrderTest()
        {
            var r = client.CancelOrder(OrderSn, Models.Order.EnumOrderCancelReason.CUSTOMER_REQUEST);

            Trace.Write(new JavaScriptSerializer().Serialize(r)); ;
        }

        /// <summary>
        /// 使用此 api 為訂單設置註釋。
        /// </summary>
        [TestMethod()]
        public void SetNoteTest()
        {
            var r = client.SetNote(OrderSn, "NoteTest");

            Trace.Write(new JavaScriptSerializer().Serialize(r)); ;
        }
    }
}

