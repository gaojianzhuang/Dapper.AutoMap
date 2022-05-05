using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.AutoMap
{
    public class SqlBuilderTemplate
    {
        public const string SQL_SELECT_TEMPLATE = "SELECT {0} FROM {1};";
        public const string SQL_SELECTWHERE_TEMPLATE = "SELECT {0} FROM {1} WHERE {2};";

        public const string SQL_UPDATE_TEMPLATE = "UPDATE {0} SET {1};";
        public const string SQL_UPDATEWHERE_TEMPLATE = "UPDATE {0} SET {1} WHERE {2};";

        public const string SQL_INSERT_TEMPLATE = "INSERT INTO {0}({1}) VALUES({2});";
        public const string SQL_INSERTSET_TEMPLATE = "INSERT INTO {0} SET {1};";

        public const string SQL_DELETE_TEMPLATE = "DELETE FROM {0};";
        public const string SQL_DELETEWHERE_TEMPLATE = "DELETE FROM {0} WHERE {1};";
    }
}
