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


        [TestMethod()]
        public void GetOrdersListTest()
        {
            var r = client.GetOrdersList(Models.Order.GetOrderList.EnumTimeRangeField.create_time,
                 DateTime.Now.AddDays(-1), DateTime.Now);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetShipmentListTest()
        {
            var r = client.GetShipmentList();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetOrderDetailTest()
        {
            var r = client.GetOrderDetail(new string[] { OrderSn });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void CancelOrderTest()
        {
            var r = client.CancelOrder(OrderSn, Models.Order.EnumOrderCancelReason.CUSTOMER_REQUEST);

            Trace.Write(new JavaScriptSerializer().Serialize(r)); ;
        }

        [TestMethod()]
        public void SetNoteTest()
        {
            var r = client.SetNote(OrderSn, "NoteTest");

            Trace.Write(new JavaScriptSerializer().Serialize(r)); ;
        }
    }
}

