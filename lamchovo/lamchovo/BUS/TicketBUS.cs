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
    }
}
