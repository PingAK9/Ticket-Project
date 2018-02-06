using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using lamchovo.DTO;

namespace lamchovo.DAO
{
    class TicketDAO
    {
       
        static public DataTable Select()
        {
            string sql = "select * from Ticket";
            return DataAccess.ExcuQuery(sql);
        }
        public static TicketDTO Select(int ID)
        {
            string sql = "select * from Ticket where ID=" + ID + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TicketDTO tl = new TicketDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.day = (DateTime)dt.Rows[0].ItemArray[1];
                tl.count = (int)dt.Rows[0].ItemArray[2];
                tl.price = (int)dt.Rows[0].ItemArray[3];
                tl.client = (int)dt.Rows[0].ItemArray[4];
                tl.file = (int)dt.Rows[0].ItemArray[5];
                tl.type = (int)dt.Rows[0].ItemArray[6];
                tl.dayon = (DateTime)dt.Rows[0].ItemArray[7];
                tl.tsn = (bool)dt.Rows[0].ItemArray[8];
                return tl;
            }

        }
        public static TicketDTO Select(DateTime day, int price, int client, int file, int type, DateTime dayon)
        {
            string sql = "select * from Ticket where " 
                + " ((dayt= DateValue('" + day.ToShortDateString() + "'))"
                + " and ( pricet=" + price +")"
                + " and ( clientt= " + client + ")"
                + " and ( filet=" + file + ")"
                + " and ( typet=" + type + ")"
                + " and (dayont = DateValue('" + day.ToShortDateString() + "')))";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TicketDTO tl = new TicketDTO();
                tl.ID = (int)dt.Rows[0].ItemArray[0];
                tl.day = (DateTime)dt.Rows[0].ItemArray[1];
                tl.count = (int)dt.Rows[0].ItemArray[2];
                tl.price = (int)dt.Rows[0].ItemArray[3];
                tl.client = (int)dt.Rows[0].ItemArray[4];
                tl.file = (int)dt.Rows[0].ItemArray[5];
                tl.type = (int)dt.Rows[0].ItemArray[6];
                tl.dayon = (DateTime)dt.Rows[0].ItemArray[7];
                tl.tsn = (bool)dt.Rows[0].ItemArray[8];
                return tl;
            }

        }
        public static void Update(TicketDTO item)
        {
            string sql = "update  Ticket set " 
                + " dayt = '" + item.day.ToShortDateString() + "',"
                + " countt = " + item.count + "," 
                + " pricet = " + item.price + ","
                + " clientt = " + item.client + ","
                + " filet = " + item.file + ","
                + " typet = " + item.type + ","
                + " tsnt = " + item.tsn + ","
                + " dayont = '" + item.dayon.ToShortDateString() + "'"
                + " where ID = " + item.ID + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Insert(TicketDTO item)
        {
            string sql = "insert into Ticket(dayt,countt,pricet,clientt,filet,typet,tsnt,dayont) values("
                + "'" + item.day.ToShortDateString() + "',"
                + item.count + ","
                + item.price + ","
                + "" + item.client + ","
                + "" + item.file + ","
                + "" + item.type + ","
                + "" + item.tsn + ","
                + "'" + item.dayon.ToShortDateString() + "'"
                + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(int _id)
        {
            try
            {
                string sql = "delete from Ticket where ID = " + _id + "";
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
            string sql = "delete from Ticket";
            DataAccess.ExcuNonQuery(sql);
        }
        
        //______________________________________________________________//
        static string loop(List<int> _client)
        {
            string _loop = " (";
            for (int i = 0; i < (_client.Count - 1); i++
                )
            {
                _loop += " clientt = " + _client[i] + " or ";
            }
            _loop += " clientt = " + _client[_client.Count - 1] + ")";
            return _loop;
        }

        // Select TOTAL
        static public DataTable ReportTicket(DateTime _date1, DateTime _date2)
        {
            string sql = "select sum(countt) as totalCountt, sum(pricet * countt) as totalPricet, typet, clientt from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "')"
                + " AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " group by clientt, typet ORDER BY clientt asc";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable ReportTicket(DateTime _date1, DateTime _date2, int _type)
        {
            string sql = "select sum(countt) as totalCountt, sum(pricet * countt) as totalPricet, typet, clientt  from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "')"
                + " AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + " group by clientt, typet ORDER BY clientt asc";
            return DataAccess.ExcuQuery(sql);
        }
        // Select TOTAL
        static public DataTable SelectFileTotal(int _fileName, int _type, int _typePrice)
        {
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE"
                + " filet = " + _fileName 
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicketTotal(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "')"
                + " AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicketTotal(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayTicketTotal(_date1, _date2, _type, _typePrice);
            }
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                 + " and typet = " + _type + ""
                 + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayOnTicketTotal(_date1, _date2, _type, _typePrice);
            }
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectFileTotal(int _fileName, int _typePrice)
        {
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE filet = " + _fileName + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicketTotal(DateTime _date1, DateTime _date2, int _typePrice)
        {
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "')"
                + " AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicketTotal(DateTime _date1, DateTime _date2, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayTicketTotal(_date1, _date2, _typePrice);
            }
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _date1, DateTime _date2, int _typePrice)
        {
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _date1, DateTime _date2, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayOnTicketTotal(_date1, _date2, _typePrice);
            }
            string sql = "select sum(countt), sum(pricet * countt) from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        // Select *
        static public DataTable SelectFile(int _fileName, int _type, int _typePrice)
        {
            string sql = "select * from Ticket WHERE filet = " + _fileName 
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicket(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "select * from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicket(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayTicket(_date1, _date2, _type, _typePrice);
            }
            string sql = "select * from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicket(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "select * from Ticket WHERE dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicket(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayOnTicket(_date1, _date2, _type, _typePrice);
            }
            string sql = "select * from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }

        static public DataTable SelectFile(int _fileName, int _typePrice)
        {
            string sql = "select * from Ticket WHERE filet = " + _fileName + ""
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicket(DateTime _date1, DateTime _date2, int _typePrice)
        {
            string sql = "select * from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicket(DateTime _date1, DateTime _date2, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayTicket(_date1, _date2, _typePrice);
            }
            string sql = "select * from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicket(DateTime _date1, DateTime _date2, int _typePrice)
        {
            string sql = "select * from Ticket WHERE dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice);
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicket(DateTime _date1, DateTime _date2, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayOnTicket(_date1, _date2, _typePrice);
            }
            string sql = "select * from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            return DataAccess.ExcuQuery(sql);
        }
        // Select dayt,countt,pricet to Export
        static public DataTable SelectFileExport(int _fileName, int _type, int _typePrice)
        {
            string sql = "select FORMAT(dayt,'MM/DD/YYYY') AS ShortDate,pricet,sum(countt) from Ticket WHERE "
                + " filet = " + _fileName + "" 
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " group by dayt, pricet ORDER BY dayt asc";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicketExport(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "select FORMAT(dayt,'MM/DD/YYYY') AS ShortDate,pricet,sum(countt) from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " group by dayt, pricet ORDER BY dayt asc";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayTicketExport(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayTicketExport(_date1, _date2, _type, _typePrice);
            }
            string sql = "select FORMAT(dayt,'MM/DD/YYYY') AS ShortDate,pricet,sum(countt) from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')" + " AND " + loop(_client)
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " group by dayt, pricet ORDER BY dayt asc";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicketExport(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "select FORMAT(dayt,'MM/DD/YYYY') AS ShortDate,pricet,sum(countt) from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " group by dayt, pricet ORDER BY dayt asc";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectDayOnTicketExport(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                return SelectDayOnTicketExport(_date1, _date2, _type, _typePrice);
            }
            string sql = "select FORMAT(dayt,'MM/DD/YYYY') AS ShortDate,pricet,sum(countt) from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')" + "AND " + loop(_client)
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " group by dayt, pricet ORDER BY dayt asc";
            return DataAccess.ExcuQuery(sql);
        }

        // Delete 
        static public void DeleteFile(int _fileName)
        {
            string sql = "delete from Ticket WHERE filet = " + _fileName + "";
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayTicket(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "delete from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayTicket(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                DeleteDayTicket(_date1, _date2, _type, _typePrice);
                return;
            }
            string sql = "delete from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayOnTicket(DateTime _date1, DateTime _date2, int _type, int _typePrice)
        {
            string sql = "delete from Ticket WHERE"
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayOnTicket(DateTime _date1, DateTime _date2, int _type, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                DeleteDayOnTicket(_date1, _date2, _type, _typePrice);
                return;
            }
            string sql = "delete from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + " and typet = " + _type + ""
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayTicket(DateTime _date1, DateTime _date2,  int _typePrice)
        {
            string sql = "delete from Ticket WHERE"
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayTicket(DateTime _date1, DateTime _date2, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                DeleteDayTicket(_date1, _date2, _typePrice);
                return;
            }
            string sql = "delete from Ticket WHERE "
                + " dayt >= DateValue('" + _date1.ToShortDateString() + "') AND dayt <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayOnTicket(DateTime _date1, DateTime _date2, int _typePrice)
        {
            string sql = "delete from Ticket WHERE"
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice);
            DataAccess.ExcuNonQuery(sql);
        }
        static public void DeleteDayOnTicket(DateTime _date1, DateTime _date2, List<int> _client, int _typePrice)
        {
            if (_client == null || _client.Count == 0)
            {
                DeleteDayOnTicket(_date1, _date2, _typePrice);
                return;
            }
            string sql = "delete from Ticket WHERE "
                + " dayont >= DateValue('" + _date1.ToShortDateString() + "') AND dayont <= DateValue('" + _date2.ToShortDateString() + "')"
                + GetTypePrice(_typePrice)
                + " and " + loop(_client);
            DataAccess.ExcuNonQuery(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typePrice"></param>
        /// <returns></returns>
        static string GetTypePrice(int typePrice)
        {
            string _value = "";
            switch (typePrice)
            {
                case 1: // < 10tr
                    _value = " and pricet < 10000000 and tsnt = false";
                    break;
                case 2: // >= 10tr
                    _value = " and pricet >= 10000000 and tsnt = false";
                    break;
                case 3: // tsn
                    _value = " and tsnt = true";
                    break;
                default:
                    _value = "";
                    break;
            }
            return _value;
        }
    }
}
