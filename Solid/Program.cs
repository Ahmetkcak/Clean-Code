using SModel;

namespace Solid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Solid Principle

            #region With class examples
            User user;
            user = new User
            {
                Name = "John",
                Email = "j31@gmail.com",
                Adres = new Adres { City = "London", Country = "UK" }
            };
            Console.WriteLine(
                "Name: "
                    + user.Name
                    + ", Email: "
                    + user.Email
                    + ", City: "
                    + user.Adres.City
                    + ", Country: "
                    + user.Adres.Country
            );
            #endregion


            #region With method examples
            void handleStudent() // 1000
            {
                // registerStudent();
                // calculate_Student_Results();
                // sendEmail();
            }

            void registerStudent()
            {
                // some logic
            }

            void calculate_Student_Results()
            {
                // some logic
            }

            void sendEmail() // bir adet logic
            {
                // some logic
            }
            #endregion

            #endregion

            #region Open Closed Principle
            Circle circle = new Circle();
            circle.Radius = 10;
            circle.Draw();
            Console.WriteLine("Area: " + circle.CalculateArea());
            #endregion

            #region Dependency Inversion Principle
            Logger fileLogger = new Logger(new FileLogger());
            Logger dbLogger = new Logger(new DbLogger());



            fileLogger.Log("File Logger");
            dbLogger.Log("Db Logger");
            #endregion
        }
    }
}
