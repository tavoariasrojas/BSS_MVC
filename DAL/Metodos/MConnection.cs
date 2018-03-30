﻿using ServiceStack.OrmLite;

namespace DAL.Metodos
{
    public class MConnection
    {
        public OrmLiteConnectionFactory _conexion;
        public System.Data.IDbConnection _db;

        public MConnection()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
    }
}
