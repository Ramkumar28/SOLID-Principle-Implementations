using System;
using System.Collections.Generic;

namespace SOLID_Example
{
     /*
     Say for example when a employee joins the company he just intimates the reception to give the id card not create id Id card on his own.
     */

     public class Company
     {
        private List<Employee> listofEmployees = new List<Employee>();

        public List<Employee> ListofEmployees { get => listofEmployees; set => listofEmployees = value; }

        public bool AddEmployeeToCompany(Employee employee)
        {
             JoiningStatus joiningStatus = default(JoiningStatus);
           var result= Enum.TryParse<JoiningStatus>(employee.StatusOfjoining.ToString(),out joiningStatus);
            if(employee!=null && result && joiningStatus == JoiningStatus.NewlyJoined)
            {
                listofEmployees.Add(employee);
                ProvideIdCard(employee);
                return true;
            }
           return default(bool);
        }


         // Here this method can be modified and so that new Employee doesnt need to call two seperate method rather just one above mehtod. 

        /*public void ProvideIdCard(Employee employee)
        {
            JoiningStatus joiningStatus = default(JoiningStatus);
           var result= Enum.TryParse<JoiningStatus>(employee.StatusOfjoining.ToString(),out joiningStatus);
            if(listofEmployees.Contains(employee) && result && joiningStatus == JoiningStatus.NewlyJoined)
            {
            Console.WriteLine("Will give you new ID card");
            }
        }*/

        public void ProvideIdCard(Employee employee)
        {
        
            if(listofEmployees.Contains(employee))
            {
            Console.WriteLine("Will give you new ID card");
            }
        }
    }
}