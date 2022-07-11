using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopeeSdkV2Tests;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace ShopeeSdkV2.Tests
{



    [TestClass()]
    public class ProductTest : Core
    {

        /// <summary>
        /// 獲取類別
        /// </summary>
        [TestMethod()]
        public void GetCategoryTest()
        {
            var r = client.GetCategory();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 獲取屬性
        /// </summary>
        [TestMethod()]
        public void GetAttributesTest()
        {
            var r = client.GetAttributes(100728);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此調用可獲取品牌清單
        /// </summary>
        [TestMethod()]
        public void GetBrandListTest()
        {
            var r = client.GetBrandList(100728, 1);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 獲得每日發貨限制
        /// </summary>
        [TestMethod()]
        public void GetDtsLimitTest()
        {
            var r = client.GetDtsLimit(100728);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 獲取商品限制
        /// </summary>
        [TestMethod()]
        public void GetItemLimitTest()
        {
            var r = client.GetItemLimit();

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此調用可以獲取項的清單
        /// </summary>
        [TestMethod()]
        public void GetItemListTest()
        {
            var r = client.GetItemList(new List<Models.Product.GetItemList.EnumItemStatus> {
                Models.Product.GetItemList.EnumItemStatus.NORMAL
            });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 api 按列表獲取商品的基本資訊item_id
        /// </summary>
        [TestMethod()]
        public void GetItemBaseInfoTest()
        {
            var r = client.GetItemBaseInfo(new List<long> { 1792878 });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 使用此 api 按清單獲取專案item_id額外資訊
        /// </summary>
        [TestMethod()]
        public void GetItemExtraInfoTest()
        {
            var r = client.GetItemExtraInfo(new List<long> { 1792878 });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 更新庫存
        /// </summary>
        [TestMethod()]
        public void UpdateStockTest()
        {
            var r = client.UpdateStock(1789772, new List<Models.Product.UpdateStock.UpdateStockRequest.Stock> {
                new Models.Product.UpdateStock.UpdateStockRequest.Stock(999,seller_stock:new List<Models.Product.UpdateStock.UpdateStockRequest.Stock.SellerStock>{ 
                    new Models.Product.UpdateStock.UpdateStockRequest.Stock.SellerStock(999)
                })
            });

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        /// <summary>
        /// 搜尋商品
        /// </summary>
        [TestMethod()]
        public void SearchItemTest()
        {
            var r = client.SearchItem(ItemName: "男士長大衣");

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }

        [TestMethod()]
        public void GetModelListTest()
        {
            var r = client.GetModelList(1792878);

            Trace.Write(new JavaScriptSerializer().Serialize(r));
        }
    }
}

