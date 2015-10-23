using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Clinic_Assistant.Domain
{
    public class Patient
    {
        public virtual Guid id { get; set; }
        public virtual string name { get; set; }
        public virtual string phone { get; set; }
        //private string gender;
        //private DateTime dob;
    }
}
