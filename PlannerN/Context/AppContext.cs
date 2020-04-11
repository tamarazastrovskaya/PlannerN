namespace PlannerN.Context
{
    internal class AppContext
    {
        internal object categories;
        private string dsn;

        public AppContext(string dsn)
        {
            this.dsn = dsn;
        }
    }
}