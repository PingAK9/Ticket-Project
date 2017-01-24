using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using lamchovo.DTO;
using System.Web;
namespace lamchovo.DAO
{
    class ClientDAO
    {
        static public DataTable Select()
        {
            string sql = "select * from Client";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectTrim()
        {
            string sql = "select * from Client where clientt <> 'All'";
            return DataAccess.ExcuQuery(sql);
        }
        public static ClientDTO Select(int _s)
        {
            string sql = "select * from Client where ID=" + _s + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                ClientDTO tl = new ClientDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.client = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static ClientDTO Select(string _s)
        {
            string sql = "select * from Client where clientt='" + _s + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                ClientDTO tl = new ClientDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.client = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static void Insert(ClientDTO item)
        {
            string sql = "insert into Client(clientt) values('" + item.client + "')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(ClientDTO item)
        {
            string sql = "update Client set "
                + " clientt = '" + item.client + "'"
                + " where ID = " + item.ID + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(int item)
        {
            try
            {
                string sql = "delete from Client where ID = " + item + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
