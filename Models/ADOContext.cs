﻿using Microsoft.Data.SqlClient;

namespace API_EjercicioIntroduccionDatosOrdenadores.Services
{
    public class ADOContext
    {
        private readonly SqlConnection _connection;

        public ADOContext(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
