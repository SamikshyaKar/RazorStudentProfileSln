using System;
using System.Collections.Generic;
using System.Text;

namespace RazorStudentProfile.Models
{
    public class Students
    {
        public int studID { get; set; }
        public string StName { get; set; }

        public string stEmail { get; set; }

        public string stPhoto { get; set; }

        public Branches? stbranch { get; set; }
    }
}
