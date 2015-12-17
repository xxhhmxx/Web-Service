using Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CT_DHService" in both code and config file together.
    public class CT_DHService : ICT_DHService
    {
        public List<CT_DonDH> HienThiCT_DonDH(CT_DonDH ct)
        {
            List<CT_DonDH> data = new List<CT_DonDH>();

            string sql = "select MaDonDH,sp.SP_ID,DonGiaDat,SoLuongDat from CT_DonDH ct, SanPham sp where ct.SP_ID=sp.SP_ID and MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ct.MaDonDH);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, madondh);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    ct = new CT_DonDH()
                    {
                        MaDonDH = int.Parse(rd[0].ToString()),
                        SP_ID = int.Parse(rd[1].ToString()),
                        DonGiaDat = int.Parse(rd[2].ToString()),
                        SoLuongDat = int.Parse(rd[3].ToString()),

                    };
                    data.Add(ct);
                }
            }
            return data;
        }

        public void Xoa(CT_DonDH ct)
        {
            string sql = "Delete CT_DonDH where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ct.MaDonDH);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, madondh);
        }
    }
}
