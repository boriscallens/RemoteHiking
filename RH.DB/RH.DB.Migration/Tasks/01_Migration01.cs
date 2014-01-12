using FluentMigrator;

namespace RH.DB.Migration.Tasks
{
    [Migration(01)]
    public class Migration01: FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey();
        }

        public override void Down()
        {
            Delete.FromTable("Users");
            Delete.Table("Users");
        }
    }
}