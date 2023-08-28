using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using VisitingMS.Data;
using VisitingMS.DataAccess.Repository.IRepository;

namespace VisitingMS.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IDepartmentRepository? departmentRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            departmentRepository = new DepartmentRepository(_db);
            UserRepository = new UserRepository(_db);
        }
      
          
        public void save()
        {
            _db.SaveChanges();
        }
    }
}
