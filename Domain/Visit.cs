using System;

namespace Clinic_Assistant.Domain
{
    public class Visit
    {
        public virtual int id { get; set; }
        public virtual string purpose { get; set; }
        public virtual DateTime date { get; set; }
        public virtual Patient patient { get; set; }
    }
}


