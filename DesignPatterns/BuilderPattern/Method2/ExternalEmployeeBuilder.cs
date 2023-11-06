using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2;

public class ExternalEmployeeBuilder : EmployeeBuilder2
{
    public override void SetEmailAddress(string emailAddress)
    {
        throw new NotImplementedException();
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
