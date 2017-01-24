using System.Data;
using lamchovo.DTO;

namespace lamchovo.DAO
{
    class FileDAO
    {
        static public DataTable Select()
        {
            string sql = "select * from File";
            return DataAccess.ExcuQuery(sql);
        }
        public static FileDTO Select(int _s)
        {
            string sql = "select * from File where ID=" + _s + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                FileDTO tl = new FileDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.file = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static FileDTO Select(string _s)
        {
            string sql = "select * from File where filet='" + _s + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                FileDTO tl = new FileDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.file = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static void Insert(FileDTO item)
        {
            string sql = "insert into File(filet) values('" + item.file + "')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(FileDTO item)
        {
            string sql = "update  File set "
                + " filet = '" + item.file + "'"
                + " where ID = " + item.ID + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(int item)
        {
            try
            {
                string sql = "delete from File where ID = " + item + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void DeleteAll()
        {
            string sql = "delete from File";
            DataAccess.ExcuNonQuery(sql);
        }
    }
}
