using System;
using System.Collections.Generic;
namespace SOLID_Example
{
    class Program
    {
        static void Main(string[] args)
        {
          // 1. Single Respnsiblity Principle.

          var newEmployee = new Employee{ Name="Ramkumar",EmpId=1,Address="Velachery",StatusOfjoining = JoiningStatus.NewlyJoined};

          var _company = new Company();

          _company.AddEmployeeToCompany(newEmployee);

          //2. Open to Extension and closed to modification.

          FiveYearsExperince fiveYears = new FiveYearsExperince();
          TenYearsofExpereince tenYearsofExpereince = new TenYearsofExpereince();

          //3. Liskov Substitution Principle
          /*A subclass (Dog or Bird) can be substituted for the base class (Animal) and everything still works. 
          The code itself doesn’t care. 
          We could also take this one step further and use a Factory method to create the class we want to use, 
        and the code wouldn’t even know the class at all. But that’s beyond this discussion.
        So now you know about Liskov Substitution Principle. 
        It’s well defined rules for using subtypes in place of the base type. 
        By following these rules, and others in SOLID, you will have better software that is more maintainable,
         easier to extend, and less fragile. Your software garden will be lush, green, and thriving. */
          Animal dog = new Dog();
          dog.MakeNoise();
          dog.Fly();


          //4.Interface Segregation principle 

          // The access of experienced employees are seperated by Interfaces. as shown.

          // 5. Dependency Inversion Principle is shown 
          var mail = new Email();
          var sms = new SMS();
         var collection = new List<IMessgae>();
         collection.Add(mail);
         collection.Add(sms);
         var notification = new Notification(collection);
         notification.SendMessages();
        }
    }
}
