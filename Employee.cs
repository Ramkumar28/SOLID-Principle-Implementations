using System;

namespace SOLID_Example
{
public interface IAccessColorPrinter
{
  void ColorPrinterAccess();
}

public interface IAccessVisitingCard
{
void VisitingCardAccess();
}

    public interface IExperiencedEmployeeAcess
    {

    }
    public class Employee
    {
        private string _name;
        private int _empId;
        private string _address;
        private JoiningStatus _statusOfjoining;

        private double _yearsOfExperinceAtCompany;

        public string Name { get => _name; set => _name = value; }
        public int EmpId { get => _empId; set => _empId = value; }
        public string Address { get => _address; set => _address = value; }

        public JoiningStatus StatusOfjoining { get => _statusOfjoining; set => _statusOfjoining = value; }

        public double YearsOfExperience
        {
            get
            {
                if(StatusOfjoining == JoiningStatus.NewlyJoined)
                {
                    return _yearsOfExperinceAtCompany= 0;
                }
                return _yearsOfExperinceAtCompany;
            }

            set
            {
                if(StatusOfjoining == JoiningStatus.NewlyJoined)
                {
                    _yearsOfExperinceAtCompany= 0;
                }
                else
                _yearsOfExperinceAtCompany = value;
            }
        }

        public virtual void CheckAvailableGratutiy()
        {
         Console.WriteLine("No Graduity avaialble");
        }
    }

    public class FiveYearsExperince : Employee,IAccessColorPrinter
    {
         public override void CheckAvailableGratutiy()
         {
             Console.WriteLine("5 years Graduatity avaialble");
         }

        public void ColorPrinterAccess()
        {
             Console.WriteLine("ColorPrinter Access Avaialble");
        }
    }

    public class TenYearsofExpereince : Employee,IAccessColorPrinter,IAccessVisitingCard
    {
        public override void CheckAvailableGratutiy()
        {
            Console.WriteLine("10 Years of Experince");
        }

        public void ColorPrinterAccess()
        {
           Console.WriteLine("Color Printer Access Avaialable");
        }

        public void VisitingCardAccess()
        {
            Console.WriteLine("Visiting Card Access available");
        }
    }


}