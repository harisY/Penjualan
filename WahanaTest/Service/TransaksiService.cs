using Penjualan.Areas.Admin.Models;
using Penjualan.Helper;
using Penjualan.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Penjualan.Service
{
    public class TransaksiService : ITransaksi
    {
        public List<TransaksiModel> Get()
        {
            try
            {
                DataTable dt = new DataTable();
                List<TransaksiModel> list = new List<TransaksiModel>();
                dt = SqlHelper.GetDatatableSync(SqlHelper.strConn, "usp_transaksiSelect", null, CommandType.StoredProcedure);
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new TransaksiModel
                    {
                        no_transaksi = row["no_transaksi"].AsString(),
                        tanggal = row["tanggal"].AsDateTime(),
                        total = row["total"].AsFloat(),
                        created_at = row["created_at"].AsDateTime()
                    });
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}