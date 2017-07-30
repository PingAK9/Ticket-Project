using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using lamchovo.DTO;
using lamchovo.DAO;

namespace lamchovo.BUS
{
    class ClientBUS
    {
        static public DataTable Select()
        {
            return ClientDAO.Select();
        }
        public static bool Insert(ClientDTO item)
        {
            if (ClientDAO.Select(item.client) == null)
            {
                ClientDAO.Insert(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Update(ClientDTO item)
        {
            ClientDAO.Update(item);
            return true;
        }
        public static bool Delete(int item)
        {
            return ClientDAO.Delete(item);
        }
    }
}
