using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharterERP.Core
{
    public class Employee
    {

        public virtual  int Id { get; set; }
        public virtual string Name { get; set; }
        //? = Nullable
        public virtual DateTime? HireDate { get; set; } 

    }
}
