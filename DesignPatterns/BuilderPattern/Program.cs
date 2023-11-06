using BuilderPattern;
using BuilderPattern.Method1;
using BuilderPattern.Method2;
using System.Text;

//var sb = new StringBuilder();
//sb.Append("Ahmet");
//sb.Append("Koçak");
//var fullName = sb.ToString();

var eb = new EndpointBuilder("https://localhost");
eb
    .Append("api")
    .Append("v1")
    .AppendParam("id", "5");

var url = eb.Build();
Console.WriteLine(url);

var empBuilder = new EmployeeBuilder();
var employee = empBuilder
    .SetFullName("Ahmet Koçak")
    .SetUserName("ahkocak")
    .SetEmailAddress("ahmetkocak6146@gmail.com")
    .BuildEmployee();

Console.WriteLine(employee.FirstName);

var employeeBuilder = new InternalEmployeeBuilder();
employeeBuilder.SetEmailAddress("ahmetkocak6146@gmail.com");

var emp = employeeBuilder.BuildEmployee();
Console.WriteLine(emp.EmailAddress);