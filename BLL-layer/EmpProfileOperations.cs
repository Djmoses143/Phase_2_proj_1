using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_layer;

namespace BLL_layer
{
    public class EmpProfileOperations
    {
        EmpProfileRepository empProfileRepository = new EmpProfileRepository();

        public void insertEmpProfile(EmpProfile empProfile)
        {
            empProfileRepository.Insert(empProfile);

        }

        public List<EmpProfile> ListOfEmployee()
        {
            return empProfileRepository.GetAll().ToList();

        }
    }
}
