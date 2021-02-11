namespace NajDb
{
    public class NajConfiguration
    {
        public string ConnectionString { get; private set; }

        public NajConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
