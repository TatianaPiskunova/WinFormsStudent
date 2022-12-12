using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace экзамен.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string SecondName { get; set; }
        public int Adonet { get; set; }

        public  GroupStud Group { get; set; }
    }
}
