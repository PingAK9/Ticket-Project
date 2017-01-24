using System.Data;
using lamchovo.DTO;
using lamchovo.DAO;

namespace lamchovo.BUS
{
    class TypeTicketBUS
    {
        static public DataTable Select()
        {
            return TypeTicketDAO.Select();
        }
        public static bool Insert(TypeTicketDTO item)
        {
            TypeTicketDAO.Insert(item);
            return true;
        }
    }
}
