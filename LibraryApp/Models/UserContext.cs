using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace LibraryApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("Connection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Roles.Add(new Role { Id = 3, Name = "admin" });
            db.Roles.Add(new Role { Id = 2, Name = "libririan" });
            db.Roles.Add(new Role { Id = 1, Name = "user" });
            db.Roles.Add(new Role { Id = 0, Name = "guest" });
            base.Seed(db);
        }
    }
}