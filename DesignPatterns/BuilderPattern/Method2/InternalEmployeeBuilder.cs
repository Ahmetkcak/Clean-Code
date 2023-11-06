using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Method2;

namespace BuilderPattern;

public class InternalEmployeeBuilder : EmployeeBuilder2
{
    public override void SetEmailAddress(string emailAddress)
    {
        var arr = emailAddress.Split('@');
        // endswith @company.com.tr
        Employee.EmailAddress = arr[0] + "@company.com.tr";
    }

    public override void SetFullName(string fullName)
    {
        throw new NotImplementedException();
    }

    public override void SetUserName(string userName)
    {
        throw new NotImplementedException();
    }
}
