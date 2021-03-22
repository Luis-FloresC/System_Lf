using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace System_Lf
{
    
    public abstract class Conexion
    {

        private readonly String Connection_st;

        public Conexion()
        {
            Connection_st = ConfigurationManager.ConnectionStrings["System_Lf.Properties.Settings.SystemLfDb"].ConnectionString;

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Connection_st);
        }


    }
}
