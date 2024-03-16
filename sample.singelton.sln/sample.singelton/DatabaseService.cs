namespace sample.singelton
{
    sealed class DatabaseService
    {
        private DatabaseService() { }

        private static DatabaseService _instance;
        private static readonly object _lock = new object();

        public static DatabaseService Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseService();
                    }
                }
            }

            return _instance;
        }
    }
}
