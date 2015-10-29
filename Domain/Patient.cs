using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Clinic_Assistant.Domain
{
    public class Patient
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string phone { get; set; }
        public virtual string gender { get; set; }
        public virtual DateTime dateOfBirth { get; set; }
        public virtual Nullable<int> age { get; set; }
        public virtual string medical_history { get; set; }
    }
}
