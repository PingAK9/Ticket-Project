using lamchovo.DAO;
using lamchovo.DTO;
using System.Data;

namespace lamchovo.BUS
{
    class FileBUS
    {
        static public DataTable Select()
        {
            return FileDAO.Select();
        }
        static public FileDTO Select(string _name)
        {
            return FileDAO.Select(_name);
        }
        public static bool Insert(FileDTO item)
        {
            if (FileDAO.Select(item.file) == null)
            {
                FileDAO.Insert(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Update(FileDTO item)
        {
            FileDAO.Update(item);
            return true;
        }
        public static bool Delete(int item)
        {
            return FileDAO.Delete(item);
        }
        public static void  DeleteAll()
        {
            FileDAO.DeleteAll();
        }
    }
}
