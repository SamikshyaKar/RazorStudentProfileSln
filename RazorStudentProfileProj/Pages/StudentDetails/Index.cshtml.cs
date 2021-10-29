using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentProfile.Models;
using RazorStudentProfile.Services;

namespace RazorStudentProfileProj.Pages.StudentDetails
{
    public class IndexModel : PageModel
    {
        private readonly IStudentRepositories studentRepositories;

        public IndexModel(IStudentRepositories studentRepositories)
        {
            this.studentRepositories = studentRepositories;
        }

        public IEnumerable<Students>  StudentsProperty{ get; set; }
        public void OnGet()
        {

            StudentsProperty = studentRepositories.GetallstudentDetails();
        }
    }
}
