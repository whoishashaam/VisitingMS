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
    public class UserRepository:Repository<UserModel>,IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
            
        }

      

        public void Update(UserModel visitor)
        {
            _db.Update(visitor);
        }
    }
}
