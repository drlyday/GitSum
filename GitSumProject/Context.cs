using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GitSumProject
{
    class Context : DbContext
    {
        public Context() : base("name=LocalSqlServer2") { }

        // Tell the Context that you want to include these classes in your datamodel
        public DbSet<DataModel.Workout> Workouts { get; set; }
        public DbSet<DataModel.Exercise> Exercises { get; set; }

    }
}
