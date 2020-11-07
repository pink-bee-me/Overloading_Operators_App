using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators_App
{
    class Employee
    {
      
        public int ID { get; set; }
        public bool Duplicate { get; set; }
        public bool NotDuplicate { get; set; }
        
        
        public Employee()
        {
           
        }


         public void CheckId(Employee employee1, Employee employee2)
        {
            var ID_1 = employee1.ID;
            var ID_2 = employee2.ID;



        }
      

        public static bool operator == (Employee ID_1, Employee ID_2)
        {
            bool Duplicate = false;

            if ( ID_1 == ID_2 )
            {
                Duplicate = true;
            }
            return Duplicate;
        }
        
        public static bool operator !=(Employee ID_1, Employee ID_2)
        {
            bool NotDuplicate = false;
            if (ID_1 != ID_2)
            {
                NotDuplicate = true;
            } 
            return NotDuplicate ;
        }
         
       
      public void 
    }



}
