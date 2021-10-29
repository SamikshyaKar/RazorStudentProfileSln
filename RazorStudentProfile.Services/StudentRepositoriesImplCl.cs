using RazorStudentProfile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorStudentProfile.Services
{
    public class StudentRepositoriesImplCl : IStudentRepositories
    {
        private readonly IEnumerable<Students> _studentdetaillist;

        public IEnumerable<Students> GetallstudentDetails()
        {
            return _studentdetaillist;
        }
    }
}
