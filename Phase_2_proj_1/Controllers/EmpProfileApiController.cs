﻿using BLL_layer;
using DAL_layer;
using Phase_2_proj_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Phase_2_proj_1.Controllers
{
    public class EmpProfileApiController : ApiController
    {
        EmpProfileOperations profileOperations = new EmpProfileOperations();
        public void Post(EmpProfileModel empModel)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = empModel.EmpCode;
            emp.EmpName = empModel.EmpName;
            emp.DateOfBirth = empModel.DateOfBirth;
            emp.Email = empModel.Email;
            emp.DeptCode = empModel.DeptCode;
            profileOperations.insertEmpProfile(emp);

        }

        public List<EmpProfileModel> GetAll()
        {
            List<EmpProfile> list = profileOperations.ListOfEmployee();
            List<EmpProfileModel> empList = new List<EmpProfileModel>();
            foreach (EmpProfile empModel in list)
            {
                EmpProfileModel emp = new EmpProfileModel();
                emp.EmpCode = empModel.EmpCode;
                emp.EmpName = empModel.EmpName;
                emp.DateOfBirth = empModel.DateOfBirth;
                emp.Email = empModel.Email;
                emp.DeptCode = empModel.DeptCode;
                empList.Add(emp);
            }
            return empList;
        }
    }
}
