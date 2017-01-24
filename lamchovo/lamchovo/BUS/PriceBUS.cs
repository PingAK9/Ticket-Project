using lamchovo.DAO;
using lamchovo.DTO;
using System.Data;

namespace lamchovo.BUS
{
    class PriceBUS
    {
        static public DataTable Select()
        {
            return PriceDAO.Select();
        }
        static public PriceDTO Select(int s)
        {
            return PriceDAO.Select(s);
        }
        public static bool Insert(PriceDTO item)
        {
            if (PriceDAO.Select(item.price) == null)
            {
                PriceDAO.Insert(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(PriceDTO item)
        {
            return PriceDAO.Delete(item);
        }
    }
}
