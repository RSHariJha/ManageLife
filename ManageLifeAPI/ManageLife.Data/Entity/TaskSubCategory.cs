using System;

namespace ManageLife.Data.Entity
{
    public class TaskSubCategory
    {
        public TaskSubCategory()
        {

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ParentCategoryId { get; set; }
    }
}
