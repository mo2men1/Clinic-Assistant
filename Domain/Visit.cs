using System;

namespace Clinic_Assistant.Domain
{
    public class Visit
    {
        public virtual int id { get; set; }
        public virtual Patient patient { get; set; }

        public virtual DateTime date { get; set; }
        public virtual string complaint { get; set; }
        public virtual string diagnosis { get; set; }

        public virtual string tooth { get; set; }
        public virtual string xray { get; set; }
        public virtual string treatment { get; set; }


        public virtual Nullable<int> cost { get; set; }
        public virtual Nullable<int> paid { get; set; }
        public virtual Nullable<int> remaining { get; set; }
    }
}


