namespace DAL_layer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL_layer.EmsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL_layer.EmsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            base.Seed(context);
            DeptMaster d1 = new DeptMaster { DeptCode = 1, DeptName = "Accounts" };
            DeptMaster d2 = new DeptMaster { DeptCode = 2, DeptName = "IT" };

            context.DeptMasters.Add(d1);
            context.SaveChanges();
            context.DeptMasters.Add(d2);
            context.SaveChanges();
            EmpProfile empProfile = new EmpProfile { EmpCode = 1, EmpName = "Moses", DateOfBirth = new DateTime(2001, 12, 11), DeptCode = 1, Email = "johncena@gmail.com" };
            context.EmpProfiles.Add(empProfile);
            context.SaveChanges();
        }
    }
}
