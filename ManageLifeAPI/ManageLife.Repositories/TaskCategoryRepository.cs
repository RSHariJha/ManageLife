using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ManageLife.Data.Entity;
using ManageLife.Data.Context;

namespace ManageLife.Repositories
{
    public class TaskCategoryRepository : IGenericRepository<TaskCategory>
    {
        private ManageLifeContext _manageLifeContext;
        public TaskCategoryRepository()
        {
            _manageLifeContext = new ManageLifeContext();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public List<TaskCategory> Get(Expression<Func<TaskCategory, bool>> filter = null, Func<IQueryable<TaskCategory>, IOrderedQueryable<TaskCategory>> orderBy = null, params Expression<Func<TaskCategory, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public TaskCategory GetById(object id)
        {
            var taskCategoryId = Guid.Parse(id.ToString());

            var result = _manageLifeContext.TaskCategories.FirstOrDefault(x => x.Id == taskCategoryId);

            return result;
        }

        public TaskCategory GetFirstOrDefault(Expression<Func<TaskCategory, bool>> filter = null, params Expression<Func<TaskCategory, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public void Insert(TaskCategory entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TaskCategory> Query(Expression<Func<TaskCategory, bool>> filter = null, Func<IQueryable<TaskCategory>, IOrderedQueryable<TaskCategory>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TaskCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
