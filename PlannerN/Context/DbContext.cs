namespace PlannerN.Context
{
    internal class DbContext
    {
        private string dsn;

        public DbContext(string dsn)
        {
            this.dsn = dsn;
        }
    }
}