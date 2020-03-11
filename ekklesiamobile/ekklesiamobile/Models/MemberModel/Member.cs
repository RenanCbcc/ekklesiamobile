using ekklesiamobile.Models.MemberModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ekklesiamobile.Models
{
    public class Member : BaseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Position Position { get; set; }
        public string PhotoPath { get; set; }

    }
}
