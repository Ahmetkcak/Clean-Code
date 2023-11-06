using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Method1;

namespace BuilderPattern.Method2;

public abstract class EmployeeBuilder2 : IEmployeeBuilder2
{
    protected Employee2 Employee { get; set; }
    public EmployeeBuilder2()
    {
        Employee = new Employee2();
    }
    public abstract void SetFullName(string fullName);
    public abstract void SetEmailAddress(string emailAddress);
    public abstract void SetUserName(string userName);
    public Employee2 BuildEmployee() => Employee;
}
