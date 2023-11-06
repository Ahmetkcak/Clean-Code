using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1;

public class EmployeeBuilder
{
    private Employee employee;

    public EmployeeBuilder()
    {
        employee = new Employee();
    }
    public EmployeeBuilder SetFullName(string fullName)
    {
        // validations
        var arr = fullName.Split(' ');
        employee.FirstName = arr[0];
        employee.LastName = arr[1];
        return this;
    }
    public EmployeeBuilder SetEmailAddress(string emailAddress)
    {
        // Email address validation
        employee.EmailAddress = emailAddress;
        return this;
    }

    public EmployeeBuilder SetUserName(string userName)
    {
        employee.UserName = userName;
        return this;
    }


    public Employee BuildEmployee()
    {
        return employee;
    }
}
