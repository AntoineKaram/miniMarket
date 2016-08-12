using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Base
{
    public interface IDbManager
    {

        IDbConnection GetConnection(string connectionString);
        IDbCommand GetCommand(string procedureName, IDbConnection con, Dictionary<string, string> paramsDictionnary = null);

        bool ExecuteCommand(string procedureName, Dictionary<string, string> paramsDictionnary = null);

        List<T> ExecuteCollection<T>(string procedureName, Func<IDataReader, T> mapper,Dictionary<string, string> paramsDictionnary = null);


    }
}
