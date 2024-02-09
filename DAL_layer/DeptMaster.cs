using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL_layer
{
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public int DeptCode { get; set; }
        public virtual DeptMaster DeptMaster { get; set; }
    }
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<EmpProfile> EmpProfiles { get; set; }

    }
    public class EmsContext : DbContext
    {
        public EmsContext() : base("name=EmsContext")
        {

            


        }
        public DbSet<EmpProfile> EmpProfiles { get; set; }
        public DbSet<DeptMaster> DeptMasters { get; set; }
    }
    
}
