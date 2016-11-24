using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManageLife.Data.Entity;
using ManageLife.Repositories;
using System.Linq;

namespace ManageLife.Data.Test
{
    [TestClass]
    public class DataOperationFixture
    {
        [TestMethod]
        public void ShouldInsertDataInTaskCategory()
        {
            var taskCategoryRepository = new TaskCategoryRepository();
            var result = taskCategoryRepository.GetById("a9894a23-febb-40a1-9ce5-aff2b0461f95");
            
        }
    }
}
