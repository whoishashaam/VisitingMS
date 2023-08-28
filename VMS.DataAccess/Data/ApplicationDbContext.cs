
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisitingMS.Models;

namespace VisitingMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<UserModel> Visitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DepartmentModel>().HasData(
            new DepartmentModel { Id = 10, DepartmentName = "Electrical", HOD = "Mushaaf" },
            new DepartmentModel { Id = 11, DepartmentName = "Mechenical", HOD = "Haide" },
            new DepartmentModel { Id = 12, DepartmentName = "Computing", HOD = "Mushara" }
       
                  );

            modelBuilder.Entity<UserModel>().HasData(
               new UserModel
               {
                   Id = 1,
                   CNIC = 1234567890123,
                   PhoneNo = 98765432101,
                   FullName = "John Doe",
                   EntryTime = DateTime.Now,
                   VisitorBelongings = "Laptop, Bag",
                   VisitingPurpose = "Meeting",
            DepartmentID=10,
            ImageUrl=""
            
               },
    new UserModel
    {
        Id = 2,
        CNIC = 9876543210987,
        PhoneNo = 12345678901,
        FullName = "Jane Smith",
        EntryTime = DateTime.Now,
        VisitorBelongings = "Mobile Phone",
        VisitingPurpose = "Interview",
        DepartmentID = 11,
        ImageUrl = ""

    },
    new UserModel
    {
        Id = 3,
        CNIC = 5555555555555,
        PhoneNo = 11111111111,
        FullName = "Michael Johnson",
        EntryTime = DateTime.Now,
        VisitorBelongings = "Backpack",
        VisitingPurpose = "Training",
        DepartmentID = 12,
        ImageUrl = ""

    },
    new UserModel
    {
        Id = 4,
        CNIC = 9999999999999,
        PhoneNo = 22222222222,
        FullName = "Emily Wilson",
        EntryTime = DateTime.Now,
        VisitorBelongings = "None",
        VisitingPurpose = "Delivery",
        DepartmentID = 12,
        ImageUrl = ""

    },
    new UserModel
    {
        Id = 5,
        CNIC = 4444444444444,
        PhoneNo = 33333333333,
        FullName = "David Lee",
        EntryTime = DateTime.Now,
        VisitorBelongings = "Keys",
        VisitingPurpose = "Maintenance",
        DepartmentID = 12,
        ImageUrl = ""
    }
        );
        }
    }
}
