
using NorthwindLinqEFLibrary.Controllers;
using NorthwindLinqEFLibrary.Models;

Console.WriteLine("LINQ EF and Northwind");

AppDbContext _context = new AppDbContext();

EmployeesController emplCtrl = new(_context);

CustomersController custCtrl = new(_context);

var customer = await custCtrl.GetByPK("ZZZZZ");

Print(customer?.ToString() ?? "Customer not found!");



/*
custCtrl.Delete("AAAAA");

Customer custUPDATE = custCtrl.GetByPK("AAAAA");

custUPDATE.ContactName = "Albert Allow";

custCtrl.Update("AAAAA", custUPDATE);
*/

/*
Customer? newCust = new()
{
    CustomerId = "AAAAA",
    CompanyName = "ATESTING Company",
    ContactName = "Jimmy Johns",
};

custCtrl.Insert(newCust);
*/


/*
Customer cust1 = custCtrl.GetByPK("TORTU");

Print(cust1);
*/

//List<Customer> cuts = custCtrl.GetAll().ToList();

//foreach(Customer c in cuts)
//    Print(c);


/*
var employees = emplCtrl.GetByPartialLastName("ll");

foreach (Employee employee in employees)
    Print(employee);

emplCtrl.Delete(10);

Employee? newEmpl = new()
{
    EmployeeId = 0,
    Lastname = "Phence",
    Firstname = "Noah",
    Title = "Joker",
    TitleOfCourtesy = "Mr.",
    BirthDate = new DateTime(2022, 9, 12),
};

emplCtrl.Insert(newEmpl);

Print(newEmpl);

Employee empl1 = emplCtrl.GetByPK(1);

empl1.TitleOfCourtesy = "Ms.";

emplCtrl.Update(1, empl1);

Print(empl1);

List<Employee> empls = emplCtrl.GetAll().ToList();

foreach (Employee empl in empls)
{
    Print(empl);
}
*/

void Print(object obj)
{
    if (obj is null)
        obj = "(NULL)";
    Console.WriteLine(obj);
    System.Diagnostics.Debug.WriteLine(obj.ToString());
}