using System.Data;
using lamchovo.DTO;

namespace lamchovo.DAO
{
    class TypeTicketDAO
    {
        static public DataTable Select()
        {
            string sql = "select * from TypeTicket ORDER BY ID asc";
            return DataAccess.ExcuQuery(sql);
        }
        public static TypeTicketDTO Select(int _s)
        {
            string sql = "select * from TypeTicket where ID=" + _s + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TypeTicketDTO tl = new TypeTicketDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.typet = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static void Insert(TypeTicketDTO item)
        {
            string sql = "insert into TypeTicket(typet) values('" + item.typet + "')";
            DataAccess.ExcuNonQuery(sql);
        }
    }
}
