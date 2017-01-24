using lamchovo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamchovo.DAO
{
    class PriceDAO
    {
        static public DataTable Select()
        {
            string sql = "select * from Price ORDER BY pricet asc";
            return DataAccess.ExcuQuery(sql);
        }
        public static PriceDTO Select(int value)
        {
            string sql = "select * from Price where pricet=" + value + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PriceDTO tl = new PriceDTO();
                tl.price = (int)dt.Rows[0].ItemArray[0];
                return tl;
            }

        }
        public static void Insert(PriceDTO item)
        {
            string sql = "insert into Price(pricet) values(" + item.price + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(PriceDTO item)
        {
            try
            {
                string sql = "delete from Price where pricet = " + item.price + "";
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
