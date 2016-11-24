using System;
using System.Collections.Generic;
using System.Linq;
using ManageLife.Data.Entity;
using System.Data.Entity;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace ManageLife.Data.Context
{
    public class ManageLifeContext: DbContext
    {
        public ManageLifeContext():base("SqlConnection")
        {

        }

        public DbSet<TaskCategory> TaskCategories { get; set; }
        public DbSet<TaskSubCategory> TaskSubCategories { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}
