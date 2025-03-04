using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
    static void Main(string[] args)
    { 
      //*********************************
      //******* Task3 Test Code *********
      //*********************************
      Employee hrRep = new HR();

      hrRep.ClockIn();
      hrRep.Work();
      hrRep.SubmitDailyReport();
      Console.WriteLine(); //Line break

      Employee employee1 = new Engineer();
      employee1.SubmitDailyReport();

      Employee employee2 = new Manager();
      employee2.ClockIn();
      employee2.Work();
      employee2.SubmitDailyReport();

      Employee employee3 = new Intern();
      employee3.ClockIn();
      employee3.Work();
      employee3.SubmitDailyReport();

      Employee employee4 = new Engineer();
      employee4.SubmitDailyReport();

      Engineer engineer4 = employee4 as Engineer;
      if (engineer4 != null)
      {
        engineer4.SubmitDailyReport();
      }
      else
      {
        Console.WriteLine("Downcast to Engineer failed.");
      }

      List<Employee> employees = new List<Employee>();

      employees.Add(employee1);
      employees.Add(employee2);
      employees.Add(employee3);

      foreach (Employee employee in employees)
      {
        employee.ClockIn();
        employee.Work();
        employee.SubmitDailyReport();

        if (employee is Engineer)
        {
          Console.WriteLine("This is an Engineer.");
        }
        else if (employee is Manager)
        {
          Console.WriteLine("This is a Manager.");
        }
        else if (employee is Intern)
        {
          Console.WriteLine("This is an Intern.");
        }  
      }
    }
  }
}
