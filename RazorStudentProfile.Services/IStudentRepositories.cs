using System;
using System.Collections.Generic;
using RazorStudentProfile.Models;

namespace RazorStudentProfile.Services
{
    public interface IStudentRepositories
    {
        IEnumerable<Students> GetallstudentDetails();

    }
}
