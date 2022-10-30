using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFrameworkCodeFirst_Test.Model
{
    //To serve up, manage and persist the data in the database.
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
    }

    //This small class represents a complete data layer that you can use in your application.
    //You will be able to query, change, track and save Destination and Lodging Data.
}
