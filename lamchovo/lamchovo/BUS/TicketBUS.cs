using System;
using System.Collections.Generic;
using System.Data;
using lamchovo.DTO;
using lamchovo.DAO;

namespace lamchovo.BUS
{
    class TicketBUS
    {
        static public DataTable Select()
        {
            return TicketDAO.Select();
        }
        static public TicketDTO Select(int ID)
        {
            return TicketDAO.Select(ID);
        }
        public static bool Insert(TicketDTO item1)
        {
            PriceDTO _price = new PriceDTO();
            _price.price = item1.price;
            PriceBUS.Insert(_price);
            //
            TicketDAO.Insert(item1);
            return true;
        }
        public static bool Update(TicketDTO item)
        {
            if (TicketDAO.Select(item.ID) != null)
            {
                TicketDAO.Update(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(int _id)
        {
            return TicketDAO.Delete(_id);
        }
        public static void DeleteAll()
        {
            TicketDAO.DeleteAll();
        }
        // Report
        static public DataTable ReportTicket(DateTime _date1, DateTime _date2)
        {
            return TicketDAO.ReportTicket(_date1, _date2);
        }
        static public DataTable ReportTicket(DateTime _date1, DateTime _date2, int _type)
        {
            return TicketDAO.ReportTicket(_date1, _date2, _type);
        }
        // Select TOTAL
        static public DataTable SelectFileTotal(int _fileName, int _type)
        {
            return TicketDAO.SelectFileTotal(_fileName, _type);
        }
        static public DataTable SelectDayTicketTotal(DateTime _from, DateTime _to, int _type)
        {
            return TicketDAO.SelectDayTicketTotal(_from, _to, _type);
        }
        static public DataTable SelectDayTicketTotal(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            return TicketDAO.SelectDayTicketTotal(_from, _to, _type, _client);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _from, DateTime _to, int _type)
        {
            return TicketDAO.SelectDayOnTicketTotal(_from, _to, _type);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            return TicketDAO.SelectDayOnTicketTotal(_from, _to, _type, _client);
        }
        static public DataTable SelectFileTotal(int _fileName)
        {
            return TicketDAO.SelectFileTotal(_fileName);
        }
        static public DataTable SelectDayTicketTotal(DateTime _from, DateTime _to)
        {
            return TicketDAO.SelectDayTicketTotal(_from, _to);
        }
        static public DataTable SelectDayTicketTotal(DateTime _from, DateTime _to, List<int> _client)
        {
            return TicketDAO.SelectDayTicketTotal(_from, _to, _client);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _from, DateTime _to)
        {
            return TicketDAO.SelectDayOnTicketTotal(_from, _to);
        }
        static public DataTable SelectDayOnTicketTotal(DateTime _from, DateTime _to, List<int> _client)
        {
            return TicketDAO.SelectDayOnTicketTotal(_from, _to, _client);
        }
        // Select to show
        static public DataTable SelectFile(int _fileName, int _type)
        {
            return TicketDAO.SelectFile(_fileName, _type);
        }
        static public DataTable SelectDayTicket(DateTime _from, DateTime _to, int _type)
        {
            return TicketDAO.SelectDayTicket(_from, _to, _type);
        }
        static public DataTable SelectDayTicket(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            return TicketDAO.SelectDayTicket(_from, _to, _type, _client);
        }
        static public DataTable SelectDayOnTicket(DateTime _from, DateTime _to, int _type)
        {
            return TicketDAO.SelectDayOnTicket(_from, _to, _type);
        }
        static public DataTable SelectDayOnTicket(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            return TicketDAO.SelectDayOnTicket(_from, _to, _type, _client);
        }
        static public DataTable SelectFile(int _fileName)
        {
            return TicketDAO.SelectFile(_fileName);
        }
        static public DataTable SelectDayTicket(DateTime _from, DateTime _to)
        {
            return TicketDAO.SelectDayTicket(_from, _to);
        }
        static public DataTable SelectDayTicket(DateTime _from, DateTime _to, List<int> _client)
        {
            return TicketDAO.SelectDayTicket(_from, _to, _client);
        }
        static public DataTable SelectDayOnTicket(DateTime _from, DateTime _to)
        {
            return TicketDAO.SelectDayOnTicket(_from, _to);
        }
        static public DataTable SelectDayOnTicket(DateTime _from, DateTime _to, List<int> _client)
        {
            return TicketDAO.SelectDayOnTicket(_from, _to, _client);
        }
        // select to export
        static public DataTable SelectFileExport(int _fileName, int _type)
        {
            return TicketDAO.SelectFileExport(_fileName, _type);
        }
        static public DataTable SelectDayTicketExport(DateTime _from, DateTime _to, int _type)
        {
            return TicketDAO.SelectDayTicketExport(_from, _to, _type);
        }
        static public DataTable SelectDayTicketExport(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            return TicketDAO.SelectDayTicketExport(_from, _to, _type, _client);
        }
        static public DataTable SelectDayOnTicketExport(DateTime _from, DateTime _to, int _type)
        {
            return TicketDAO.SelectDayOnTicketExport(_from, _to, _type);
        }
        static public DataTable SelectDayOnTicketExport(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            return TicketDAO.SelectDayOnTicketExport(_from, _to, _type, _client);
        }
        // delete
        static public void DeleteFile(int _fileName)
        {
            TicketDAO.DeleteFile(_fileName);
        }
        static public void DeleteDayTicket(DateTime _from, DateTime _to, int _type)
        {
            TicketDAO.DeleteDayTicket(_from, _to, _type);
        }
        static public void DeleteDayTicket(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            TicketDAO.DeleteDayTicket(_from, _to, _type, _client);
        }
        static public void DeleteDayOnTicket(DateTime _from, DateTime _to, int _type)
        {
            TicketDAO.DeleteDayOnTicket(_from, _to, _type);
        }
        static public void DeleteDayOnTicket(DateTime _from, DateTime _to, int _type, List<int> _client)
        {
            TicketDAO.DeleteDayOnTicket(_from, _to, _type, _client);
        }
    }
}
