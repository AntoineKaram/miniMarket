using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Base
{
    public abstract class DataManagerBase : IDbManager
    {
        private string _connectionString;

        public DataManagerBase()
        {
            _connectionString = "Data Source=.;Initial Catalog=OnlineShopping;Integrated Security=SSPI;";

        }


        public IDbConnection GetConnection(string connectionString)
        {
            SqlConnection SqlCon = new SqlConnection(connectionString);
            SqlCon.Open();
            return SqlCon;
        }

        public IDbCommand GetCommand(string procedureName, IDbConnection con, Dictionary<string, string> paramsDictionnary = null)
        {
            SqlCommand command = new SqlCommand(procedureName, (SqlConnection)con);
            command.CommandType = CommandType.StoredProcedure;
            if (paramsDictionnary != null)
            {
                foreach (KeyValuePair<string, string> pair in paramsDictionnary)
                {
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                }
            }
            return command;
        }


        public bool ExecuteCommand(string procedureName, Dictionary<string, string> paramsDictionnary = null)
        {
            using (SqlConnection con = (SqlConnection)GetConnection(_connectionString))
            {
                using (SqlCommand command = (SqlCommand)GetCommand(procedureName, con, paramsDictionnary))
                {
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        //protected T ExecuteSingleton<T>(string procedureName, Func<IDataReader, T> mapper, Dictionary<string,object> paramsDictionnary = null)
        //{
        //}

        //protected List<T> ExecuteCollection<T>(string procedureName, Func<IDataReader, T> mapper, 
        //                                            Dictionary<string,string> paramsDictionnary = null)
        public List<T> ExecuteCollection<T>(string procedureName, Func<IDataReader, T> mapper, Dictionary<string, string> paramsDictionnary = null)
        {
            List<T> list = new List<T>();
            using (SqlConnection con = (SqlConnection)GetConnection(_connectionString))
            {
                using (SqlCommand command = (SqlCommand)GetCommand(procedureName, con, paramsDictionnary))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T instance = mapper.Invoke(reader);
                            list.Add(instance);
                        }
                        return list;
                    }
                }
            }
        }

    }
}

                //    // var table =  reader.GetSchemaTable();

                //    //dynamic expando = new ExpandoObject();
                //    var dict = new Dictionary<string, object>();

                //    int fieldsCount = reader.FieldCount;

                //for (int i = 0; i < fieldsCount; i++)
                //{
                //    var key = reader.GetName(i); //returns column name as it is in the procedure 
                //    var val = reader.GetValue(i); // column value

                //    dict.Add(key, val);
                //}   
