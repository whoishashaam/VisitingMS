using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitingMS.Models;

namespace VisitingMS.DataAccess.Repository.IRepository
{
    public interface IDepartmentRepository:IRepository<DepartmentModel>
    {

        void Update(DepartmentModel department);

    
    }
}
