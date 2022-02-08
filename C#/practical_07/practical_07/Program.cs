using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_07
{
    public class Student
    {
        public int StudentID;
        public string StudentName;
        public int age;
    }
    #region Single Resposibility Principle Example
    //Single Resposibility Principle Example
    public class SigleresposibilityPrinciple
    {

        public bool AddStudentDetails()
        {
            Console.WriteLine("Single Resposibility Principle Example");
            return true;
        }
    }
    #endregion Single Resposibility Principle Example
    //Single Resposibility Principle Example

    #region Open Closed Principle Example
    //Open Closed Principle Example
    public class OpenClosedPrinciple//never modify only extends
    {
        public string ReportType;
        public virtual void GenerateReport()
        {
            Console.WriteLine("Report Details");
        }
    }
    public class ResultInformationReport : OpenClosedPrinciple
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Report new Details");
        }
    }
    public class StudentInformatReport : OpenClosedPrinciple
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Report data Details");
        }
    }
    //Open Closed Principle Example
    #endregion Open Closed Principle Example
    //Liskov Substitution Principle Example
    #region Liskov Substitution Principle Example
    public interface ResultInformation
    {
        string GetResultinformationDetails();
    }
    public class IResultInformationReport : ResultInformation
    {

        public string GetResultinformationDetails()
        {
            try
            {
                    throw new NotImplementedException();
            }
            catch(Exception ex)
            {
                return "error (Liskov Substitution Principle Example)";
            }
        }
    }
    //Liskov Substitution Principle Example
    #endregion Liskov Substitution Principle Example
    #region Interface Segretion Principle
    //Interface Segretion Principle
    public interface IBaseEmp
    {
        string EmpID { get; set; }
        string EName { get; set; }
    }
    public interface IFTEmpSalary : IBaseEmp
    {
        float Sal { get; set; }
        float Bonus { get; set; }
        float CalcTotalSal();
    }
    public class InterfaceSegretion : IFTEmpSalary
    {
        public string EmpID { get; set; }
        public string EName { get; set; }
        public float Sal { get; set; }
        public float Bonus { get; set; }
        public float CalcTotalSal() => Sal + Bonus;
    }

    //Interface Segretion Principle
    #endregion Interface Segretion Principle
    #region Dependency inversion Principle
    //Dependency inversion Principle
    public interface ISalaryCalc //created an interface ISalaryCalc
    {
        float CalcSal(int hrWork, float hrRate);
    }

    public class SalaryCalcModified : ISalaryCalc //implements this interface.
    {
        public float CalcSal(int hrWork, float hrRate) => hrWork * hrRate;
    }
    public class EmpDetailsModified //higher-level class EmpDetails is directly depending upon the lower level SalaryCalc class.
    {
        private readonly ISalaryCalc _salaryCalc;// abstraction implementation to use
        public int HrWork { get; set; }
        public int HrRate { get; set; }
        public EmpDetailsModified(ISalaryCalc salaryCalc)
        {
            _salaryCalc = salaryCalc;
        }
        public float GetSalary()
        {
            return _salaryCalc.CalcSal(HrWork,HrRate);
        }
    }
    //Dependency inversion Principle
    #endregion Dependency inversion Principle
    #region Main Class
    class Program
    {
        static void Main(string[] args)
        {
            SigleresposibilityPrinciple s = new SigleresposibilityPrinciple();//Sigle resposibility Principle
            Console.WriteLine(s.AddStudentDetails());
            StudentInformatReport s1 = new StudentInformatReport();//Open Closed Principle Example
            s1.GenerateReport();
            ResultInformationReport r1 = new ResultInformationReport();
            r1.GenerateReport();
            InterfaceSegretion isp = new InterfaceSegretion();//Interface Segretion Principle Example
            Console.WriteLine("Enter Emp Name:");
            isp.EName = Console.ReadLine();
            Console.WriteLine("Enter Bonus:");
            isp.Bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            isp.Sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{isp.EName} bonus with salary:{isp.CalcTotalSal()}");
           IResultInformationReport r = new IResultInformationReport();//Liskov Substitution Principle Example
            Console.WriteLine(r.GetResultinformationDetails());
            var empDetailsModified = new EmpDetailsModified(new SalaryCalcModified());//Dependency inversion Principle
            Console.WriteLine("Enter Hours Rate:");
            empDetailsModified.HrRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours Work:");
            empDetailsModified.HrWork = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Total Pay of Employee: {empDetailsModified.GetSalary()}");
            Console.ReadLine();
        }
    }
    #endregion Main Class
}
