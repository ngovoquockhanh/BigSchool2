using System;
using System.Data.Entity;
using System.Linq;

namespace BigSchool.Models
{
    public class BigSchoolContext : DbContext
    {
        // Your context has been configured to use a 'BigSchoolContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BigSchool.Models.BigSchoolContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BigSchoolContext' 
        // connection string in the application configuration file.
        public BigSchoolContext()
            : base("name=BigSchoolContext")
        {
        }
        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}