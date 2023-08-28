using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitingMS.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IDepartmentRepository departmentRepository { get; }
        IUserRepository UserRepository { get; }
        
        void save();

    }
}
