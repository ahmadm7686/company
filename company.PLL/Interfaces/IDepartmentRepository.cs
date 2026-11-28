using company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace company.PLL.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department? Get(int id);
        int Add(Department department);
        int Update(Department department);
        int Delete(Department derpartment);



    }
}
