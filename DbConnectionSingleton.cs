
using System.Data.Common;

namespace SingletonDBConnection
{
    public sealed class DbConnectionSingleton
    {
        private static volatile DbConnectionSingleton? _instance;
        private static readonly object dbConnection = new();

        public DbConnectionSingleton() { }
        public static DbConnectionSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (dbConnection)
                    {
                        if (_instance == null)
                            _instance = new DbConnectionSingleton();
                    }
                }
                return _instance;
            }
        }
    }
}
