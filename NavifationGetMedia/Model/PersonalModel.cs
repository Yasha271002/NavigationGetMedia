using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavifationGetMedia.Model
{
    public class PersonalModel
    {
        public string? Departament { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
    }

    public class PersonalInfo()
    {
        public string? Specialization { get; set; }
        public string? PersonalImage { get; set; }
        public string? Name { get; set; }
    }
}
