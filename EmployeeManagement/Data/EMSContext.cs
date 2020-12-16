using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.data
{
public class EMSContext : DbContext  // DbContext represent the data base 
{
        public EMSContext()
        {
          
        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }
        // Dbset is built in class represent data base  and database will created with the name Employees
      public DbSet<Employee>  Employees {get; set;}    




}
}
