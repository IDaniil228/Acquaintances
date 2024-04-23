using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartFluttering
{
    public static class AdministratorTable
    {
        public static DataTable GetDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            return table;
        }
    }
}
