using MigSharp;

namespace LibContainingMigrations.Migrations
{
    public class Migration1 : IMigration
    {
        public void Up(IDatabase db)
        {
            var sql = "SELECT @@VERSION;";
            db.Execute(sql);
        }
    }
}
