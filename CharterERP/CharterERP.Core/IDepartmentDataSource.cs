using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharterERP.Core
{
   public interface IDepartmentDataSource
    {
       IQueryable<Employee> Employee { get; }
       IQueryable<Department> Departments { get; }
    }
}
