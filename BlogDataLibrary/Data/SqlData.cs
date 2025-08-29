namespace BlogDataLibrary.Data
{
    public class SqlData
    {
        private readonly ISqlDataAccess _db;
        private readonly string connectionStringName = "Sqldb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
    }
}

