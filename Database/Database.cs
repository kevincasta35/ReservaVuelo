using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Database
{


    public class Database
    {
        private static Database _instance;
        private readonly string _connectionString;
        public SqlConnection Connection { get; private set; }

        private Database()
        {
            _connectionString = "Server=DESKTOP-2US5BA3\\MSSQLSERVER01;Database=ReservaPasajes;Trusted_Connection=True;";
            Connection = new SqlConnection(_connectionString);
        }

        public static Database Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }

        public void Open()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }

        public void Close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
    }
}
