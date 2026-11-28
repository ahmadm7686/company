using company.DAL.Data.Contexts;
using company.DAL.Models;
using company.PLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace company.PLL.Repositories
{
    public class DepartmentRopository : IDepartmentRepository
    {

        private readonly CompanyDbContext _context;

        public DepartmentRopository()
        {
            _context = new CompanyDbContext();
        }

        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }

        public int Delete(Department department)
        {
            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }

        public Department? Get(int id)
        {
            return _context.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();

        }

        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }
    }
}
