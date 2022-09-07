using Azure.Identity;
using PrsLibrary;
using PrsLibrary.Controllers;
using PrsLibrary.Models;

Connection connection = new();
connection.Connect();

UsersController userCtrl = new(connection);

User? u = userCtrl.Login("sa", "sax");
if (u is not null)
    Console.WriteLine($"{u.Id} | {u.Username} | {u.Firstname} {u.Lastname}");
else
    Console.WriteLine("Login Failed: User or Password not found.");

connection.Disconnect();

//IEnumerable<Product> products = prodCtrl.GetAll();
//foreach(Product p in products)
//{
//    Console.WriteLine($"{p.PartNbr,-15} | {p.Name,-20} | {p.Price,10:C} | {p.Vendor.Name,-30}");
//}

//Product? i = prodCtrl.GetByPk(1);
//if( i is null)
//{
//    Console.WriteLine("Product is not found!");
//}
//else
//{
//    Console.WriteLine($"{i.PartNbr,-15} | {i.Name,-20} | {i.Price,10:C} | {i.Vendor.Name,-30}");
//}
//Vendor? vendor = vendorCtrl.GetByPk(1);
//if (vendor is null)
//{
//    Console.WriteLine("Vendor is not found!");
//}
//else
//{
//    Console.WriteLine($"{vendor.Code} {vendor.Name}");
//}

//IEnumerable<Vendor> vendors = vendorCtrl.GetAllVendors();
//foreach (Vendor v in vendors)
//{
//    Console.WriteLine($"{v.Name} {v.Code}");
//}

//Vendor newVendor = new()
//{
//    Code = "TEST",
//    Name = "TEST",
//    Address = "123 Way",
//    City = "TEST City",
//    Phone = "1800",
//    Email = "1800@gmail.com",
//    State = "NY",
//    Zip = "54321"
//};
//bool ok = vendorCtrl.Insert(newVendor);
//Console.WriteLine($"The insert was succesful! {ok}");Vendor newVendor = new()

//Vendor? updateVendor = vendorCtrl.GetByPk(4);

//    updateVendor.Code = "UPDT";
//    updateVendor.Name = "UPDT";
//    updateVendor.Address = "432 Way";
//    updateVendor.City = "UPDT City";
//    updateVendor.Phone = "1900";
//    updateVendor.Email = "1900@gmail.com";
//    updateVendor.State = "CA";
//    updateVendor.Zip = "12345";

//bool success = vendorCtrl.Update(updateVendor);
//Console.WriteLine($"The update was succesful! {success}");


//UsersController userCtrl = new(connection);

//User? xx1user = userCtrl.GetByPk(5);
//xx1user.Username = "yy";
//xx1user.Password = "yy";
//xx1user.Firstname = "yy";
//xx1user.Lastname = "yy";
//bool updated = userCtrl.Update(xx1user);
//Console.WriteLine($"The Update was successful! {updated}");

//bool success = userCtrl.Delete(4);
//Console.WriteLine($"The delete was successful! {success}");

//User newUser = new()
//{
//    Username = "xx1",
//    Password = "xx",
//    Firstname = "xx",
//    Lastname = "xx",
//    Phone = "911",
//    Email = "911@gmail.com",
//    IsReviewer = true,
//    IsAdmin = false
//};
//bool ok = userCtrl.Insert(newUser);
//Console.WriteLine($"The insert was succesful! {ok}");


//User? user = userCtrl.GetByPk(1);
//if(user is null)
//{
//    Console.WriteLine("User is not found!");
//}
//else
//{
//    Console.WriteLine($"{user.Firstname} {user.Lastname}");
//}

//IEnumerable<User> users = userCtrl.GetAllUsers();
//foreach(User u in users)
//{
//    Console.WriteLine($"{u.Firstname} {u.Lastname}");
//}



