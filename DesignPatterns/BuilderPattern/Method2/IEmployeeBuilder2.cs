namespace BuilderPattern.Method2
{
    public interface IEmployeeBuilder2
    {
        Employee2 BuildEmployee();
        void SetEmailAddress(string emailAddress);
        void SetFullName(string fullName);
        void SetUserName(string userName);
    }
}