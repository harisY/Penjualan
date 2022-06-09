using Penjualan.Areas.Admin.Models;
using Penjualan.Helper;
using Penjualan.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Penjualan.Service
{
    public class GlobalService : IGlobal
    {
        //private static Db db = new Db();

        //public List<ComboBoxModel> GetBrand()
        //{
        //    string Query = @"SELECT BrandID as Value, Brand_Name  as Text FROM Brand ORDER BY Brand_Name ASC";
        //    return db.Read(Query, CommandType.Text, Make).ToList();
        //}

        //public List<ComboBoxModel> GetCustomer()
        //{
        //    string Query = @"SELECT CustID as Value, Cust_Name  as Text FROM Customer ORDER BY Cust_Name ASC";
        //    return db.Read(Query, CommandType.Text, Make).ToList();
        //}

        //public List<ComboBoxModel> GetInventory(string BrandId)
        //{
        //    string Query = @"SELECT InvtID as Value, Invt_Name  as Text FROM Inventory WHERE BrandID =@BrandId ORDER BY Invt_Name ASC";
        //    object[] Params = { "@BrandId", BrandId };
        //    return db.Read(Query, CommandType.Text, Make, Params).ToList();
        //}

        //public List<ComboBoxModel> GetWorkCenter()
        //{
        //    string Query = @"SELECT WcID as Value, Wc_Name  as Text FROM Work_Center ORDER BY Wc_Name ASC";
        //    return db.Read(Query, CommandType.Text, Make).ToList();
        //}

        //public List<ComboBoxModel> GetUnit()
        //{
        //    string Query = @"SELECT UnitID as Value, Unit_Name  as Text FROM Unit ORDER BY Unit_Name ASC";
        //    return db.Read(Query, CommandType.Text, Make).ToList();
        //}
        //public List<ComboBoxModel> GetProductClass()
        //{
        //    string Query = @"SELECT Product_ClassID as Value, Class_Name  as Text FROM Product_Class ORDER BY Class_Name ASC";
        //    return db.Read(Query, CommandType.Text, Make).ToList();
        //}
        //public string GetUnitByInvtId(string InvtId)
        //{
        //    string Query = @"Select U.Unit_Name from Inventory I 
        //                    inner join Unit U on I.UnitID = U.UnitID
        //                    Where I.InvtID  =@InvtId";
        //    object[] Params = { "@InvtId", InvtId };
        //    return db.Scalar(Query, CommandType.Text, Params).AsString();
        //}

        //public List<ComboBoxModel> GetVendor()
        //{
        //    string Query = @"SELECT VendID as Value, VendName  as Text FROM Vendor ORDER BY VendName ASC";
        //    return db.Read(Query, CommandType.Text, Make).ToList();
        //}

        //private static readonly Func<IDataReader, ComboBoxModel> Make = reader =>
        //      new ComboBoxModel
        //      {
        //          Value = reader["Value"].AsString(),
        //          Text = reader["Text"].AsString()
        //      };
    }
}