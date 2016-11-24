using System;
using System.Collections.Generic;

namespace ManageLife.Data.Entity
{
    public class TaskCategory
    {
        public TaskCategory()
        {

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubCategoryId { get; set; }
        public IList<TaskSubCategory> TaskSubCategories { get; set; }
    }
}