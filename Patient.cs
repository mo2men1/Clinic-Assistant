using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Assistant
{
   class Patient
   {
      private string name,phone,gender;
      private int id;
      private DateTime dob;

      public void setName(string n)
      {
         name = n;
      }

      public void setPhone(string ph)
      {
         phone = ph;
      }

      public void setGender(string g)
      {
         gender = g;
      }

      public void setID(int n)
      {
         id = n;
      }

      public void setDOB(DateTime date)
      {
         dob = date;
      }

      public string Name()
      {
         return name;
      }

      public string Phone()
      {
         return phone;
      }

      public string Gender()
      {
         return gender;
      }

      public int ID()
      {
         return id;
      }

      public DateTime DOB()
      {
         return dob;
      }
   }
}
