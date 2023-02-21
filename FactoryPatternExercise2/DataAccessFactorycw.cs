using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string databaseType)
        {
            switch (databaseType.ToLower())
                {
                case "list":
                    return new ListDataAccess();
                        case "sql":
                            return new MySQLDataAccess();
                        case "mongo":
                    return new MongoDBDataAccess();
                    default:
                    return  new ListDataAccess();

                }
        
        }
    }
}
