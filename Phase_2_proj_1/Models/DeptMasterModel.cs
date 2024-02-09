using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase_2_proj_1.Models
{
    public class DeptMasterModel
    {
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<EmpProfileModel> EmpProfiles { get; set; }
    }
}