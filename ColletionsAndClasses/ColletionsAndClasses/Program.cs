using ColletionsAndClasses;


// Assignment 01

Person person = new Person();
person.Name = "John";
person.Age = 25;

Console.WriteLine(person.GetInfo());

Console.WriteLine();
Console.WriteLine();


// Assignment 02

Car car = new Car();
car.Brand = "Toyota";
car.Year = 2008;

Console.WriteLine(car.GetInfo());

Console.WriteLine();
Console.WriteLine();


// Assignment 03

Product product = new Product();
product.Name = "Potato";
product.Price = 15.25m;
product.Currency = Currency.USD;

Console.WriteLine(product.GetInfo());













//internal enum Colors
//{
//    White,
//    Green,
//    Red
//}

//internal class Program
//{
//    public static void Main()
//    {
//        var company = new Company
//        {
//            Employees = GetEmployees()
//        };

//        var dateTime = DateTime.Now;

//        var color = Colors.Green;

//        switch (color)
//        {
//            case Colors.White:

//                break;

//            case Colors.Green:
//                break;

//            case Colors.Red:
//                break;

//            default:
//                throw new ArgumentOutOfRangeException();
//        }

//        var totalAmountToPay = company.CalculateTotalSalary();

//        Console.WriteLine($"Total amount to pay: {totalAmountToPay:C}");
//    }

//    private static List<Employee> GetEmployees()
//    {
//        return new List<Employee>
//        {
//            new Employee
//            {
//                Name = "Daviti",
//                Wage = 70.06m,
//                WorkedHours = 7
//            },

//            new Employee
//            {
//                Name = "Gia",
//                Wage = 80.01m,
//                WorkedHours = 8
//            },

//            new Employee
//            {
//                Name = "Gela",
//                Wage = 50.19m,
//                WorkedHours = 11
//            },

//            new Employee
//            {
//                Name = "Mariami",
//                Wage = 82.00m,
//                WorkedHours = 9
//            },
//        };
//    }
//}