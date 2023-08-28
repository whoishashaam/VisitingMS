using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitingMS.Data;
using VisitingMS.DataAccess.Repository.IRepository;
using VisitingMS.Models;

namespace VisitingMS.DataAccess.Repository
{
    public class DepartmentRepository:Repository<DepartmentModel>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _db;
        public DepartmentRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
            
        }

      

        public void Update(DepartmentModel department)
        {
            _db.Departments.Update(department);
        }
    }
}
